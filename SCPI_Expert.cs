using Ivi.Visa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCPI_Expert
{
    public partial class SCPI_Expert : DevExpress.XtraEditors.XtraForm
    {
        private IMessageBasedFormattedIO ibfIo;   //使用lvi.Visa库中的类
        //private NationalInstruments.VisaNS.MessageBasedSession mbSession;  //使用NI.VisaNS中的类
        //private int connectingWay; //连接方式
        public delegate void connectDelegate(); //定义一个connectDelegate()的委托
        private connectDelegate connect; //再定义一个委托变量
        private delegate void AddMsg(string msg);
        private delegate void ChangeEventConnect();
        private delegate void ChangeEventDisconnect();

        /// <summary>
        /// 初始化组件
        /// </summary>
        public SCPI_Expert()
        {
            InitializeComponent();
            this.connect = this.connectInstru;
        }

        /// <summary>
        /// 窗口加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SCPI_Expert_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            btnRead.Enabled = false;
            btnSR.Enabled = false;
        }

        /// <summary>
        /// 点击连接按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Thread connectThread = new Thread(new ThreadStart(this.connect));
            connectThread.Name = (++id).ToString();
            connectThread.IsBackground = true;
            connectThread.Start();
        }
        int id = 0;

        /// <summary>
        /// 连接设备方法
        /// </summary>
        private void connectInstru()
        {
            try
            {
                if (btnConnect.Text == "Connect")
                {
                    string msg = "*[" + DateTime.Now.ToString() + "] " + "Start connecting...";
                    ShowMsg(msg);
                    ShowFrmWaiting();
                    connectDevice(txbAddress.Text);
                    doConn();
                }
                else if (btnConnect.Text == "Disconnect")
                {
                    string msg = "*[" + DateTime.Now.ToString() + "] " + "Start disconnecting...";
                    ShowMsg(msg);
                    ShowFrmWaiting();
                    Disconnect();
                    CloseConn();
                }
                else { }
                HideFrmWaiting();
            }
            catch (Exception)
            {
                string msg = "*[" + DateTime.Now.ToString() + "] " + "Disconnect!:lvi.Visa.";
                ShowMsg(msg);
                HideFrmWaiting();
            }
        }

        /// <summary>
        /// 执行连接仪器
        /// </summary>
        private void doConn()
        {
            if (this.InvokeRequired)
                this.BeginInvoke(new ChangeEventConnect(this.doConn_Bkgrd), new object[] { });
            else
                doConn_Bkgrd();
        }

        /// <summary>
        /// 这里是后台线程，是在另一个线程上完成的
        /// 这里是真正做事的工作线程
        /// 可以在这里做一些费时的，复杂的操作
        /// </summary>
        private void doConn_Bkgrd()
        {
            btnSend.Enabled = true;
            btnRead.Enabled = true;
            btnSR.Enabled = true;
            btnConnect.Text = "Disconnect";
            lblStatus.Text = "Connected to " + txbAddress.Text + "!";
        }

        /// <summary>
        /// 执行断开仪器
        /// </summary>
        private void CloseConn()
        {
            if (this.InvokeRequired)
                this.BeginInvoke(new ChangeEventConnect(this.bw_CloseConn), new object[] { });
            else
                bw_CloseConn();
        }

        /// <summary>
        /// 这里是后台线程，是在另一个线程上完成的
        /// 这里是真正做事的工作线程
        /// 可以在这里做一些费时的，复杂的操作
        /// </summary>
        private void bw_CloseConn()
        {
            btnConnect.Text = "Connect";
            lblStatus.Text = "Disconnected";
            btnConnect.Enabled = true;
        }

        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="msg">消息</param>
        private void ShowMsg(string msg)
        {
            if (this.InvokeRequired)
                this.BeginInvoke(new AddMsg(this.AddMsgFun), new object[] { msg });
            else
                AddMsgFun(msg);
        }

        /// <summary>
        /// 添加消息到ListBox中
        /// </summary>
        /// <param name="msg">消息</param>
        private void AddMsgFun(string msg)
        {
            this.lbxReception.Items.Add(msg);
            this.lbxReception.SelectedIndex = 0;
            this.lbxReception.Text = msg;
        }

        /// <summary>
        /// 清空日志框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxReception.Items.Clear();
            lbxReception.Refresh();
        }

        /// <summary>
        /// 点击发送按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            Send(cmbSend.Text);
        }

        /// <summary>
        /// 点击接收按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            Query(cmbSend.Text);
        }

        /// <summary>
        /// 点击发送并接收按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSR_Click(object sender, EventArgs e)
        {
            Send(cmbSend.Text);
            Query(cmbSend.Text);
        }

        /// <summary>
        /// 获取频谱仪Trace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadTrace_Click(object sender, EventArgs e)
        {
            try
            {
                double[] trace = new double[1000];
                ibfIo.PrintfAndFlush("TRAC:DATA? TRACE1");
                trace = ibfIo.ReadListOfDouble(1000);
                Console.WriteLine(trace);
            }
            catch (Exception)
            {
                lbxReception.Items.Add("*[" + DateTime.Now.ToString() + "] " + "Can't read trace!:lvi.Visa.");
            }
        }

        /// <summary>
        /// 指令发送框下拉菜单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSend_DropDown(object sender, EventArgs e)
        {
            try
            {
                cmbSend.Items.Clear();
                FileInfo fi = new FileInfo(Directory.GetCurrentDirectory() + @"\SCPI_Example.txt");
                StreamReader sr = fi.OpenText();
                string strLine = string.Empty;
                while ((strLine = sr.ReadLine()) != null)
                {
                    cmbSend.Items.Add(strLine);
                }
                sr.Dispose();
            }
            catch (Exception)
            {
                lbxReception.Items.Add("*[" + DateTime.Now.ToString() + "] " + "Can't open command list!:lvi.Visa.");
            }

        }

        /// <summary>
        /// 使用lvi.Visa库中的类打开与设备的会话(方式1)
        /// </summary>
        /// <param name="resourceName">资源名称，例如"TCPIP0::192.168.0.10::inst0::INSTR"</param>
        private void connectDevice(string resourceName)
        {
            try
            {
                ITcpipSession session = (ITcpipSession)GlobalResourceManager.Open(resourceName);
                ibfIo = session.FormattedIO;
                ShowMsg("*[" + DateTime.Now.ToString() + "] " + "Connect to the device successfully!:lvi.Visa.");
            }
            catch
            {
                lbxReception.Items.Add("*[" + DateTime.Now.ToString() + "] " + "Can't connect to the device!:lvi.Visa.");
            }
        }

        /// <summary>
        /// 发送SCPI指令
        /// </summary>
        /// <param name="command">SCPI指令</param>
        private void Send(string command)
        {
            if (ibfIo != null)
            {
                try
                {
                    ibfIo.PrintfAndFlush(command);
                    lbxReception.Items.Add("*[" + DateTime.Now.ToString() + "] " + "Send: " + command);
                }
                catch (Exception)
                {
                    lbxReception.Items.Add("*[" + DateTime.Now.ToString() + "] " + "Error: Can't send command");
                }
            }
            else
            {
                lbxReception.Items.Add("*[" + DateTime.Now.ToString() + "] " + "Error: Disconnect");
            }
        }

        /// <summary>
        /// 查询回读信息
        /// </summary>
        /// <param name="command">SCPI指令</param>
        private void Query(string command)
        {
            if (ibfIo != null)
            {
                try
                {
                    lbxReception.Items.Add("*[" + DateTime.Now.ToString() + "] " + "Read: " + ibfIo.ReadLine());
                }
                catch (Exception)
                {
                    lbxReception.Items.Add("*[" + DateTime.Now.ToString() + "] " + "Error: No return infomation");
                }
            }
            else
            {
                lbxReception.Items.Add("*[" + DateTime.Now.ToString() + "] " + "Error: Disconnect");
            }
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        private void Disconnect()
        {
            if (ibfIo != null)
                ibfIo = null;
        }

        /// <summary>
        /// 显示等待窗体
        /// </summary>
        public void ShowFrmWaiting()
        {
            bool flag = !this.ssMgr.IsSplashFormVisible;
            if (flag)
                this.ssMgr.ShowWaitForm();
        }

        /// <summary>
        /// 关闭等待窗体
        /// </summary>
        public void HideFrmWaiting()
        {
            bool isSplashFormVisible = this.ssMgr.IsSplashFormVisible;
            if (isSplashFormVisible)
                this.ssMgr.CloseWaitForm();
        }

    }
}