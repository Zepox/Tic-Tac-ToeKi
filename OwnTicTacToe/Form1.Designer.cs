namespace OwnTicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.XWin = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(12, 12);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(80, 80);
            this.A3.TabIndex = 0;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.buttonClick);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(98, 11);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(80, 80);
            this.B3.TabIndex = 1;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.buttonClick);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(184, 12);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(80, 80);
            this.C3.TabIndex = 2;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.buttonClick);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(12, 97);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(80, 80);
            this.A2.TabIndex = 3;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.buttonClick);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(98, 98);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(80, 80);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.buttonClick);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(184, 98);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(80, 80);
            this.C2.TabIndex = 5;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.buttonClick);
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(12, 184);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(80, 80);
            this.A1.TabIndex = 6;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.buttonClick);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(98, 184);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(80, 80);
            this.B1.TabIndex = 7;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.buttonClick);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(184, 184);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(80, 80);
            this.C1.TabIndex = 8;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.buttonClick);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(12, 270);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(80, 26);
            this.NewGame.TabIndex = 9;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(184, 270);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 26);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(98, 270);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(80, 26);
            this.Reset.TabIndex = 11;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // XWin
            // 
            this.XWin.Location = new System.Drawing.Point(270, 12);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(161, 28);
            this.XWin.TabIndex = 12;
            this.XWin.Text = "label1";
            // 
            // OWin
            // 
            this.OWin.Location = new System.Drawing.Point(270, 97);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(161, 28);
            this.OWin.TabIndex = 13;
            this.OWin.Text = "label2";
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(270, 184);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(161, 28);
            this.Draw.TabIndex = 14;
            this.Draw.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.OWin);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label Draw;
    }
}

