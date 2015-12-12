using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Preferences : Form
    {
        bool language = true;
        TicTacToe form;

        public Preferences(TicTacToe form)
        {
            InitializeComponent();

            this.form = form;
            // Difficulty
            rdBtnEasy.Checked = Properties.Settings.Default.difficultyEasy;
            rdBtnMedium.Checked = Properties.Settings.Default.difficultyMedium;
            rdBtnHard.Checked = Properties.Settings.Default.difficultyHard;

            // Mode
            rdBtnPvC.Checked = Properties.Settings.Default.vsComp;
            rdBtnPvP.Checked = Properties.Settings.Default.vsHuman;

            // Language
            language = Properties.Settings.Default.language;

            if (language)
            {
                Text = "Preferences";
                grpBoxDifficulty.Text = "Difficulty";

                rdBtnPvP.Text = "vs Player";
                rdBtnPvC.Text = "vs Computer";
                rdBtnEasy.Text = "Easy";
                rdBtnMedium.Text = "Medium";
                rdBtnHard.Text = "Hard";

                btnCancel.Text = "Cancel";
            }
            else
            {
                Text = "Préférences";
                grpBoxDifficulty.Text = "Difficulté";

                rdBtnPvP.Text = "vs Humain";
                rdBtnPvC.Text = "vs Ordinateur";
                rdBtnEasy.Text = "Facile";
                rdBtnMedium.Text = "Intermédiaire";
                rdBtnHard.Text = "Difficile";

                btnCancel.Text = "Annuler";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Mode
            Properties.Settings.Default.vsComp = rdBtnPvC.Checked;
            Properties.Settings.Default.vsHuman = rdBtnPvP.Checked;

            // Difficulty
            Properties.Settings.Default.difficultyEasy = rdBtnEasy.Checked;
            Properties.Settings.Default.difficultyMedium = rdBtnMedium.Checked;
            Properties.Settings.Default.difficultyHard = rdBtnHard.Checked;

            form.resetButtons();
            Close();
        }
    }
}
