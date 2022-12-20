namespace SnakeGame
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.pbSnake = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHSTable = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.ttMessage = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            // 
            // lblTitle1
            // 
            this.lblTitle1.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle1.Location = new System.Drawing.Point(66, 51);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(345, 148);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "Welcome to Snake";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbSnake
            // 
            this.pbSnake.Image = global::SnakeGame.Properties.Resources.snake;
            this.pbSnake.Location = new System.Drawing.Point(95, 229);
            this.pbSnake.Name = "pbSnake";
            this.pbSnake.Size = new System.Drawing.Size(119, 113);
            this.pbSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSnake.TabIndex = 2;
            this.pbSnake.TabStop = false;
            this.ttMessage.SetToolTip(this.pbSnake, "Let´s go eat the apples");
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlay.Location = new System.Drawing.Point(281, 229);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 22);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHSTable
            // 
            this.btnHSTable.AutoSize = true;
            this.btnHSTable.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnHSTable.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHSTable.FlatAppearance.BorderSize = 0;
            this.btnHSTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHSTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHSTable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHSTable.Location = new System.Drawing.Point(281, 283);
            this.btnHSTable.Name = "btnHSTable";
            this.btnHSTable.Size = new System.Drawing.Size(80, 25);
            this.btnHSTable.TabIndex = 4;
            this.btnHSTable.Text = "Scores";
            this.btnHSTable.UseVisualStyleBackColor = false;
            this.btnHSTable.Click += new System.EventHandler(this.btnHSTable_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(281, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 300;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnHowToPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHowToPlay.FlatAppearance.BorderSize = 0;
            this.btnHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHowToPlay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHowToPlay.Location = new System.Drawing.Point(281, 256);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(80, 22);
            this.btnHowToPlay.TabIndex = 7;
            this.btnHowToPlay.Text = "How to Play";
            this.btnHowToPlay.UseVisualStyleBackColor = false;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnApples_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(500, 433);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHSTable);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pbSnake);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblTitle1;
        private PictureBox pbSnake;
        private Button btnPlay;
        private Button btnHSTable;
        private Button btnExit;
        private System.Windows.Forms.Timer animationTimer;
        private Button btnHowToPlay;
        private ToolTip ttMessage;
    }
}