using DevExpress.XtraEditors;

namespace Hockey_Lineup_Manager_2
{
    public partial class SOEAform : Form
    {
        public SOEAform()
        {
            InitializeComponent();
        }

        #region Events

        private void SOEAform_Load(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length >= 1)
            {
                // Set the screen to the monitor that is sideways for me
                Rectangle monitor = Screen.PrimaryScreen.WorkingArea;
                foreach (Screen screen in Screen.AllScreens)
                {
                    if (screen.Bounds.Width.Equals(1050))
                    {
                        monitor = screen.WorkingArea;
                    }
                }
                // Change the wingow to the second monitor
                Location = new Point(monitor.Location.X, monitor.Location.Y + 817);       // Lower the position of the form by the max Y of an even strength form.
            }

            Loadbtn.PerformClick();
        }

        private void AllTextBoxes_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void AllTextBoxes_DragDrop(object sender, DragEventArgs e)
        {
            ((TextEdit)sender).Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void AllTextBoxes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                ((TextEdit)sender).DoDragDrop(((TextEdit)sender).Text, DragDropEffects.Copy);
        }

        #endregion Events

        #region Buttons

        private void Savebtn_Click(object sender, EventArgs e)
        {
            NHLTeam team = Methods.SelectCurrent<NHLTeam>();
            string year = Methods.GetCurrentYear();

            // Extra Attackers
            ShootoutExtraAttacker soea = new ShootoutExtraAttacker();
            soea.ExtraA1 = EA1txt.Text;
            soea.ExtraA2 = EA2txt.Text;

            // Shootout
            soea.Shooter1 = SO1txt.Text;
            soea.Shooter2 = SO2txt.Text;
            soea.Shooter3 = SO3txt.Text;
            soea.Shooter4 = SO4txt.Text;
            soea.Shooter5 = SO5txt.Text;

            team.SOEA = soea;

            Methods.Add(year, team);
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            NHLTeam team = Methods.SelectCurrent<NHLTeam>();
            if (team.SOEA != null)
            {
                EA1txt.Text = team.SOEA.ExtraA1;
                EA2txt.Text = team.SOEA.ExtraA2;
                SO1txt.Text = team.SOEA.Shooter1;
                SO2txt.Text = team.SOEA.Shooter2;
                SO3txt.Text = team.SOEA.Shooter3;
                SO4txt.Text = team.SOEA.Shooter4;
                SO5txt.Text = team.SOEA.Shooter5;
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            EA1txt.Text = "";
            EA2txt.Text = "";
            SO1txt.Text = "";
            SO2txt.Text = "";
            SO3txt.Text = "";
            SO4txt.Text = "";
            SO5txt.Text = "";
        }

        #endregion Buttons
    }
}
