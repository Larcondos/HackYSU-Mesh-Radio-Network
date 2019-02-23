namespace RadioMeshNetwork
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
            this.MessagesListBox = new System.Windows.Forms.ListBox();
            this.AvaialbleRadiosCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ConfirmationTextbox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TypeMessageTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessagesListBox
            // 
            this.MessagesListBox.FormattingEnabled = true;
            this.MessagesListBox.Location = new System.Drawing.Point(270, 12);
            this.MessagesListBox.Name = "MessagesListBox";
            this.MessagesListBox.Size = new System.Drawing.Size(318, 368);
            this.MessagesListBox.TabIndex = 0;
            // 
            // AvaialbleRadiosCheckedListBox
            // 
            this.AvaialbleRadiosCheckedListBox.FormattingEnabled = true;
            this.AvaialbleRadiosCheckedListBox.Location = new System.Drawing.Point(13, 13);
            this.AvaialbleRadiosCheckedListBox.Name = "AvaialbleRadiosCheckedListBox";
            this.AvaialbleRadiosCheckedListBox.Size = new System.Drawing.Size(251, 319);
            this.AvaialbleRadiosCheckedListBox.TabIndex = 1;
            // 
            // ConfirmationTextbox
            // 
            this.ConfirmationTextbox.Location = new System.Drawing.Point(13, 339);
            this.ConfirmationTextbox.Multiline = true;
            this.ConfirmationTextbox.Name = "ConfirmationTextbox";
            this.ConfirmationTextbox.Size = new System.Drawing.Size(251, 41);
            this.ConfirmationTextbox.TabIndex = 2;
            this.ConfirmationTextbox.Text = "Verifies if a message was sent...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 517);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(575, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // TypeMessageTextbox
            // 
            this.TypeMessageTextbox.Location = new System.Drawing.Point(270, 387);
            this.TypeMessageTextbox.Multiline = true;
            this.TypeMessageTextbox.Name = "TypeMessageTextbox";
            this.TypeMessageTextbox.Size = new System.Drawing.Size(318, 67);
            this.TypeMessageTextbox.TabIndex = 4;
            this.TypeMessageTextbox.Text = "Type your message here...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 552);
            this.Controls.Add(this.TypeMessageTextbox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ConfirmationTextbox);
            this.Controls.Add(this.AvaialbleRadiosCheckedListBox);
            this.Controls.Add(this.MessagesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MessagesListBox;
        private System.Windows.Forms.CheckedListBox AvaialbleRadiosCheckedListBox;
        private System.Windows.Forms.TextBox ConfirmationTextbox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox TypeMessageTextbox;
    }
}

