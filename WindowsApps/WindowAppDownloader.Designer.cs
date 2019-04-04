namespace WindowsDownloadApp
{
    partial class WindowAppDownloader
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
            this.DownloadFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DownloadUpdate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.downloadCheckbox3 = new WindowsDownloadApp.DownloadCheckbox();
            this.downloadCheckbox4 = new WindowsDownloadApp.DownloadCheckbox();
            this.downloadCheckbox1 = new WindowsDownloadApp.DownloadCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.downloadCheckbox2 = new WindowsDownloadApp.DownloadCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            this.downloadCheckbox5 = new WindowsDownloadApp.DownloadCheckbox();
            this.downloadCheckbox6 = new WindowsDownloadApp.DownloadCheckbox();
            this.downloadCheckbox7 = new WindowsDownloadApp.DownloadCheckbox();
            this.downloadCheckbox8 = new WindowsDownloadApp.DownloadCheckbox();
            this.label6 = new System.Windows.Forms.Label();
            this.downloadCheckbox9 = new WindowsDownloadApp.DownloadCheckbox();
            this.label7 = new System.Windows.Forms.Label();
            this.downloadCheckbox10 = new WindowsDownloadApp.DownloadCheckbox();
            this.downloadCheckbox11 = new WindowsDownloadApp.DownloadCheckbox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DownloadFiles
            // 
            this.DownloadFiles.Location = new System.Drawing.Point(427, 484);
            this.DownloadFiles.Name = "DownloadFiles";
            this.DownloadFiles.Size = new System.Drawing.Size(218, 55);
            this.DownloadFiles.TabIndex = 2;
            this.DownloadFiles.Text = "Download Files";
            this.DownloadFiles.UseVisualStyleBackColor = true;
            this.DownloadFiles.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Download Status:";
            // 
            // DownloadUpdate
            // 
            this.DownloadUpdate.AutoSize = true;
            this.DownloadUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadUpdate.Location = new System.Drawing.Point(40, 510);
            this.DownloadUpdate.Name = "DownloadUpdate";
            this.DownloadUpdate.Size = new System.Drawing.Size(0, 20);
            this.DownloadUpdate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Download Path:";
            // 
            // FilePathBox
            // 
            this.FilePathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePathBox.Location = new System.Drawing.Point(44, 415);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(422, 26);
            this.FilePathBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(509, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Browse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Social";
            // 
            // downloadCheckbox3
            // 
            this.downloadCheckbox3.DownloadType = WindowsDownloadApp.DownloadLinkEnum.UPlay;
            this.downloadCheckbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCheckbox3.Location = new System.Drawing.Point(53, 273);
            this.downloadCheckbox3.Name = "downloadCheckbox3";
            this.downloadCheckbox3.Size = new System.Drawing.Size(103, 31);
            this.downloadCheckbox3.TabIndex = 13;
            this.downloadCheckbox3.Text = "UPlay";
            // 
            // downloadCheckbox4
            // 
            this.downloadCheckbox4.DownloadType = WindowsDownloadApp.DownloadLinkEnum.Origin;
            this.downloadCheckbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCheckbox4.Location = new System.Drawing.Point(53, 236);
            this.downloadCheckbox4.Name = "downloadCheckbox4";
            this.downloadCheckbox4.Size = new System.Drawing.Size(103, 31);
            this.downloadCheckbox4.TabIndex = 11;
            this.downloadCheckbox4.Text = "Origin";
            // 
            // downloadCheckbox1
            // 
            this.downloadCheckbox1.DownloadType = WindowsDownloadApp.DownloadLinkEnum.EpicGames;
            this.downloadCheckbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCheckbox1.Location = new System.Drawing.Point(53, 310);
            this.downloadCheckbox1.Name = "downloadCheckbox1";
            this.downloadCheckbox1.Size = new System.Drawing.Size(103, 31);
            this.downloadCheckbox1.TabIndex = 15;
            this.downloadCheckbox1.Text = "Epic Games";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ninite Default";
            // 
            // downloadCheckbox2
            // 
            this.downloadCheckbox2.DownloadType = WindowsDownloadApp.DownloadLinkEnum.NiniteDefaults;
            this.downloadCheckbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCheckbox2.Location = new System.Drawing.Point(53, 92);
            this.downloadCheckbox2.Name = "downloadCheckbox2";
            this.downloadCheckbox2.Size = new System.Drawing.Size(103, 31);
            this.downloadCheckbox2.TabIndex = 17;
            this.downloadCheckbox2.Text = "Ninite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Visual Studios";
            // 
            // downloadCheckbox5
            // 
            this.downloadCheckbox5.DownloadType = WindowsDownloadApp.DownloadLinkEnum.VisualStudios2017;
            this.downloadCheckbox5.Enabled = false;
            this.downloadCheckbox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCheckbox5.Location = new System.Drawing.Point(274, 92);
            this.downloadCheckbox5.Name = "downloadCheckbox5";
            this.downloadCheckbox5.Size = new System.Drawing.Size(157, 31);
            this.downloadCheckbox5.TabIndex = 19;
            this.downloadCheckbox5.Text = "Visual Studios 2017";
            // 
            // downloadCheckbox6
            // 
            this.downloadCheckbox6.DownloadType = WindowsDownloadApp.DownloadLinkEnum.VisualStudios2019;
            this.downloadCheckbox6.Enabled = false;
            this.downloadCheckbox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCheckbox6.Location = new System.Drawing.Point(274, 130);
            this.downloadCheckbox6.Name = "downloadCheckbox6";
            this.downloadCheckbox6.Size = new System.Drawing.Size(157, 31);
            this.downloadCheckbox6.TabIndex = 20;
            this.downloadCheckbox6.Text = "Visual Studios 2019";
            // 
            // downloadCheckbox7
            // 
            this.downloadCheckbox7.DownloadType = WindowsDownloadApp.DownloadLinkEnum.P4V;
            this.downloadCheckbox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCheckbox7.Location = new System.Drawing.Point(265, 273);
            this.downloadCheckbox7.Name = "downloadCheckbox7";
            this.downloadCheckbox7.Size = new System.Drawing.Size(180, 31);
            this.downloadCheckbox7.TabIndex = 23;
            this.downloadCheckbox7.Text = "Perforce Visual Client";
            // 
            // downloadCheckbox8
            // 
            this.downloadCheckbox8.DownloadType = WindowsDownloadApp.DownloadLinkEnum.SourceTree;
            this.downloadCheckbox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCheckbox8.Location = new System.Drawing.Point(265, 236);
            this.downloadCheckbox8.Name = "downloadCheckbox8";
            this.downloadCheckbox8.Size = new System.Drawing.Size(157, 31);
            this.downloadCheckbox8.TabIndex = 22;
            this.downloadCheckbox8.Text = "SourceTree";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Source Control";
            // 
            // downloadCheckbox9
            // 
            this.downloadCheckbox9.DownloadType = WindowsDownloadApp.DownloadLinkEnum.UnityHub;
            this.downloadCheckbox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCheckbox9.Location = new System.Drawing.Point(518, 236);
            this.downloadCheckbox9.Name = "downloadCheckbox9";
            this.downloadCheckbox9.Size = new System.Drawing.Size(157, 31);
            this.downloadCheckbox9.TabIndex = 25;
            this.downloadCheckbox9.Text = "Unity Hub";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(512, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "Engine";
            // 
            // downloadCheckbox10
            // 
            this.downloadCheckbox10.DownloadType = WindowsDownloadApp.DownloadLinkEnum.TidyTab;
            this.downloadCheckbox10.Enabled = false;
            this.downloadCheckbox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCheckbox10.Location = new System.Drawing.Point(510, 129);
            this.downloadCheckbox10.Name = "downloadCheckbox10";
            this.downloadCheckbox10.Size = new System.Drawing.Size(180, 31);
            this.downloadCheckbox10.TabIndex = 28;
            this.downloadCheckbox10.Text = "TidyTab";
            // 
            // downloadCheckbox11
            // 
            this.downloadCheckbox11.DownloadType = WindowsDownloadApp.DownloadLinkEnum.AquaSnap;
            this.downloadCheckbox11.Enabled = false;
            this.downloadCheckbox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCheckbox11.Location = new System.Drawing.Point(510, 92);
            this.downloadCheckbox11.Name = "downloadCheckbox11";
            this.downloadCheckbox11.Size = new System.Drawing.Size(157, 31);
            this.downloadCheckbox11.TabIndex = 27;
            this.downloadCheckbox11.Text = "AquaSnap";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(504, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 31);
            this.label8.TabIndex = 26;
            this.label8.Text = "Windows(Paid)";
            // 
            // WindowAppDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 555);
            this.Controls.Add(this.downloadCheckbox10);
            this.Controls.Add(this.downloadCheckbox11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.downloadCheckbox9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.downloadCheckbox7);
            this.Controls.Add(this.downloadCheckbox8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.downloadCheckbox6);
            this.Controls.Add(this.downloadCheckbox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.downloadCheckbox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.downloadCheckbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.downloadCheckbox3);
            this.Controls.Add(this.downloadCheckbox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DownloadUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DownloadFiles);
            this.Name = "WindowAppDownloader";
            this.Text = "WindowsAppDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DownloadFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DownloadUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.Button button1;
        private DownloadCheckbox downloadCheckbox4;
        private DownloadCheckbox downloadCheckbox3;
        private System.Windows.Forms.Label label3;
        private DownloadCheckbox downloadCheckbox1;
        private System.Windows.Forms.Label label4;
        private DownloadCheckbox downloadCheckbox2;
        private System.Windows.Forms.Label label5;
        private DownloadCheckbox downloadCheckbox5;
        private DownloadCheckbox downloadCheckbox6;
        private DownloadCheckbox downloadCheckbox7;
        private DownloadCheckbox downloadCheckbox8;
        private System.Windows.Forms.Label label6;
        private DownloadCheckbox downloadCheckbox9;
        private System.Windows.Forms.Label label7;
        private DownloadCheckbox downloadCheckbox10;
        private DownloadCheckbox downloadCheckbox11;
        private System.Windows.Forms.Label label8;
    }
}

