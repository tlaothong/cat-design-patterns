namespace WcfServiceClient
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
            this.CallAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CallAddButton
            // 
            this.CallAddButton.AutoSize = true;
            this.CallAddButton.Location = new System.Drawing.Point(158, 135);
            this.CallAddButton.Name = "CallAddButton";
            this.CallAddButton.Size = new System.Drawing.Size(78, 30);
            this.CallAddButton.TabIndex = 0;
            this.CallAddButton.Text = "Call Add";
            this.CallAddButton.UseVisualStyleBackColor = true;
            this.CallAddButton.Click += new System.EventHandler(this.CallAddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 336);
            this.Controls.Add(this.CallAddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CallAddButton;
    }
}

