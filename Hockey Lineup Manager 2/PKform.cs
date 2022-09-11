using DevExpress.XtraEditors;

namespace Hockey_Lineup_Manager_2
{
    public partial class PKform : Form
    {
        public PKform()
        {
            InitializeComponent();
        }

        #region Events

        private void PKform_Load(object sender, EventArgs e)
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
            PenaltyKillLines pk1 = new PenaltyKillLines();
            pk1.Unit = 1;
            pk1.Wing = LW1txt.Text;
            pk1.Center = C1txt.Text;
            pk1.LeftDefence = LD1txt.Text;
            pk1.RightDefence = RD1txt.Text;

            // Second unit
            PenaltyKillLines pk2 = new PenaltyKillLines();
            pk2.Unit = 2;
            pk2.Wing = LW2txt.Text;
            pk2.Center = C2txt.Text;
            pk2.LeftDefence = LD2txt.Text;
            pk2.RightDefence = RD2txt.Text;

            // Third unit
            PenaltyKillLines pk3 = new PenaltyKillLines();
            pk3.Unit = 3;
            pk3.Center = C3txt.Text;
            pk3.LeftDefence = LD3txt.Text;
            pk3.RightDefence = RD3txt.Text;

            // Fourth unit
            PenaltyKillLines pk4 = new PenaltyKillLines();
            pk4.Unit = 4;
            pk4.Center = C4txt.Text;
            pk4.LeftDefence = LD4txt.Text;
            pk4.RightDefence = RD4txt.Text;

            team.PKL[0] = pk1;
            team.PKL[1] = pk2;
            team.PKL[2] = pk3;
            team.PKL[3] = pk4;

            Methods.Add(year, team);
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            NHLTeam team = Methods.SelectCurrent<NHLTeam>();
            if (team.PKL[0] != null)
            {
                foreach (PenaltyKillLines unit in team.PKL)
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
                            C3txt.Text = unit.Center;
                            LD3txt.Text = unit.LeftDefence;
                            RD3txt.Text = unit.RightDefence;
                            break;
                        case 4:
                            C4txt.Text = unit.Center;
                            LD4txt.Text = unit.LeftDefence;
                            RD4txt.Text = unit.RightDefence;
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
            C3txt.Text = "";
            LD3txt.Text = "";
            RD3txt.Text = "";

            // Fourth unit
            C4txt.Text = "";
            LD4txt.Text = "";
            RD4txt.Text = "";
        }

        #endregion Buttons
    }
}
