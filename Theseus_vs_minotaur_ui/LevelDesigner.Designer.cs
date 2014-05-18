namespace Theseus_vs_minotaur_ui
{
    partial class LevelDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelDesigner));
            this.exit = new System.Windows.Forms.Button();
            this.createNewProject = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.designCanvasPicBx = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.designCanvasPicBx)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(665, 639);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // createNewProject
            // 
            this.createNewProject.Location = new System.Drawing.Point(37, 639);
            this.createNewProject.Name = "createNewProject";
            this.createNewProject.Size = new System.Drawing.Size(75, 23);
            this.createNewProject.TabIndex = 1;
            this.createNewProject.Text = "New Project";
            this.createNewProject.UseVisualStyleBackColor = true;
            this.createNewProject.Click += new System.EventHandler(this.createNewProject_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(187, 639);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(509, 639);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 3;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(338, 639);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 4;
            this.import.Text = "Import";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // pictureBox1
            // 
            this.designCanvasPicBx.Location = new System.Drawing.Point(39, 18);
            this.designCanvasPicBx.Name = "pictureBox1";
            this.designCanvasPicBx.Padding = new System.Windows.Forms.Padding(2);
            this.designCanvasPicBx.Size = new System.Drawing.Size(600, 600);
            this.designCanvasPicBx.TabIndex = 5;
            this.designCanvasPicBx.TabStop = false;
            this.designCanvasPicBx.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.designCanvasPicBx.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            this.designCanvasPicBx.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.designCanvasPicBx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.designCanvasPicBx_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(715, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 600);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(102, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 73);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // LevelDesigner
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 674);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.designCanvasPicBx);
            this.Controls.Add(this.import);
            this.Controls.Add(this.export);
            this.Controls.Add(this.save);
            this.Controls.Add(this.createNewProject);
            this.Controls.Add(this.exit);
            this.Name = "LevelDesigner";
            this.Text = "levelDesigner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.designCanvasPicBx)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button createNewProject;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.PictureBox designCanvasPicBx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

