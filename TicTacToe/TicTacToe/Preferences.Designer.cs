namespace TicTacToe
{
    partial class Preferences
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
            this.grpBoxMode = new System.Windows.Forms.GroupBox();
            this.rdBtnPvC = new System.Windows.Forms.RadioButton();
            this.rdBtnPvP = new System.Windows.Forms.RadioButton();
            this.grpBoxDifficulty = new System.Windows.Forms.GroupBox();
            this.rdBtnHard = new System.Windows.Forms.RadioButton();
            this.rdBtnMedium = new System.Windows.Forms.RadioButton();
            this.rdBtnEasy = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpBoxMode.SuspendLayout();
            this.grpBoxDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxMode
            // 
            this.grpBoxMode.Controls.Add(this.rdBtnPvC);
            this.grpBoxMode.Controls.Add(this.rdBtnPvP);
            this.grpBoxMode.Location = new System.Drawing.Point(23, 125);
            this.grpBoxMode.Name = "grpBoxMode";
            this.grpBoxMode.Size = new System.Drawing.Size(98, 72);
            this.grpBoxMode.TabIndex = 7;
            this.grpBoxMode.TabStop = false;
            this.grpBoxMode.Text = "Mode";
            // 
            // rdBtnPvC
            // 
            this.rdBtnPvC.AutoSize = true;
            this.rdBtnPvC.Location = new System.Drawing.Point(7, 44);
            this.rdBtnPvC.Name = "rdBtnPvC";
            this.rdBtnPvC.Size = new System.Drawing.Size(84, 17);
            this.rdBtnPvC.TabIndex = 1;
            this.rdBtnPvC.Text = "vs Computer";
            this.rdBtnPvC.UseVisualStyleBackColor = true;
            // 
            // rdBtnPvP
            // 
            this.rdBtnPvP.AutoSize = true;
            this.rdBtnPvP.Location = new System.Drawing.Point(7, 20);
            this.rdBtnPvP.Name = "rdBtnPvP";
            this.rdBtnPvP.Size = new System.Drawing.Size(73, 17);
            this.rdBtnPvP.TabIndex = 0;
            this.rdBtnPvP.Text = "vs Human";
            this.rdBtnPvP.UseVisualStyleBackColor = true;
            // 
            // grpBoxDifficulty
            // 
            this.grpBoxDifficulty.Controls.Add(this.rdBtnHard);
            this.grpBoxDifficulty.Controls.Add(this.rdBtnMedium);
            this.grpBoxDifficulty.Controls.Add(this.rdBtnEasy);
            this.grpBoxDifficulty.Location = new System.Drawing.Point(23, 18);
            this.grpBoxDifficulty.Name = "grpBoxDifficulty";
            this.grpBoxDifficulty.Size = new System.Drawing.Size(98, 94);
            this.grpBoxDifficulty.TabIndex = 6;
            this.grpBoxDifficulty.TabStop = false;
            this.grpBoxDifficulty.Text = "Difficulty";
            // 
            // rdBtnHard
            // 
            this.rdBtnHard.AutoSize = true;
            this.rdBtnHard.Location = new System.Drawing.Point(7, 68);
            this.rdBtnHard.Name = "rdBtnHard";
            this.rdBtnHard.Size = new System.Drawing.Size(48, 17);
            this.rdBtnHard.TabIndex = 2;
            this.rdBtnHard.Text = "Hard";
            this.rdBtnHard.UseVisualStyleBackColor = true;
            // 
            // rdBtnMedium
            // 
            this.rdBtnMedium.AutoSize = true;
            this.rdBtnMedium.Location = new System.Drawing.Point(7, 44);
            this.rdBtnMedium.Name = "rdBtnMedium";
            this.rdBtnMedium.Size = new System.Drawing.Size(62, 17);
            this.rdBtnMedium.TabIndex = 1;
            this.rdBtnMedium.Text = "Medium";
            this.rdBtnMedium.UseVisualStyleBackColor = true;
            // 
            // rdBtnEasy
            // 
            this.rdBtnEasy.AutoSize = true;
            this.rdBtnEasy.Location = new System.Drawing.Point(7, 20);
            this.rdBtnEasy.Name = "rdBtnEasy";
            this.rdBtnEasy.Size = new System.Drawing.Size(48, 17);
            this.rdBtnEasy.TabIndex = 0;
            this.rdBtnEasy.Text = "Easy";
            this.rdBtnEasy.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(30, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(111, 221);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Preferences
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(208, 262);
            this.Controls.Add(this.grpBoxMode);
            this.Controls.Add(this.grpBoxDifficulty);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.grpBoxMode.ResumeLayout(false);
            this.grpBoxMode.PerformLayout();
            this.grpBoxDifficulty.ResumeLayout(false);
            this.grpBoxDifficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMode;
        internal System.Windows.Forms.RadioButton rdBtnPvC;
        internal System.Windows.Forms.RadioButton rdBtnPvP;
        private System.Windows.Forms.GroupBox grpBoxDifficulty;
        internal System.Windows.Forms.RadioButton rdBtnHard;
        internal System.Windows.Forms.RadioButton rdBtnMedium;
        internal System.Windows.Forms.RadioButton rdBtnEasy;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
    }
}