namespace Theseus_vs_minotaur_ui
{
    partial class SaveLevel
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
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.fileNameTbx = new System.Windows.Forms.TextBox();
            this.levelStateLbl = new System.Windows.Forms.Label();
            this.levelStateCbx = new System.Windows.Forms.ComboBox();
            this.saveLevelCancel = new System.Windows.Forms.Button();
            this.saveLevelOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.Location = new System.Drawing.Point(53, 115);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(54, 13);
            this.fileNameLbl.TabIndex = 0;
            this.fileNameLbl.Text = "File Name";
            // 
            // fileNameTbx
            // 
            this.fileNameTbx.Location = new System.Drawing.Point(178, 115);
            this.fileNameTbx.Name = "fileNameTbx";
            this.fileNameTbx.Size = new System.Drawing.Size(100, 20);
            this.fileNameTbx.TabIndex = 1;
            // 
            // levelStateLbl
            // 
            this.levelStateLbl.AutoSize = true;
            this.levelStateLbl.Location = new System.Drawing.Point(53, 179);
            this.levelStateLbl.Name = "levelStateLbl";
            this.levelStateLbl.Size = new System.Drawing.Size(61, 13);
            this.levelStateLbl.TabIndex = 2;
            this.levelStateLbl.Text = "Level State";
            // 
            // levelStateCbx
            // 
            this.levelStateCbx.FormattingEnabled = true;
            this.levelStateCbx.Items.AddRange(new object[] {
            "Finshed",
            "Unfinshed"});
            this.levelStateCbx.Location = new System.Drawing.Point(178, 179);
            this.levelStateCbx.Name = "levelStateCbx";
            this.levelStateCbx.Size = new System.Drawing.Size(121, 21);
            this.levelStateCbx.TabIndex = 4;
            // 
            // saveLevelCancel
            // 
            this.saveLevelCancel.Location = new System.Drawing.Point(222, 259);
            this.saveLevelCancel.Name = "saveLevelCancel";
            this.saveLevelCancel.Size = new System.Drawing.Size(56, 22);
            this.saveLevelCancel.TabIndex = 11;
            this.saveLevelCancel.Text = "Cancel";
            this.saveLevelCancel.UseVisualStyleBackColor = true;
            // 
            // saveLevelOk
            // 
            this.saveLevelOk.Location = new System.Drawing.Point(71, 268);
            this.saveLevelOk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.saveLevelOk.Name = "saveLevelOk";
            this.saveLevelOk.Size = new System.Drawing.Size(60, 23);
            this.saveLevelOk.TabIndex = 10;
            this.saveLevelOk.Text = "Ok";
            this.saveLevelOk.UseVisualStyleBackColor = true;
            // 
            // SaveLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 341);
            this.Controls.Add(this.saveLevelCancel);
            this.Controls.Add(this.saveLevelOk);
            this.Controls.Add(this.levelStateCbx);
            this.Controls.Add(this.levelStateLbl);
            this.Controls.Add(this.fileNameTbx);
            this.Controls.Add(this.fileNameLbl);
            this.Name = "SaveLevel";
            this.Text = "SaveLevel";
            this.Load += new System.EventHandler(this.SaveLevel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.TextBox fileNameTbx;
        private System.Windows.Forms.Label levelStateLbl;
        private System.Windows.Forms.ComboBox levelStateCbx;
        private System.Windows.Forms.Button saveLevelCancel;
        private System.Windows.Forms.Button saveLevelOk;
    }
}