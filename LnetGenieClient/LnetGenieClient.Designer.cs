namespace LnetGenieClient
{
    partial class LnetGenieClient
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
            this.connectBtn = new System.Windows.Forms.Button();
            this.outputFld = new System.Windows.Forms.RichTextBox();
            this.inputFld = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.privateCheck = new System.Windows.Forms.CheckBox();
            this.privateFld = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fldChannel = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.fldName = new System.Windows.Forms.TextBox();
            this.fldPassword = new System.Windows.Forms.TextBox();
            this.fldGame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(13, 12);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(105, 27);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // outputFld
            // 
            this.outputFld.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFld.Location = new System.Drawing.Point(13, 46);
            this.outputFld.Name = "outputFld";
            this.outputFld.Size = new System.Drawing.Size(642, 347);
            this.outputFld.TabIndex = 1;
            this.outputFld.Text = "";
            // 
            // inputFld
            // 
            this.inputFld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFld.Location = new System.Drawing.Point(13, 424);
            this.inputFld.Name = "inputFld";
            this.inputFld.Size = new System.Drawing.Size(562, 20);
            this.inputFld.TabIndex = 2;
            // 
            // sendbtn
            // 
            this.sendbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendbtn.Location = new System.Drawing.Point(581, 422);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 24);
            this.sendbtn.TabIndex = 3;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // privateCheck
            // 
            this.privateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.privateCheck.AutoSize = true;
            this.privateCheck.Location = new System.Drawing.Point(13, 401);
            this.privateCheck.Name = "privateCheck";
            this.privateCheck.Size = new System.Drawing.Size(65, 17);
            this.privateCheck.TabIndex = 4;
            this.privateCheck.Text = "Private?";
            this.privateCheck.UseVisualStyleBackColor = true;
            this.privateCheck.CheckedChanged += new System.EventHandler(this.privateCheck_CheckedChanged);
            // 
            // privateFld
            // 
            this.privateFld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.privateFld.Location = new System.Drawing.Point(84, 399);
            this.privateFld.Name = "privateFld";
            this.privateFld.Size = new System.Drawing.Size(95, 20);
            this.privateFld.TabIndex = 5;
            this.privateFld.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Channel:";
            // 
            // fldChannel
            // 
            this.fldChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fldChannel.Location = new System.Drawing.Point(255, 399);
            this.fldChannel.Name = "fldChannel";
            this.fldChannel.Size = new System.Drawing.Size(119, 20);
            this.fldChannel.TabIndex = 7;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(124, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(105, 27);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // fldName
            // 
            this.fldName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fldName.Location = new System.Drawing.Point(449, 20);
            this.fldName.Name = "fldName";
            this.fldName.Size = new System.Drawing.Size(100, 20);
            this.fldName.TabIndex = 9;
            // 
            // fldPassword
            // 
            this.fldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fldPassword.Location = new System.Drawing.Point(555, 20);
            this.fldPassword.Name = "fldPassword";
            this.fldPassword.Size = new System.Drawing.Size(100, 20);
            this.fldPassword.TabIndex = 10;
            // 
            // fldGame
            // 
            this.fldGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fldGame.Location = new System.Drawing.Point(343, 20);
            this.fldGame.Name = "fldGame";
            this.fldGame.Size = new System.Drawing.Size(100, 20);
            this.fldGame.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Game:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(552, 4);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password:";
            // 
            // LnetGenieClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 454);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fldGame);
            this.Controls.Add(this.fldPassword);
            this.Controls.Add(this.fldName);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.fldChannel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privateFld);
            this.Controls.Add(this.privateCheck);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.inputFld);
            this.Controls.Add(this.outputFld);
            this.Controls.Add(this.connectBtn);
            this.Name = "LnetGenieClient";
            this.Text = "LNet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.RichTextBox outputFld;
        private System.Windows.Forms.TextBox inputFld;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.CheckBox privateCheck;
        private System.Windows.Forms.TextBox privateFld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fldChannel;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox fldName;
        private System.Windows.Forms.TextBox fldPassword;
        private System.Windows.Forms.TextBox fldGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPassword;
    }
}

