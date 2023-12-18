namespace Dosya_İslemleri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_OpenFile = new System.Windows.Forms.Button();
            this.Btn_SaveFile = new System.Windows.Forms.Button();
            this.Btn_FolderBrowser = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Btn_OpenFile
            // 
            this.Btn_OpenFile.Location = new System.Drawing.Point(95, 50);
            this.Btn_OpenFile.Name = "Btn_OpenFile";
            this.Btn_OpenFile.Size = new System.Drawing.Size(198, 43);
            this.Btn_OpenFile.TabIndex = 0;
            this.Btn_OpenFile.Text = "OpenFileDialog";
            this.Btn_OpenFile.UseVisualStyleBackColor = true;
            this.Btn_OpenFile.Click += new System.EventHandler(this.Btn_OpenFile_Click);
            // 
            // Btn_SaveFile
            // 
            this.Btn_SaveFile.Location = new System.Drawing.Point(95, 119);
            this.Btn_SaveFile.Name = "Btn_SaveFile";
            this.Btn_SaveFile.Size = new System.Drawing.Size(198, 43);
            this.Btn_SaveFile.TabIndex = 0;
            this.Btn_SaveFile.Text = "SaveFileDialog";
            this.Btn_SaveFile.UseVisualStyleBackColor = true;
            this.Btn_SaveFile.Click += new System.EventHandler(this.Btn_SaveFile_Click);
            // 
            // Btn_FolderBrowser
            // 
            this.Btn_FolderBrowser.Location = new System.Drawing.Point(95, 199);
            this.Btn_FolderBrowser.Name = "Btn_FolderBrowser";
            this.Btn_FolderBrowser.Size = new System.Drawing.Size(198, 43);
            this.Btn_FolderBrowser.TabIndex = 0;
            this.Btn_FolderBrowser.Text = "FolderFileDialog";
            this.Btn_FolderBrowser.UseVisualStyleBackColor = true;
            this.Btn_FolderBrowser.Click += new System.EventHandler(this.Btn_FolderBrowser_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 338);
            this.Controls.Add(this.Btn_FolderBrowser);
            this.Controls.Add(this.Btn_SaveFile);
            this.Controls.Add(this.Btn_OpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_OpenFile;
        private System.Windows.Forms.Button Btn_SaveFile;
        private System.Windows.Forms.Button Btn_FolderBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

