namespace SnakeGame
{
    partial class HowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInstructions = new System.Windows.Forms.Panel();
            this.panelInstructions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(12, 424);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 25);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInstructions.Location = new System.Drawing.Point(31, 63);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(349, 110);
            this.lblInstructions.TabIndex = 10;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("OCR A Extended", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(31, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 47);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "How To Play?";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(31, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "Types of Apples";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelInstructions
            // 
            this.panelInstructions.AutoScroll = true;
            this.panelInstructions.Controls.Add(this.lblTitle);
            this.panelInstructions.Controls.Add(this.label1);
            this.panelInstructions.Controls.Add(this.lblInstructions);
            this.panelInstructions.Location = new System.Drawing.Point(22, 12);
            this.panelInstructions.Name = "panelInstructions";
            this.panelInstructions.Size = new System.Drawing.Size(437, 397);
            this.panelInstructions.TabIndex = 12;
            // 
            // HowToPlay
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelInstructions);
            this.Controls.Add(this.btnBack);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HowToPlay";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HowToPlay";
            this.Load += new System.EventHandler(this.HowToPlay_Load);
            this.panelInstructions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBack;
        private Label lblInstructions;
        private Label lblTitle;
        private Label label1;
        private Panel panelInstructions;
        private Label lblname;
    }
}