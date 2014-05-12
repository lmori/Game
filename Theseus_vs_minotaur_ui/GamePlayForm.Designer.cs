namespace Theseus_vs_minotaur_ui
{
    partial class GamePlayForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLevelName = new System.Windows.Forms.Label();
            this.lblLevelDifficulty = new System.Windows.Forms.Label();
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlScoreTimer = new System.Windows.Forms.Panel();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.lblMovesValue = new System.Windows.Forms.Label();
            this.lblMoveLabel = new System.Windows.Forms.Label();
            this.lblTimerValue = new System.Windows.Forms.Label();
            this.lblTimerLabel = new System.Windows.Forms.Label();
            this.pnlGameControls = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnMoveNoChange = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnNewLevel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.pnlMenuControls = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.pnlScoreTimer.SuspendLayout();
            this.pnlGameControls.SuspendLayout();
            this.pnlMenuControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(137, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(430, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Theseus vs The Minotaur";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLevelName
            // 
            this.lblLevelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLevelName.AutoSize = true;
            this.lblLevelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelName.Location = new System.Drawing.Point(138, 55);
            this.lblLevelName.Name = "lblLevelName";
            this.lblLevelName.Size = new System.Drawing.Size(202, 31);
            this.lblLevelName.TabIndex = 1;
            this.lblLevelName.Text = "<Level Name>";
            // 
            // lblLevelDifficulty
            // 
            this.lblLevelDifficulty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLevelDifficulty.AutoSize = true;
            this.lblLevelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelDifficulty.Location = new System.Drawing.Point(346, 55);
            this.lblLevelDifficulty.Name = "lblLevelDifficulty";
            this.lblLevelDifficulty.Size = new System.Drawing.Size(241, 31);
            this.lblLevelDifficulty.TabIndex = 2;
            this.lblLevelDifficulty.Text = "<Level Difficulty>";
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGameBoard.AutoSize = true;
            this.pnlGameBoard.BackColor = System.Drawing.Color.White;
            this.pnlGameBoard.Location = new System.Drawing.Point(149, 120);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(486, 457);
            this.pnlGameBoard.TabIndex = 3;
            this.pnlGameBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGameBoard_Paint);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblUsername);
            this.pnlTitle.Controls.Add(this.lblLevelDifficulty);
            this.pnlTitle.Controls.Add(this.lblLevelName);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(784, 114);
            this.pnlTitle.TabIndex = 4;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(638, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(134, 25);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "<Username>";
            // 
            // pnlScoreTimer
            // 
            this.pnlScoreTimer.Controls.Add(this.btnHowToPlay);
            this.pnlScoreTimer.Controls.Add(this.lblMovesValue);
            this.pnlScoreTimer.Controls.Add(this.lblMoveLabel);
            this.pnlScoreTimer.Controls.Add(this.lblTimerValue);
            this.pnlScoreTimer.Controls.Add(this.lblTimerLabel);
            this.pnlScoreTimer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlScoreTimer.Location = new System.Drawing.Point(0, 114);
            this.pnlScoreTimer.Name = "pnlScoreTimer";
            this.pnlScoreTimer.Size = new System.Drawing.Size(143, 612);
            this.pnlScoreTimer.TabIndex = 5;
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.Location = new System.Drawing.Point(17, 331);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(114, 46);
            this.btnHowToPlay.TabIndex = 4;
            this.btnHowToPlay.Text = "How To Play";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            // 
            // lblMovesValue
            // 
            this.lblMovesValue.AutoSize = true;
            this.lblMovesValue.BackColor = System.Drawing.Color.White;
            this.lblMovesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesValue.Location = new System.Drawing.Point(12, 178);
            this.lblMovesValue.Name = "lblMovesValue";
            this.lblMovesValue.Size = new System.Drawing.Size(99, 25);
            this.lblMovesValue.TabIndex = 3;
            this.lblMovesValue.Text = "<moves>";
            this.lblMovesValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMoveLabel
            // 
            this.lblMoveLabel.AutoSize = true;
            this.lblMoveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveLabel.Location = new System.Drawing.Point(12, 153);
            this.lblMoveLabel.Name = "lblMoveLabel";
            this.lblMoveLabel.Size = new System.Drawing.Size(76, 25);
            this.lblMoveLabel.TabIndex = 2;
            this.lblMoveLabel.Text = "Moves";
            this.lblMoveLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimerValue
            // 
            this.lblTimerValue.AutoSize = true;
            this.lblTimerValue.BackColor = System.Drawing.Color.White;
            this.lblTimerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerValue.Location = new System.Drawing.Point(12, 79);
            this.lblTimerValue.Name = "lblTimerValue";
            this.lblTimerValue.Size = new System.Drawing.Size(82, 25);
            this.lblTimerValue.TabIndex = 1;
            this.lblTimerValue.Text = "<time> ";
            this.lblTimerValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimerLabel
            // 
            this.lblTimerLabel.AutoSize = true;
            this.lblTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerLabel.Location = new System.Drawing.Point(12, 54);
            this.lblTimerLabel.Name = "lblTimerLabel";
            this.lblTimerLabel.Size = new System.Drawing.Size(120, 25);
            this.lblTimerLabel.TabIndex = 0;
            this.lblTimerLabel.Text = "Timer (sec)";
            this.lblTimerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlGameControls
            // 
            this.pnlGameControls.Controls.Add(this.btnUndo);
            this.pnlGameControls.Controls.Add(this.btnRestart);
            this.pnlGameControls.Controls.Add(this.btnMoveNoChange);
            this.pnlGameControls.Controls.Add(this.btnMoveDown);
            this.pnlGameControls.Controls.Add(this.btnMoveRight);
            this.pnlGameControls.Controls.Add(this.btnMoveLeft);
            this.pnlGameControls.Controls.Add(this.btnMoveUp);
            this.pnlGameControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGameControls.Location = new System.Drawing.Point(143, 583);
            this.pnlGameControls.Name = "pnlGameControls";
            this.pnlGameControls.Size = new System.Drawing.Size(498, 143);
            this.pnlGameControls.TabIndex = 7;
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUndo.Location = new System.Drawing.Point(80, 54);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(49, 37);
            this.btnUndo.TabIndex = 6;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestart.Location = new System.Drawing.Point(16, 53);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(49, 37);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnMoveNoChange
            // 
            this.btnMoveNoChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMoveNoChange.Location = new System.Drawing.Point(211, 53);
            this.btnMoveNoChange.Name = "btnMoveNoChange";
            this.btnMoveNoChange.Size = new System.Drawing.Size(49, 37);
            this.btnMoveNoChange.TabIndex = 4;
            this.btnMoveNoChange.Text = "Stay";
            this.btnMoveNoChange.UseVisualStyleBackColor = true;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMoveDown.Location = new System.Drawing.Point(210, 97);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(49, 37);
            this.btnMoveDown.TabIndex = 3;
            this.btnMoveDown.Text = "Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMoveRight.Location = new System.Drawing.Point(266, 54);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(49, 37);
            this.btnMoveRight.TabIndex = 2;
            this.btnMoveRight.Text = "Right";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMoveLeft.Location = new System.Drawing.Point(156, 54);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(49, 37);
            this.btnMoveLeft.TabIndex = 1;
            this.btnMoveLeft.Text = "Left";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMoveUp.Location = new System.Drawing.Point(210, 9);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(49, 37);
            this.btnMoveUp.TabIndex = 0;
            this.btnMoveUp.Text = "Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            // 
            // btnNewLevel
            // 
            this.btnNewLevel.Location = new System.Drawing.Point(17, 33);
            this.btnNewLevel.Name = "btnNewLevel";
            this.btnNewLevel.Size = new System.Drawing.Size(114, 46);
            this.btnNewLevel.TabIndex = 5;
            this.btnNewLevel.Text = "New Level";
            this.btnNewLevel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnHighScores
            // 
            this.btnHighScores.Location = new System.Drawing.Point(17, 247);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(114, 46);
            this.btnHighScores.TabIndex = 7;
            this.btnHighScores.Text = "HighScores";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(17, 170);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(114, 46);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(17, 523);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(114, 46);
            this.btnMainMenu.TabIndex = 9;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // pnlMenuControls
            // 
            this.pnlMenuControls.Controls.Add(this.btnMainMenu);
            this.pnlMenuControls.Controls.Add(this.btnLoad);
            this.pnlMenuControls.Controls.Add(this.btnHighScores);
            this.pnlMenuControls.Controls.Add(this.btnSave);
            this.pnlMenuControls.Controls.Add(this.btnNewLevel);
            this.pnlMenuControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenuControls.Location = new System.Drawing.Point(641, 114);
            this.pnlMenuControls.Name = "pnlMenuControls";
            this.pnlMenuControls.Size = new System.Drawing.Size(143, 612);
            this.pnlMenuControls.TabIndex = 6;
            // 
            // GamePlayForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 726);
            this.Controls.Add(this.pnlGameBoard);
            this.Controls.Add(this.pnlGameControls);
            this.Controls.Add(this.pnlMenuControls);
            this.Controls.Add(this.pnlScoreTimer);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GamePlayForm";
            this.Text = "Theseus vs The Minotaur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GamePlayForm_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlScoreTimer.ResumeLayout(false);
            this.pnlScoreTimer.PerformLayout();
            this.pnlGameControls.ResumeLayout(false);
            this.pnlMenuControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLevelName;
        private System.Windows.Forms.Label lblLevelDifficulty;
        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlScoreTimer;
        private System.Windows.Forms.Panel pnlGameControls;
        private System.Windows.Forms.Label lblMovesValue;
        private System.Windows.Forms.Label lblMoveLabel;
        private System.Windows.Forms.Label lblTimerValue;
        private System.Windows.Forms.Label lblTimerLabel;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Button btnMoveNoChange;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnNewLevel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Panel pnlMenuControls;
    }
}