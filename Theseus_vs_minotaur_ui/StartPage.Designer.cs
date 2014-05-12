namespace Theseus_vs_minotaur_ui
{
    partial class START
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(START));
            this.playGame_btn = new System.Windows.Forms.Button();
            this.designLevels_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playGame_btn
            // 
            this.playGame_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGame_btn.Location = new System.Drawing.Point(454, 605);
            this.playGame_btn.Name = "playGame_btn";
            this.playGame_btn.Size = new System.Drawing.Size(160, 50);
            this.playGame_btn.TabIndex = 1;
            this.playGame_btn.Text = "Play Game";
            this.playGame_btn.UseVisualStyleBackColor = true;
            this.playGame_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // designLevels_btn
            // 
            this.designLevels_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designLevels_btn.Location = new System.Drawing.Point(209, 605);
            this.designLevels_btn.Name = "designLevels_btn";
            this.designLevels_btn.Size = new System.Drawing.Size(213, 49);
            this.designLevels_btn.TabIndex = 2;
            this.designLevels_btn.Text = "Design Levels";
            this.designLevels_btn.UseVisualStyleBackColor = true;
            this.designLevels_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // quit_btn
            // 
            this.quit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_btn.Location = new System.Drawing.Point(648, 605);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(160, 50);
            this.quit_btn.TabIndex = 3;
            this.quit_btn.Text = "Quit";
            this.quit_btn.UseVisualStyleBackColor = true;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(913, 682);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(201, 20);
            this.usernamebox.TabIndex = 4;
            this.usernamebox.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // START
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1164, 745);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.designLevels_btn);
            this.Controls.Add(this.playGame_btn);
            this.DoubleBuffered = true;
            this.Name = "START";
            this.Text = "StartPage";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playGame_btn;
        private System.Windows.Forms.Button designLevels_btn;
        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.TextBox usernamebox;
    }
}