using DevExpress.XtraEditors;

namespace Hockey_Lineup_Manager_2
{
    public partial class PPform : Form
    {
        public PPform()
        {
            InitializeComponent();
        }

        #region Events

        private void PPform_Load(object sender, EventArgs e)
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
            PowerPlayLines pp1 = new PowerPlayLines();
            pp1.Unit = 1;
            pp1.LeftWing = LW1txt.Text;
            pp1.Center = C1txt.Text;
            pp1.RightWing = RW1txt.Text;
            pp1.LeftDefence = LD1txt.Text;
            pp1.RightDefence = RD1txt.Text;

            // Second unit
            PowerPlayLines pp2 = new PowerPlayLines();
            pp2.Unit = 2;
            pp2.LeftWing = LW2txt.Text;
            pp2.Center = C2txt.Text;
            pp2.RightWing = RW2txt.Text;
            pp2.LeftDefence = LD2txt.Text;
            pp2.RightDefence = RD2txt.Text;

            // Third unit
            PowerPlayLines pp3 = new PowerPlayLines();
            pp3.Unit = 3;
            pp3.Center = C3txt.Text;
            pp3.RightWing = RW3txt.Text;
            pp3.LeftDefence = LD3txt.Text;
            pp3.RightDefence = RD3txt.Text;

            // Fourth unit
            PowerPlayLines pp4 = new PowerPlayLines();
            pp4.Unit = 4;
            pp4.Center = C4txt.Text;
            pp4.RightWing = RW4txt.Text;
            pp4.LeftDefence = LD4txt.Text;
            pp4.RightDefence = RD4txt.Text;

            team.PPL[0] = pp1;
            team.PPL[1] = pp2;
            team.PPL[2] = pp3;
            team.PPL[3] = pp4;

            Methods.Add(year, team);
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            NHLTeam team = Methods.SelectCurrent<NHLTeam>();
            if (team.PPL[0] != null)
            {
                foreach (PowerPlayLines unit in team.PPL)
                {
                    switch (unit.Unit)
                    {
                        case 1:
                            LW1txt.Text = unit.LeftWing;
                            C1txt.Text = unit.Center;
                            RW1txt.Text = unit.RightWing;
                            LD1txt.Text = unit.LeftDefence;
                            RD1txt.Text = unit.RightDefence;
                            break;
                        case 2:
                            LW2txt.Text = unit.LeftWing;
                            C2txt.Text = unit.Center;
                            RW2txt.Text = unit.RightWing;
                            LD2txt.Text = unit.LeftDefence;
                            RD2txt.Text = unit.RightDefence;
                            break;
                        case 3:
                            C3txt.Text = unit.Center;
                            RW3txt.Text = unit.RightWing;
                            LD3txt.Text = unit.LeftDefence;
                            RD3txt.Text = unit.RightDefence;
                            break;
                        case 4:
                            C4txt.Text = unit.Center;
                            RW4txt.Text = unit.RightWing;
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
            RW1txt.Text = "";
            LD1txt.Text = "";
            RD1txt.Text = "";

            // Second unit
            LW2txt.Text = "";
            C2txt.Text = "";
            RW2txt.Text = "";
            LD2txt.Text = "";
            RD2txt.Text = "";

            // Third unit
            C3txt.Text = "";
            RW3txt.Text = "";
            LD3txt.Text = "";
            RD3txt.Text = "";

            // Fourth unit
            C4txt.Text = "";
            RW4txt.Text = "";
            LD4txt.Text = "";
            RD4txt.Text = "";
        }

        #endregion Buttons
    }
}
