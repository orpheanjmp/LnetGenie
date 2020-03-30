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
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(259, 76);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(200, 74);
            this.test.TabIndex = 0;
            this.test.Text = "Do The Things";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.testBtn_click);
            // 
            // LnetGenieClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 371);
            this.Controls.Add(this.test);
            this.Name = "LnetGenieClient";
            this.Text = "LNet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button test;
    }
}

