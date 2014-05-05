namespace Theseus_vs_minotaur_ui
{
    partial class ImportLevel
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
            this.importLevelCancel = new System.Windows.Forms.Button();
            this.importLevelOk = new System.Windows.Forms.Button();
            this.levelStateCbx = new System.Windows.Forms.ComboBox();
            this.levelStateLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // importLevelCancel
            // 
            this.importLevelCancel.Location = new System.Drawing.Point(193, 161);
            this.importLevelCancel.Name = "importLevelCancel";
            this.importLevelCancel.Size = new System.Drawing.Size(56, 22);
            this.importLevelCancel.TabIndex = 15;
            this.importLevelCancel.Text = "Cancel";
            this.importLevelCancel.UseVisualStyleBackColor = true;
            // 
            // importLevelOk
            // 
            this.importLevelOk.Location = new System.Drawing.Point(51, 160);
            this.importLevelOk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.importLevelOk.Name = "importLevelOk";
            this.importLevelOk.Size = new System.Drawing.Size(60, 23);
            this.importLevelOk.TabIndex = 14;
            this.importLevelOk.Text = "Ok";
            this.importLevelOk.UseVisualStyleBackColor = true;
            // 
            // levelStateCbx
            // 
            this.levelStateCbx.FormattingEnabled = true;
            this.levelStateCbx.Items.AddRange(new object[] {
            "Finshed",
            "Unfinshed"});
            this.levelStateCbx.Location = new System.Drawing.Point(142, 81);
            this.levelStateCbx.Name = "levelStateCbx";
            this.levelStateCbx.Size = new System.Drawing.Size(121, 21);
            this.levelStateCbx.TabIndex = 13;
            // 
            // levelStateLbl
            // 
            this.levelStateLbl.AutoSize = true;
            this.levelStateLbl.Location = new System.Drawing.Point(48, 84);
            this.levelStateLbl.Name = "levelStateLbl";
            this.levelStateLbl.Size = new System.Drawing.Size(33, 13);
            this.levelStateLbl.TabIndex = 12;
            this.levelStateLbl.Text = "Level";
            // 
            // ImportLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.importLevelCancel);
            this.Controls.Add(this.importLevelOk);
            this.Controls.Add(this.levelStateCbx);
            this.Controls.Add(this.levelStateLbl);
            this.Name = "ImportLevel";
            this.Text = "ImportLevel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importLevelCancel;
        private System.Windows.Forms.Button importLevelOk;
        private System.Windows.Forms.ComboBox levelStateCbx;
        private System.Windows.Forms.Label levelStateLbl;
    }
}