namespace SCPI_Expert
{
    partial class SCPI_Expert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SCPI_Expert));
            this.tlpMainForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblVISAadd = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.cmbSend = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSR = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.lbxReception = new DevExpress.XtraEditors.ListBoxControl();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReadTrace = new System.Windows.Forms.Button();
            this.ssMgr = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SCPI_Expert.wfConnecting), true, true, true);
            this.tlpMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbxReception)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMainForm
            // 
            this.tlpMainForm.ColumnCount = 5;
            this.tlpMainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainForm.Controls.Add(this.lblVISAadd, 0, 0);
            this.tlpMainForm.Controls.Add(this.lblCommand, 0, 1);
            this.tlpMainForm.Controls.Add(this.txbAddress, 1, 0);
            this.tlpMainForm.Controls.Add(this.cmbSend, 1, 1);
            this.tlpMainForm.Controls.Add(this.btnConnect, 4, 0);
            this.tlpMainForm.Controls.Add(this.btnSend, 1, 2);
            this.tlpMainForm.Controls.Add(this.btnRead, 2, 2);
            this.tlpMainForm.Controls.Add(this.btnSR, 3, 2);
            this.tlpMainForm.Controls.Add(this.btnClear, 4, 2);
            this.tlpMainForm.Controls.Add(this.lblLog, 0, 2);
            this.tlpMainForm.Controls.Add(this.lbxReception, 0, 3);
            this.tlpMainForm.Controls.Add(this.lblStatus, 0, 4);
            this.tlpMainForm.Controls.Add(this.btnReadTrace, 4, 1);
            this.tlpMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainForm.Location = new System.Drawing.Point(0, 0);
            this.tlpMainForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpMainForm.Name = "tlpMainForm";
            this.tlpMainForm.RowCount = 5;
            this.tlpMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpMainForm.Size = new System.Drawing.Size(807, 450);
            this.tlpMainForm.TabIndex = 0;
            // 
            // lblVISAadd
            // 
            this.lblVISAadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVISAadd.AutoSize = true;
            this.lblVISAadd.Location = new System.Drawing.Point(41, 6);
            this.lblVISAadd.Name = "lblVISAadd";
            this.lblVISAadd.Size = new System.Drawing.Size(79, 14);
            this.lblVISAadd.TabIndex = 0;
            this.lblVISAadd.Text = "VISA address";
            // 
            // lblCommand
            // 
            this.lblCommand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(50, 33);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(61, 14);
            this.lblCommand.TabIndex = 0;
            this.lblCommand.Text = "Command";
            // 
            // txbAddress
            // 
            this.tlpMainForm.SetColumnSpan(this.txbAddress, 3);
            this.txbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbAddress.Location = new System.Drawing.Point(161, 0);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(483, 22);
            this.txbAddress.TabIndex = 1;
            this.txbAddress.Text = "TCPIP0::192.168.1.211::inst0::INSTR";
            // 
            // cmbSend
            // 
            this.tlpMainForm.SetColumnSpan(this.cmbSend, 3);
            this.cmbSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSend.FormattingEnabled = true;
            this.cmbSend.Location = new System.Drawing.Point(161, 27);
            this.cmbSend.Margin = new System.Windows.Forms.Padding(0);
            this.cmbSend.Name = "cmbSend";
            this.cmbSend.Size = new System.Drawing.Size(483, 22);
            this.cmbSend.TabIndex = 2;
            this.cmbSend.Text = "*IDN?";
            this.cmbSend.DropDown += new System.EventHandler(this.cmbSend_DropDown);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(647, 2);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(157, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Location = new System.Drawing.Point(164, 56);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(155, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send Command";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnRead
            // 
            this.btnRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRead.Location = new System.Drawing.Point(325, 56);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(155, 23);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read Command";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSR
            // 
            this.btnSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSR.Location = new System.Drawing.Point(486, 56);
            this.btnSR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSR.Name = "btnSR";
            this.btnSR.Size = new System.Drawing.Size(155, 23);
            this.btnSR.TabIndex = 7;
            this.btnSR.Text = "Send && Read";
            this.btnSR.UseVisualStyleBackColor = true;
            this.btnSR.Click += new System.EventHandler(this.btnSR_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(647, 56);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Session";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblLog
            // 
            this.lblLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(4, 60);
            this.lblLog.Margin = new System.Windows.Forms.Padding(0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(153, 14);
            this.lblLog.TabIndex = 10;
            this.lblLog.Text = "Instrument Session History";
            // 
            // lbxReception
            // 
            this.tlpMainForm.SetColumnSpan(this.lbxReception, 5);
            this.lbxReception.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbxReception.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxReception.Location = new System.Drawing.Point(3, 83);
            this.lbxReception.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxReception.Name = "lbxReception";
            this.lbxReception.Size = new System.Drawing.Size(801, 342);
            this.lbxReception.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatus.AutoSize = true;
            this.tlpMainForm.SetColumnSpan(this.lblStatus, 5);
            this.lblStatus.Location = new System.Drawing.Point(3, 431);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 14);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Ready";
            // 
            // btnReadTrace
            // 
            this.btnReadTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReadTrace.Location = new System.Drawing.Point(647, 29);
            this.btnReadTrace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadTrace.Name = "btnReadTrace";
            this.btnReadTrace.Size = new System.Drawing.Size(157, 23);
            this.btnReadTrace.TabIndex = 13;
            this.btnReadTrace.Text = "ReadTrace";
            this.btnReadTrace.UseVisualStyleBackColor = true;
            this.btnReadTrace.Click += new System.EventHandler(this.btnReadTrace_Click);
            // 
            // ssMgr
            // 
            this.ssMgr.ClosingDelay = 500;
            // 
            // SCPI_Expert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.tlpMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "SCPI_Expert";
            this.Text = "SCPI_Expert";
            this.Load += new System.EventHandler(this.SCPI_Expert_Load);
            this.tlpMainForm.ResumeLayout(false);
            this.tlpMainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbxReception)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainForm;
        private System.Windows.Forms.Label lblVISAadd;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.ComboBox cmbSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSR;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblStatus;
        private DevExpress.XtraEditors.ListBoxControl lbxReception;
        private System.Windows.Forms.Button btnReadTrace;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssMgr;
    }
}