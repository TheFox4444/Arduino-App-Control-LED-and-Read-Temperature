namespace ArduinoAppControlLEDReadTem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bConnect = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bLED13_ON = new System.Windows.Forms.Button();
            this.bLED13_OFF = new System.Windows.Forms.Button();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.Note = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cRate = new System.Windows.Forms.ComboBox();
            this.cPort = new System.Windows.Forms.ComboBox();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bTS = new System.Windows.Forms.Button();
            this.TemShow = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.bOG = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bConnect
            // 
            this.bConnect.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.bConnect.Location = new System.Drawing.Point(5, 317);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(99, 37);
            this.bConnect.TabIndex = 0;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bStop
            // 
            this.bStop.Cursor = System.Windows.Forms.Cursors.No;
            this.bStop.Location = new System.Drawing.Point(649, 317);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(100, 37);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(204, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test Sensor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bLED13_ON
            // 
            this.bLED13_ON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLED13_ON.Location = new System.Drawing.Point(7, 118);
            this.bLED13_ON.Name = "bLED13_ON";
            this.bLED13_ON.Size = new System.Drawing.Size(143, 65);
            this.bLED13_ON.TabIndex = 3;
            this.bLED13_ON.Text = "LED13 ON";
            this.bLED13_ON.UseVisualStyleBackColor = true;
            this.bLED13_ON.Click += new System.EventHandler(this.bLED13_ON_Click);
            // 
            // bLED13_OFF
            // 
            this.bLED13_OFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLED13_OFF.Location = new System.Drawing.Point(178, 118);
            this.bLED13_OFF.Name = "bLED13_OFF";
            this.bLED13_OFF.Size = new System.Drawing.Size(143, 65);
            this.bLED13_OFF.TabIndex = 4;
            this.bLED13_OFF.Text = "LED13 OFF";
            this.bLED13_OFF.UseVisualStyleBackColor = true;
            this.bLED13_OFF.Click += new System.EventHandler(this.bLED13_OFF_Click);
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived);
            // 
            // Note
            // 
            this.Note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Note.BackColor = System.Drawing.Color.Transparent;
            this.Note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Note.ForeColor = System.Drawing.Color.Yellow;
            this.Note.Location = new System.Drawing.Point(200, 397);
            this.Note.Name = "Note";
            this.Note.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Note.Size = new System.Drawing.Size(313, 23);
            this.Note.TabIndex = 5;
            this.Note.Text = "Note:";
            this.Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cRate);
            this.groupBox1.Controls.Add(this.cPort);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(401, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 176);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baud rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "COM Port:";
            // 
            // cRate
            // 
            this.cRate.FormattingEnabled = true;
            this.cRate.Location = new System.Drawing.Point(127, 103);
            this.cRate.Name = "cRate";
            this.cRate.Size = new System.Drawing.Size(197, 24);
            this.cRate.TabIndex = 1;
            // 
            // cPort
            // 
            this.cPort.FormattingEnabled = true;
            this.cPort.Location = new System.Drawing.Point(127, 41);
            this.cPort.Name = "cPort";
            this.cPort.Size = new System.Drawing.Size(197, 24);
            this.cPort.TabIndex = 0;
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(312, 317);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(89, 37);
            this.bRefresh.TabIndex = 7;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click_1);
            // 
            // bTS
            // 
            this.bTS.Location = new System.Drawing.Point(7, 221);
            this.bTS.Name = "bTS";
            this.bTS.Size = new System.Drawing.Size(143, 57);
            this.bTS.TabIndex = 8;
            this.bTS.Text = "Temperature Sensor";
            this.bTS.UseVisualStyleBackColor = true;
            this.bTS.Click += new System.EventHandler(this.bTS_Click);
            // 
            // TemShow
            // 
            this.TemShow.AutoSize = true;
            this.TemShow.BackColor = System.Drawing.Color.Transparent;
            this.TemShow.ForeColor = System.Drawing.Color.Yellow;
            this.TemShow.Location = new System.Drawing.Point(535, 24);
            this.TemShow.Name = "TemShow";
            this.TemShow.Size = new System.Drawing.Size(88, 16);
            this.TemShow.TabIndex = 9;
            this.TemShow.Text = "Temperature:";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.Location = new System.Drawing.Point(756, 0);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(597, 447);
            this.zedGraphControl1.TabIndex = 10;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // bOG
            // 
            this.bOG.Location = new System.Drawing.Point(178, 221);
            this.bOG.Name = "bOG";
            this.bOG.Size = new System.Drawing.Size(143, 57);
            this.bOG.TabIndex = 11;
            this.bOG.Text = "Only Graph";
            this.bOG.UseVisualStyleBackColor = true;
            this.bOG.Click += new System.EventHandler(this.bOG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1353, 447);
            this.Controls.Add(this.bOG);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.TemShow);
            this.Controls.Add(this.bTS);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.bLED13_OFF);
            this.Controls.Add(this.bLED13_ON);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nuclear";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLED13_ON;
        private System.Windows.Forms.Button bLED13_OFF;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cPort;
        private System.Windows.Forms.ComboBox cRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Button bTS;
        private System.Windows.Forms.Label TemShow;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button bOG;
    }
}

