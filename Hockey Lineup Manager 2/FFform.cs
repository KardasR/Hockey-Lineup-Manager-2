using DevExpress.XtraEditors;

namespace Hockey_Lineup_Manager_2
{
    public partial class FFform : Form
    {
        public FFform()
        {
            InitializeComponent();
        }

        #region Events

        private void FFform_Load(object sender, EventArgs e)
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

            // First unit
            FourOnFourLines ff1 = new FourOnFourLines();
            ff1.Unit = 1;
            ff1.Wing = LW1txt.Text;
            ff1.Center = C1txt.Text;
            ff1.LeftDefence = LD1txt.Text;
            ff1.RightDefence = RD1txt.Text;

            // Second unit
            FourOnFourLines ff2 = new FourOnFourLines();
            ff2.Unit = 2;
            ff2.Wing = LW2txt.Text;
            ff2.Center = C2txt.Text;
            ff2.LeftDefence = LD2txt.Text;
            ff2.RightDefence = RD2txt.Text;

            // Third unit
            FourOnFourLines ff3 = new FourOnFourLines();
            ff3.Unit = 3;
            ff3.Center = C3txt.Text;
            ff3.Wing = LW3txt.Text;
            ff3.LeftDefence = LD3txt.Text;
            ff3.RightDefence = RD3txt.Text;

            team.FFL[0] = ff1;
            team.FFL[1] = ff2;
            team.FFL[2] = ff3;

            Methods.Add(year, team);
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            NHLTeam team = Methods.SelectCurrent<NHLTeam>();
            if (team.FFL[0] != null)
            {
                foreach (FourOnFourLines unit in team.FFL)
                {
                    switch (unit.Unit)
                    {
                        case 1:
                            LW1txt.Text = unit.Wing;
                            C1txt.Text = unit.Center;
                            LD1txt.Text = unit.LeftDefence;
                            RD1txt.Text = unit.RightDefence;
                            break;
                        case 2:
                            LW2txt.Text = unit.Wing;
                            C2txt.Text = unit.Center;
                            LD2txt.Text = unit.LeftDefence;
                            RD2txt.Text = unit.RightDefence;
                            break;
                        case 3:
                            LW3txt.Text = unit.Wing;
                            C3txt.Text = unit.Center;
                            LD3txt.Text = unit.LeftDefence;
                            RD3txt.Text = unit.RightDefence;
                            break;
                        default:
                            Clearbtn.PerformClick();
                            break;
                    }
                }
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            // First unit
            LW1txt.Text = "";
            C1txt.Text = "";
            LD1txt.Text = "";
            RD1txt.Text = "";

            // Second unit
            LW2txt.Text = "";
            C2txt.Text = "";
            LD2txt.Text = "";
            RD2txt.Text = "";

            // Third unit
            LW3txt.Text = "";
            C3txt.Text = "";
            LD3txt.Text = "";
            RD3txt.Text = "";
        }

        #endregion Buttons
    }
}
