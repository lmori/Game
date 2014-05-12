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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 

            this.exit.Location = new System.Drawing.Point(889, 742);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 26);
            this.exit.TabIndex = 0;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // createNewProject
            // 
            this.createNewProject.Location = new System.Drawing.Point(52, 749);
            this.createNewProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createNewProject.Name = "createNewProject";
            this.createNewProject.Size = new System.Drawing.Size(100, 26);
            this.createNewProject.TabIndex = 1;
            this.createNewProject.Text = "New Project";
            this.createNewProject.UseVisualStyleBackColor = true;
            this.createNewProject.Click += new System.EventHandler(this.createNewProject_Click);
            // 
            // save
            // 

            this.save.Location = new System.Drawing.Point(252, 742);
            this.save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 26);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(681, 742);
            this.export.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(100, 26);
            this.export.TabIndex = 3;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // import
            // 

            this.import.Location = new System.Drawing.Point(453, 749);
            this.import.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(100, 26);
            this.import.TabIndex = 4;
            this.import.Text = "Import";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // pictureBox1
            // 

            this.pictureBox1.Location = new System.Drawing.Point(52, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Size = new System.Drawing.Size(800, 692);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(1024, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 429);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(75, 263);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 58);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // LevelDesigner
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 778);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.import);
            this.Controls.Add(this.export);
            this.Controls.Add(this.save);
            this.Controls.Add(this.createNewProject);
            this.Controls.Add(this.exit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LevelDesigner";
            this.Text = "levelDesigner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

