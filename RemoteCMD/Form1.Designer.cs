﻿namespace RemoteCMD {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxTargetHost = new System.Windows.Forms.TextBox();
            this.textBoxIPMR = new System.Windows.Forms.TextBox();
            this.textBoxIPML = new System.Windows.Forms.TextBox();
            this.textBoxIPL = new System.Windows.Forms.TextBox();
            this.textBoxIPR = new System.Windows.Forms.TextBox();
            this.buttonMake = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTargetHost
            // 
            this.textBoxTargetHost.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTargetHost.Location = new System.Drawing.Point(12, 129);
            this.textBoxTargetHost.Name = "textBoxTargetHost";
            this.textBoxTargetHost.Size = new System.Drawing.Size(242, 23);
            this.textBoxTargetHost.TabIndex = 6;
            this.textBoxTargetHost.TextChanged += new System.EventHandler(this.HostNameChanged);
            this.textBoxTargetHost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEnterKey);
            // 
            // textBoxIPMR
            // 
            this.textBoxIPMR.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxIPMR.Location = new System.Drawing.Point(198, 85);
            this.textBoxIPMR.Name = "textBoxIPMR";
            this.textBoxIPMR.Size = new System.Drawing.Size(56, 23);
            this.textBoxIPMR.TabIndex = 5;
            this.textBoxIPMR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIPMR.TextChanged += new System.EventHandler(this.ChangedIP);
            this.textBoxIPMR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEnterKey);
            // 
            // textBoxIPML
            // 
            this.textBoxIPML.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxIPML.Location = new System.Drawing.Point(12, 85);
            this.textBoxIPML.Name = "textBoxIPML";
            this.textBoxIPML.Size = new System.Drawing.Size(56, 23);
            this.textBoxIPML.TabIndex = 2;
            this.textBoxIPML.Text = "192";
            this.textBoxIPML.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIPML.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEnterKey);
            // 
            // textBoxIPL
            // 
            this.textBoxIPL.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxIPL.Location = new System.Drawing.Point(74, 85);
            this.textBoxIPL.Name = "textBoxIPL";
            this.textBoxIPL.Size = new System.Drawing.Size(56, 23);
            this.textBoxIPL.TabIndex = 3;
            this.textBoxIPL.Text = "168";
            this.textBoxIPL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIPL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEnterKey);
            // 
            // textBoxIPR
            // 
            this.textBoxIPR.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxIPR.Location = new System.Drawing.Point(136, 85);
            this.textBoxIPR.Name = "textBoxIPR";
            this.textBoxIPR.Size = new System.Drawing.Size(56, 23);
            this.textBoxIPR.TabIndex = 4;
            this.textBoxIPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIPR.TextChanged += new System.EventHandler(this.ChangedIP);
            this.textBoxIPR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEnterKey);
            // 
            // buttonMake
            // 
            this.buttonMake.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonMake.Location = new System.Drawing.Point(12, 12);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(242, 67);
            this.buttonMake.TabIndex = 1;
            this.buttonMake.Text = "MAKE";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxUserName.Location = new System.Drawing.Point(12, 173);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(242, 23);
            this.textBoxUserName.TabIndex = 7;
            this.textBoxUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEnterKey);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPassword.Location = new System.Drawing.Point(12, 217);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(242, 23);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEnterKey);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "HostName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 255);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonMake);
            this.Controls.Add(this.textBoxIPR);
            this.Controls.Add(this.textBoxIPL);
            this.Controls.Add(this.textBoxIPML);
            this.Controls.Add(this.textBoxIPMR);
            this.Controls.Add(this.textBoxTargetHost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoteCMD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTargetHost;
        private System.Windows.Forms.TextBox textBoxIPMR;
        private System.Windows.Forms.TextBox textBoxIPML;
        private System.Windows.Forms.TextBox textBoxIPL;
        private System.Windows.Forms.TextBox textBoxIPR;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

