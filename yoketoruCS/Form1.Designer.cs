namespace yoketoruCS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTitle = new Label();
            buttonStart = new Button();
            labelGameover = new Label();
            buttonTitle = new Button();
            labelClear = new Label();
            labelScore = new Label();
            labelHighScore = new Label();
            tempPlayer = new Label();
            labeltimer = new Label();
            labelCopyright = new Label();
            tempObstacle = new Label();
            tempItem = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(407, 84);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(153, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "よけとるCS";
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(407, 336);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(153, 70);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "スタート!!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Font = new Font("Yu Gothic UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            labelGameover.Location = new Point(393, 242);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(193, 51);
            labelGameover.TabIndex = 2;
            labelGameover.Text = "Gameover";
            // 
            // buttonTitle
            // 
            buttonTitle.Location = new Point(407, 336);
            buttonTitle.Name = "buttonTitle";
            buttonTitle.Size = new Size(153, 70);
            buttonTitle.TabIndex = 3;
            buttonTitle.Text = "タイトルへ";
            buttonTitle.UseVisualStyleBackColor = true;
            buttonTitle.Click += buttonTitle_Click;
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelClear.Location = new Point(428, 180);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(109, 45);
            labelClear.TabIndex = 4;
            labelClear.Text = "クリア!!";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(432, 9);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(105, 45);
            labelScore.TabIndex = 5;
            labelScore.Text = "00000";
            // 
            // labelHighScore
            // 
            labelHighScore.AutoSize = true;
            labelHighScore.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelHighScore.Location = new Point(393, 129);
            labelHighScore.Name = "labelHighScore";
            labelHighScore.Size = new Size(181, 90);
            labelHighScore.TabIndex = 6;
            labelHighScore.Text = "今回のスコア\r\n　00000";
            // 
            // tempPlayer
            // 
            tempPlayer.AutoSize = true;
            tempPlayer.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tempPlayer.Location = new Point(727, 283);
            tempPlayer.Name = "tempPlayer";
            tempPlayer.Size = new Size(33, 21);
            tempPlayer.TabIndex = 7;
            tempPlayer.Text = "👪";
            // 
            // labeltimer
            // 
            labeltimer.AutoSize = true;
            labeltimer.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labeltimer.Location = new Point(834, 9);
            labeltimer.Name = "labeltimer";
            labeltimer.Size = new Size(71, 45);
            labeltimer.TabIndex = 8;
            labeltimer.Text = "000";
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Location = new Point(12, 9);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(112, 15);
            labelCopyright.TabIndex = 9;
            labelCopyright.Text = "(C)2023.かとうまさひろ";
            // 
            // tempObstacle
            // 
            tempObstacle.AutoSize = true;
            tempObstacle.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tempObstacle.Location = new Point(683, 380);
            tempObstacle.Name = "tempObstacle";
            tempObstacle.Size = new Size(39, 28);
            tempObstacle.TabIndex = 10;
            tempObstacle.Text = "🔶";
            // 
            // tempItem
            // 
            tempItem.AutoSize = true;
            tempItem.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tempItem.Location = new Point(829, 359);
            tempItem.Name = "tempItem";
            tempItem.Size = new Size(26, 21);
            tempItem.TabIndex = 11;
            tempItem.Text = "★";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(tempItem);
            Controls.Add(tempObstacle);
            Controls.Add(labelCopyright);
            Controls.Add(labeltimer);
            Controls.Add(tempPlayer);
            Controls.Add(labelHighScore);
            Controls.Add(labelScore);
            Controls.Add(labelClear);
            Controls.Add(buttonTitle);
            Controls.Add(labelGameover);
            Controls.Add(buttonStart);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelTitle;
        private Button buttonStart;
        private Label labelGameover;
        private Button buttonTitle;
        private Label labelClear;
        private Label labelScore;
        private Label labelHighScore;
        private Label tempPlayer;
        private Label labeltimer;
        private Label labelCopyright;
        private Label tempObstacle;
        private Label tempItem;
    }
}