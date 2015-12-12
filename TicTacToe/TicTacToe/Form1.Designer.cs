namespace TicTacToe
{
    partial class TicTacToe
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripWins = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripLosses = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripDraws = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuBarItemGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarItemNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarItemEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarItemFrench = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripWins,
            this.statusStripLosses,
            this.statusStripDraws});
            this.statusStrip.Location = new System.Drawing.Point(0, 340);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(284, 22);
            this.statusStrip.TabIndex = 54;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripWins
            // 
            this.statusStripWins.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStripWins.Name = "statusStripWins";
            this.statusStripWins.Size = new System.Drawing.Size(55, 17);
            this.statusStripWins.Text = "X Wins: 0";
            // 
            // statusStripLosses
            // 
            this.statusStripLosses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStripLosses.Name = "statusStripLosses";
            this.statusStripLosses.Size = new System.Drawing.Size(57, 17);
            this.statusStripLosses.Text = "O Wins: 0";
            // 
            // statusStripDraws
            // 
            this.statusStripDraws.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStripDraws.Name = "statusStripDraws";
            this.statusStripDraws.Size = new System.Drawing.Size(51, 17);
            this.statusStripDraws.Text = "Draws: 0";
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(184, 244);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 75);
            this.btn9.TabIndex = 53;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            this.btn9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(103, 244);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 75);
            this.btn8.TabIndex = 52;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            this.btn8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(184, 163);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 75);
            this.btn6.TabIndex = 50;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            this.btn6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(103, 163);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 75);
            this.btn5.TabIndex = 49;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            this.btn5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(22, 163);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 75);
            this.btn4.TabIndex = 48;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            this.btn4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(184, 82);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 75);
            this.btn3.TabIndex = 47;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            this.btn3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(103, 82);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 75);
            this.btn2.TabIndex = 46;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            this.btn2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(22, 82);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 75);
            this.btn1.TabIndex = 45;
            this.btn1.UseCompatibleTextRendering = true;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            this.btn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(22, 46);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 44;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(22, 244);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 75);
            this.btn7.TabIndex = 51;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            this.btn7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarItemGame});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(284, 24);
            this.menuBar.TabIndex = 43;
            this.menuBar.Text = "menuBar";
            // 
            // menuBarItemGame
            // 
            this.menuBarItemGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarItemNewGame,
            this.menuBarItemOptions,
            this.menuBarItemLanguage,
            this.menuBarItemClose});
            this.menuBarItemGame.Name = "menuBarItemGame";
            this.menuBarItemGame.Size = new System.Drawing.Size(50, 20);
            this.menuBarItemGame.Text = "Game";
            // 
            // menuBarItemNewGame
            // 
            this.menuBarItemNewGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuBarItemNewGame.Name = "menuBarItemNewGame";
            this.menuBarItemNewGame.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuBarItemNewGame.Size = new System.Drawing.Size(152, 22);
            this.menuBarItemNewGame.Text = "New Game";
            this.menuBarItemNewGame.Click += new System.EventHandler(this.menuBarItemNewGame_Click);
            // 
            // menuBarItemOptions
            // 
            this.menuBarItemOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuBarItemOptions.Name = "menuBarItemOptions";
            this.menuBarItemOptions.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuBarItemOptions.Size = new System.Drawing.Size(152, 22);
            this.menuBarItemOptions.Text = "Options";
            this.menuBarItemOptions.Click += new System.EventHandler(this.menuBarItemOptions_Click);
            // 
            // menuBarItemLanguage
            // 
            this.menuBarItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarItemEnglish,
            this.menuBarItemFrench});
            this.menuBarItemLanguage.Name = "menuBarItemLanguage";
            this.menuBarItemLanguage.Size = new System.Drawing.Size(152, 22);
            this.menuBarItemLanguage.Text = "Language";
            // 
            // menuBarItemEnglish
            // 
            this.menuBarItemEnglish.Checked = true;
            this.menuBarItemEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuBarItemEnglish.Name = "menuBarItemEnglish";
            this.menuBarItemEnglish.Size = new System.Drawing.Size(152, 22);
            this.menuBarItemEnglish.Text = "English";
            this.menuBarItemEnglish.Click += new System.EventHandler(this.menuBarItemEnglish_Click);
            // 
            // menuBarItemFrench
            // 
            this.menuBarItemFrench.Name = "menuBarItemFrench";
            this.menuBarItemFrench.Size = new System.Drawing.Size(152, 22);
            this.menuBarItemFrench.Text = "French";
            this.menuBarItemFrench.Click += new System.EventHandler(this.menuBarItemFrench_Click);
            // 
            // menuBarItemClose
            // 
            this.menuBarItemClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuBarItemClose.Name = "menuBarItemClose";
            this.menuBarItemClose.ShowShortcutKeys = false;
            this.menuBarItemClose.Size = new System.Drawing.Size(152, 22);
            this.menuBarItemClose.Text = "Exit";
            this.menuBarItemClose.Click += new System.EventHandler(this.menuBarItemClose_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        protected System.Windows.Forms.ToolStripStatusLabel statusStripWins;
        protected System.Windows.Forms.ToolStripStatusLabel statusStripLosses;
        protected System.Windows.Forms.ToolStripStatusLabel statusStripDraws;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuBarItemGame;
        private System.Windows.Forms.ToolStripMenuItem menuBarItemNewGame;
        private System.Windows.Forms.ToolStripMenuItem menuBarItemOptions;
        private System.Windows.Forms.ToolStripMenuItem menuBarItemLanguage;
        private System.Windows.Forms.ToolStripMenuItem menuBarItemEnglish;
        private System.Windows.Forms.ToolStripMenuItem menuBarItemFrench;
        private System.Windows.Forms.ToolStripMenuItem menuBarItemClose;
    }
}

