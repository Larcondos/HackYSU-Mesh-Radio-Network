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
            this.components = new System.ComponentModel.Container();
            this.MessagesListBox = new System.Windows.Forms.ListBox();
            this.AvaialbleRadiosCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ConfirmationTextbox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TypeMessageTextbox = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.AvaialbleRadiosCheckedListBox.Location = new System.Drawing.Point(13, 12);
            this.AvaialbleRadiosCheckedListBox.Name = "AvaialbleRadiosCheckedListBox";
            this.AvaialbleRadiosCheckedListBox.Size = new System.Drawing.Size(251, 319);
            this.AvaialbleRadiosCheckedListBox.TabIndex = 1;
            // 
            // ConfirmationTextbox
            // 
            this.ConfirmationTextbox.Location = new System.Drawing.Point(13, 337);
            this.ConfirmationTextbox.Multiline = true;
            this.ConfirmationTextbox.Name = "ConfirmationTextbox";
            this.ConfirmationTextbox.Size = new System.Drawing.Size(251, 44);
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
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(270, 461);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(318, 50);
            this.SendMessageButton.TabIndex = 5;
            this.SendMessageButton.Text = "Click here to send your message!";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Connect to Network";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Disconnect from Network";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Network Test";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 552);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SendMessageButton);
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
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

