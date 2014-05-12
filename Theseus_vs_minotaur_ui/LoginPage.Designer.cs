namespace Theseus_vs_minotaur_ui
{
    partial class LOGIN
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
            this.LogLabel = new System.Windows.Forms.Label();
            this.UsersBox = new System.Windows.Forms.ListBox();
            this.UserBut = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLabel.Location = new System.Drawing.Point(168, 52);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(88, 25);
            this.LogLabel.TabIndex = 0;
            this.LogLabel.Text = "LOG IN ";
            this.LogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // UsersBox
            // 
            this.UsersBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersBox.FormattingEnabled = true;
            this.UsersBox.Location = new System.Drawing.Point(13, 80);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.Size = new System.Drawing.Size(389, 446);
            this.UsersBox.TabIndex = 1;
            this.UsersBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UserBut
            // 
            this.UserBut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UserBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBut.Location = new System.Drawing.Point(13, 532);
            this.UserBut.Name = "UserBut";
            this.UserBut.Size = new System.Drawing.Size(127, 41);
            this.UserBut.TabIndex = 2;
            this.UserBut.Text = "New User";
            this.UserBut.UseVisualStyleBackColor = true;
            this.UserBut.Click += new System.EventHandler(this.UserBut_Click);
            // 
            // OK
            // 
            this.OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(324, 532);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(78, 41);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(442, 621);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.UserBut);
            this.Controls.Add(this.UsersBox);
            this.Controls.Add(this.LogLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LOGIN";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.ListBox UsersBox;
        private System.Windows.Forms.Button UserBut;
        private System.Windows.Forms.Button OK;
    }
}