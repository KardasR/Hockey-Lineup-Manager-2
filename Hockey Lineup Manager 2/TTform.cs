using DevExpress.XtraEditors;

namespace Hockey_Lineup_Manager_2
{
    public partial class TTform : Form
    {
        public TTform()
        {
            InitializeComponent();
        }

        #region Events

        private void TTform_Load(object sender, EventArgs e)
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
            ThreeOnThreeLines tt1 = new ThreeOnThreeLines();
            tt1.Unit = 1;
            tt1.Center = C1txt.Text;
            tt1.Wing = LD1txt.Text;
            tt1.Defence = RD1txt.Text;

            // Second unit
            ThreeOnThreeLines tt2 = new ThreeOnThreeLines();
            tt2.Unit = 2;
            tt2.Center = C2txt.Text;
            tt2.Wing = LD2txt.Text;
            tt2.Defence = RD2txt.Text;

            // Third unit
            ThreeOnThreeLines tt3 = new ThreeOnThreeLines();
            tt3.Unit = 3;
            tt3.Center = C3txt.Text;
            tt3.Wing = LD3txt.Text;
            tt3.Defence = RD3txt.Text;

            team.TTL[0] = tt1;
            team.TTL[1] = tt2;
            team.TTL[2] = tt3;

            Methods.Add(year, team);
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            NHLTeam team = Methods.SelectCurrent<NHLTeam>();
            if (team.TTL[0] != null)
            {
                foreach (ThreeOnThreeLines unit in team.TTL)
                {
                    switch (unit.Unit)
                    {
                        case 1:
                            C1txt.Text = unit.Center;
                            LD1txt.Text = unit.Wing;
                            RD1txt.Text = unit.Defence;
                            break;
                        case 2:
                            C2txt.Text = unit.Center;
                            LD2txt.Text = unit.Wing;
                            RD2txt.Text = unit.Defence;
                            break;
                        case 3:
                            C3txt.Text = unit.Center;
                            LD3txt.Text = unit.Wing;
                            RD3txt.Text = unit.Defence;
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
            C1txt.Text = "";
            LD1txt.Text = "";
            RD1txt.Text = "";

            // Second unit
            C2txt.Text = "";
            LD2txt.Text = "";
            RD2txt.Text = "";

            // Third unit
            C3txt.Text = "";
            LD3txt.Text = "";
            RD3txt.Text = "";
        }

        #endregion Buttons
    }
}
