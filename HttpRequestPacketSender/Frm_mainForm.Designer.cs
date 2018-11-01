namespace HttpRequestPacketSender
{
    partial class Frm_mainForm
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
            this.Btn_send = new System.Windows.Forms.Button();
            this.Rtb_output = new System.Windows.Forms.RichTextBox();
            this.Chk_SaveToFile = new System.Windows.Forms.CheckBox();
            this.Txt_URI = new System.Windows.Forms.TextBox();
            this.Lbl_URI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_send
            // 
            this.Btn_send.Location = new System.Drawing.Point(647, 415);
            this.Btn_send.Name = "Btn_send";
            this.Btn_send.Size = new System.Drawing.Size(141, 23);
            this.Btn_send.TabIndex = 0;
            this.Btn_send.Text = "Send Request";
            this.Btn_send.UseVisualStyleBackColor = true;
            this.Btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // Rtb_output
            // 
            this.Rtb_output.Location = new System.Drawing.Point(12, 63);
            this.Rtb_output.Name = "Rtb_output";
            this.Rtb_output.Size = new System.Drawing.Size(776, 321);
            this.Rtb_output.TabIndex = 2;
            this.Rtb_output.Text = "";
            // 
            // Chk_SaveToFile
            // 
            this.Chk_SaveToFile.AutoSize = true;
            this.Chk_SaveToFile.Location = new System.Drawing.Point(546, 419);
            this.Chk_SaveToFile.Name = "Chk_SaveToFile";
            this.Chk_SaveToFile.Size = new System.Drawing.Size(82, 17);
            this.Chk_SaveToFile.TabIndex = 3;
            this.Chk_SaveToFile.Text = "Save to File";
            this.Chk_SaveToFile.UseVisualStyleBackColor = true;
            // 
            // Txt_URI
            // 
            this.Txt_URI.Location = new System.Drawing.Point(53, 28);
            this.Txt_URI.Name = "Txt_URI";
            this.Txt_URI.Size = new System.Drawing.Size(735, 20);
            this.Txt_URI.TabIndex = 4;
            // 
            // Lbl_URI
            // 
            this.Lbl_URI.AutoSize = true;
            this.Lbl_URI.Location = new System.Drawing.Point(12, 31);
            this.Lbl_URI.Name = "Lbl_URI";
            this.Lbl_URI.Size = new System.Drawing.Size(35, 13);
            this.Lbl_URI.TabIndex = 5;
            this.Lbl_URI.Text = "URI : ";
            // 
            // Frm_mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_URI);
            this.Controls.Add(this.Txt_URI);
            this.Controls.Add(this.Chk_SaveToFile);
            this.Controls.Add(this.Rtb_output);
            this.Controls.Add(this.Btn_send);
            this.Name = "Frm_mainForm";
            this.ShowIcon = false;
            this.Text = "Http Request Packet Sender";
            this.Load += new System.EventHandler(this.Frm_mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_send;
        private System.Windows.Forms.RichTextBox Rtb_output;
        private System.Windows.Forms.CheckBox Chk_SaveToFile;
        private System.Windows.Forms.TextBox Txt_URI;
        private System.Windows.Forms.Label Lbl_URI;
    }
}

