namespace Download_instagram
{
    partial class Form_Download
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
            this.btn_download = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.label_link = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(316, 186);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(126, 43);
            this.btn_download.TabIndex = 0;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(227, 43);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(308, 18);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "PHẦN MỀM DOWNLOAD ẢNH INSTAGRAM";
            // 
            // txt_link
            // 
            this.txt_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_link.Location = new System.Drawing.Point(85, 109);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(609, 24);
            this.txt_link.TabIndex = 2;
            // 
            // label_link
            // 
            this.label_link.AutoSize = true;
            this.label_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_link.Location = new System.Drawing.Point(44, 112);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(35, 18);
            this.label_link.TabIndex = 3;
            this.label_link.Text = "Link";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.label_link);
            this.Controls.Add(this.txt_link);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.btn_download);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Video Tiktok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Label label_link;
    }
}

