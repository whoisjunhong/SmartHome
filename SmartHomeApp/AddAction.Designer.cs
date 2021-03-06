﻿namespace SmartHomeApp
{
    partial class AddAction
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
            this.lblSelectDevice = new System.Windows.Forms.Label();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.lblSelectModule = new System.Windows.Forms.Label();
            this.cbModule = new System.Windows.Forms.ComboBox();
            this.btnRefreshD = new System.Windows.Forms.Button();
            this.btnRefreshM = new System.Windows.Forms.Button();
            this.lblSelectAction = new System.Windows.Forms.Label();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSelectDevice
            // 
            this.lblSelectDevice.AutoSize = true;
            this.lblSelectDevice.Location = new System.Drawing.Point(89, 45);
            this.lblSelectDevice.Name = "lblSelectDevice";
            this.lblSelectDevice.Size = new System.Drawing.Size(106, 17);
            this.lblSelectDevice.TabIndex = 0;
            this.lblSelectDevice.Text = "Select Device : ";
            // 
            // cbDevice
            // 
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(201, 42);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(121, 24);
            this.cbDevice.TabIndex = 1;
            // 
            // lblSelectModule
            // 
            this.lblSelectModule.AutoSize = true;
            this.lblSelectModule.Location = new System.Drawing.Point(89, 81);
            this.lblSelectModule.Name = "lblSelectModule";
            this.lblSelectModule.Size = new System.Drawing.Size(109, 17);
            this.lblSelectModule.TabIndex = 2;
            this.lblSelectModule.Text = "Select Module : ";
            // 
            // cbModule
            // 
            this.cbModule.FormattingEnabled = true;
            this.cbModule.Location = new System.Drawing.Point(201, 78);
            this.cbModule.Name = "cbModule";
            this.cbModule.Size = new System.Drawing.Size(121, 24);
            this.cbModule.TabIndex = 3;
            // 
            // btnRefreshD
            // 
            this.btnRefreshD.Location = new System.Drawing.Point(342, 40);
            this.btnRefreshD.Name = "btnRefreshD";
            this.btnRefreshD.Size = new System.Drawing.Size(133, 27);
            this.btnRefreshD.TabIndex = 4;
            this.btnRefreshD.Text = "Refresh Devices";
            this.btnRefreshD.UseVisualStyleBackColor = true;
            this.btnRefreshD.Click += new System.EventHandler(this.btnRefreshD_Click);
            // 
            // btnRefreshM
            // 
            this.btnRefreshM.Location = new System.Drawing.Point(342, 78);
            this.btnRefreshM.Name = "btnRefreshM";
            this.btnRefreshM.Size = new System.Drawing.Size(133, 27);
            this.btnRefreshM.TabIndex = 5;
            this.btnRefreshM.Text = "Refresh modules";
            this.btnRefreshM.UseVisualStyleBackColor = true;
            this.btnRefreshM.Click += new System.EventHandler(this.btnRefreshM_Click);
            // 
            // lblSelectAction
            // 
            this.lblSelectAction.AutoSize = true;
            this.lblSelectAction.Location = new System.Drawing.Point(89, 116);
            this.lblSelectAction.Name = "lblSelectAction";
            this.lblSelectAction.Size = new System.Drawing.Size(98, 17);
            this.lblSelectAction.TabIndex = 6;
            this.lblSelectAction.Text = "Select Action :";
            // 
            // cbAction
            // 
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "open",
            "exit",
            "play",
            "stop"});
            this.cbAction.Location = new System.Drawing.Point(201, 113);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(121, 24);
            this.cbAction.TabIndex = 7;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(201, 259);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(121, 33);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(89, 154);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(74, 17);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Duration : ";
            this.lbl.Visible = false;
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(201, 154);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(121, 22);
            this.tbDuration.TabIndex = 10;
            this.tbDuration.Visible = false;
            // 
            // AddAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 321);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.lblSelectAction);
            this.Controls.Add(this.btnRefreshM);
            this.Controls.Add(this.btnRefreshD);
            this.Controls.Add(this.cbModule);
            this.Controls.Add(this.lblSelectModule);
            this.Controls.Add(this.cbDevice);
            this.Controls.Add(this.lblSelectDevice);
            this.Name = "AddAction";
            this.Text = "AddAction";
            this.Load += new System.EventHandler(this.AddAction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDevice;
        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.Label lblSelectModule;
        private System.Windows.Forms.ComboBox cbModule;
        private System.Windows.Forms.Button btnRefreshD;
        private System.Windows.Forms.Button btnRefreshM;
        private System.Windows.Forms.Label lblSelectAction;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tbDuration;
    }
}