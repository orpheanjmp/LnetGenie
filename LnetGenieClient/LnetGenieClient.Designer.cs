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
            this.test = new System.Windows.Forms.Button();
            this.outputFld = new System.Windows.Forms.RichTextBox();
            this.inputFld = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(13, 12);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(105, 27);
            this.test.TabIndex = 0;
            this.test.Text = "Connect";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.testBtn_click);
            // 
            // outputFld
            // 
            this.outputFld.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFld.Location = new System.Drawing.Point(13, 46);
            this.outputFld.Name = "outputFld";
            this.outputFld.Size = new System.Drawing.Size(582, 243);
            this.outputFld.TabIndex = 1;
            this.outputFld.Text = "";
            // 
            // inputFld
            // 
            this.inputFld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFld.Location = new System.Drawing.Point(12, 310);
            this.inputFld.Name = "inputFld";
            this.inputFld.Size = new System.Drawing.Size(502, 20);
            this.inputFld.TabIndex = 2;
            // 
            // sendbtn
            // 
            this.sendbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendbtn.Location = new System.Drawing.Point(520, 303);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 34);
            this.sendbtn.TabIndex = 3;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            // 
            // LnetGenieClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 349);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.inputFld);
            this.Controls.Add(this.outputFld);
            this.Controls.Add(this.test);
            this.Name = "LnetGenieClient";
            this.Text = "LNet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button test;
        private System.Windows.Forms.RichTextBox outputFld;
        private System.Windows.Forms.TextBox inputFld;
        private System.Windows.Forms.Button sendbtn;
    }
}

