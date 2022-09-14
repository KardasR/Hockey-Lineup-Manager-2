using DevExpress.XtraEditors;

namespace Hockey_Lineup_Manager_2
{
    public partial class AHLform : Form
    {
        #region Constructors

        public AHLform()
        {
            InitializeComponent();
        }

        public AHLform(string teamName)
        {
            InitializeComponent();

            TeamNamelbl.Text = teamName;
        }

        #endregion Constructors

        #region Events

        private void AHLform_Load(object sender, EventArgs e)
        {
            // Put form on my second monitor
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

            NHLTeam NHLteam = Methods.SelectCurrent<NHLTeam>();
            if (NHLteam.AHLLines != null && NHLteam.AHLLines.ESL[0] != null)
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
            NHLTeam NHLteam = Methods.SelectCurrent<NHLTeam>();
            AHLTeam team = NHLteam.AHLLines != null ? NHLteam.AHLLines : new AHLTeam();
            team.Name = TeamNamelbl.Text;
            team.Record = Recordtb.Text;
            team.Playoff = Playofftb.Text;

            EvenStrengthLines line = new EvenStrengthLines();
            Player player = new Player();

            //--------------------------------------------  1st Line / 1st Pairing  --------------------------------------------
            line.Line = 1;

            // Save 1st line Left Wing
            player.Name = LW1txt.Text;
            player.Overall = string.IsNullOrEmpty(OLW1txt.Text) ? 0 : int.Parse(OLW1txt.Text);
            line.LeftWing = player;

            // Save 1st line Center
            player = new Player();
            player.Name = C1txt.Text;
            player.Overall = string.IsNullOrEmpty(OC1txt.Text) ? 0 : int.Parse(OC1txt.Text);
            line.Center = player;

            // Save 1st line Right Wing
            player = new Player();
            player.Name = RW1txt.Text;
            player.Overall = string.IsNullOrEmpty(ORW1txt.Text) ? 0 : int.Parse(ORW1txt.Text);
            line.RightWing = player;

            // Save 1st pair Left Def
            player = new Player();
            player.Name = LD1txt.Text;
            player.Overall = string.IsNullOrEmpty(OLD1txt.Text) ? 0 : int.Parse(OLD1txt.Text);
            line.LeftDefence = player;

            // Save 1st pair Right Def
            player = new Player();
            player.Name = RD1txt.Text;
            player.Overall = string.IsNullOrEmpty(ORD1txt.Text) ? 0 : int.Parse(ORD1txt.Text);
            line.RightDefence = player;

            team.ESL[0] = line;

            //--------------------------------------------  2nd Line / 2nd Pairing  --------------------------------------------
            line = new EvenStrengthLines();
            line.Line = 2;

            // Save 2nd line Left Wing
            player = new Player();
            player.Name = LW2txt.Text;
            player.Overall = string.IsNullOrEmpty(OLW2txt.Text) ? 0 : int.Parse(OLW2txt.Text);
            line.LeftWing = player;

            // Save 2nd line Center
            player = new Player();
            player.Name = C2txt.Text;
            player.Overall = string.IsNullOrEmpty(OC2txt.Text) ? 0 : int.Parse(OC2txt.Text);
            line.Center = player;

            // Save 2nd line Right Wing
            player = new Player();
            player.Name = RW2txt.Text;
            player.Overall = string.IsNullOrEmpty(ORW2txt.Text) ? 0 : int.Parse(ORW2txt.Text);
            line.RightWing = player;

            // Save 2nd pair Left Def
            player = new Player();
            player.Name = LD2txt.Text;
            player.Overall = string.IsNullOrEmpty(OLD2txt.Text) ? 0 : int.Parse(OLD2txt.Text);
            line.LeftDefence = player;

            // Save 2nd pair Right Def
            player = new Player();
            player.Name = RD2txt.Text;
            player.Overall = string.IsNullOrEmpty(ORD2txt.Text) ? 0 : int.Parse(ORD2txt.Text);
            line.RightDefence = player;

            team.ESL[1] = line;

            //--------------------------------------------  3rd Line / 3rd Pairing  --------------------------------------------
            line = new EvenStrengthLines();
            line.Line = 3;

            // Save 3rd line Left Wing
            player = new Player();
            player.Name = LW3txt.Text;
            player.Overall = string.IsNullOrEmpty(OLW3txt.Text) ? 0 : int.Parse(OLW3txt.Text);
            line.LeftWing = player;

            // Save 3rd line Center
            player = new Player();
            player.Name = C3txt.Text;
            player.Overall = string.IsNullOrEmpty(OC3txt.Text) ? 0 : int.Parse(OC3txt.Text);
            line.Center = player;

            // Save 3rd line Right Wing
            player = new Player();
            player.Name = RW3txt.Text;
            player.Overall = string.IsNullOrEmpty(ORW3txt.Text) ? 0 : int.Parse(ORW3txt.Text);
            line.RightWing = player;

            // Save 3rd pair Left Def
            player = new Player();
            player.Name = LD3txt.Text;
            player.Overall = string.IsNullOrEmpty(OLD3txt.Text) ? 0 : int.Parse(OLD3txt.Text);
            line.LeftDefence = player;

            // Save 3rd pair Right Def
            player = new Player();
            player.Name = RD3txt.Text;
            player.Overall = string.IsNullOrEmpty(ORD3txt.Text) ? 0 : int.Parse(ORD3txt.Text);
            line.RightDefence = player;

            team.ESL[2] = line;

            //--------------------------------------------  4th Line / 4th Pairing  --------------------------------------------
            line = new EvenStrengthLines();
            line.Line = 4;

            // Save 4th line Left Wing
            player = new Player();
            player.Name = LW4txt.Text;
            player.Overall = string.IsNullOrEmpty(OLW4txt.Text) ? 0 : int.Parse(OLW4txt.Text);
            line.LeftWing = player;

            // Save 4th line Center
            player = new Player();
            player.Name = C4txt.Text;
            player.Overall = string.IsNullOrEmpty(OC4txt.Text) ? 0 : int.Parse(OC4txt.Text);
            line.Center = player;

            // Save 4th line Right Wing
            player = new Player();
            player.Name = RW4txt.Text;
            player.Overall = string.IsNullOrEmpty(ORW4txt.Text) ? 0 : int.Parse(ORW4txt.Text);
            line.RightWing = player;

            team.ESL[3] = line;

            //--------------------------------------------  Scratched  --------------------------------------------
            line = new EvenStrengthLines();
            line.Line = 5;

            // Save 5th line Left Wing
            player = new Player();
            player.Name = LW5txt.Text;
            player.Overall = string.IsNullOrEmpty(OLW5txt.Text) ? 0 : int.Parse(OLW5txt.Text);
            line.LeftWing = player;

            // Save 5th line Center
            player = new Player();
            player.Name = C5txt.Text;
            player.Overall = string.IsNullOrEmpty(OC5txt.Text) ? 0 : int.Parse(OC5txt.Text);
            line.Center = player;

            // Save 5th line Right Wing
            player = new Player();
            player.Name = RW5txt.Text;
            player.Overall = string.IsNullOrEmpty(ORW5txt.Text) ? 0 : int.Parse(ORW5txt.Text);
            line.RightWing = player;

            // Save 4th pair Left Def
            player = new Player();
            player.Name = LD4txt.Text;
            player.Overall = string.IsNullOrEmpty(OLD4txt.Text) ? 0 : int.Parse(OLD4txt.Text);
            line.LeftDefence = player;

            // Save 4th pair Right Def
            player = new Player();
            player.Name = RD4txt.Text;
            player.Overall = string.IsNullOrEmpty(ORD4txt.Text) ? 0 : int.Parse(ORD4txt.Text);
            line.RightDefence = player;

            team.ESL[4] = line;

            //--------------------------------------------  Goalies  --------------------------------------------
            Goalies goalies = new Goalies();

            // Save Starting goalie
            player = new Player();
            player.Name = G1txt.Text;
            player.Overall = string.IsNullOrEmpty(OG1txt.Text) ? 0 : int.Parse(OG1txt.Text);
            goalies.Starter = player;

            // Save Backup goalie
            player = new Player();
            player.Name = G2txt.Text;
            player.Overall = string.IsNullOrEmpty(OG2txt.Text) ? 0 : int.Parse(OG2txt.Text);
            goalies.Backup = player;

            // Save Third String goalie
            player = new Player();
            player.Name = G3txt.Text;
            player.Overall = string.IsNullOrEmpty(OG3txt.Text) ? 0 : int.Parse(OG3txt.Text);
            goalies.ThirdString = player;

            team.Goalies = goalies;

            NHLteam.AHLLines = team;

            Methods.Add(Methods.GetCurrentYear(), NHLteam);
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            NHLTeam NHLteam = Methods.SelectCurrent<NHLTeam>();
            AHLTeam team = NHLteam.AHLLines != null ? NHLteam.AHLLines : new AHLTeam();

            Recordtb.Text = team.Record;
            Playofftb.Text = team.Playoff;

            foreach (EvenStrengthLines line in team.ESL)
            {
                int unit = line.Line;
                switch (unit)
                {
                    case 1:
                        LW1txt.Text = line.LeftWing.Name;
                        OLW1txt.Text = line.LeftWing.Overall.ToString();
                        C1txt.Text = line.Center.Name;
                        OC1txt.Text = line.Center.Overall.ToString();
                        RW1txt.Text = line.RightWing.Name;
                        ORW1txt.Text = line.RightWing.Overall.ToString();
                        LD1txt.Text = line.LeftDefence.Name;
                        OLD1txt.Text = line.LeftDefence.Overall.ToString();
                        RD1txt.Text = line.RightDefence.Name;
                        ORD1txt.Text = line.RightDefence.Overall.ToString();
                        break;
                    case 2:
                        LW2txt.Text = line.LeftWing.Name;
                        OLW2txt.Text = line.LeftWing.Overall.ToString();
                        C2txt.Text = line.Center.Name;
                        OC2txt.Text = line.Center.Overall.ToString();
                        RW2txt.Text = line.RightWing.Name;
                        ORW2txt.Text = line.RightWing.Overall.ToString();
                        LD2txt.Text = line.LeftDefence.Name;
                        OLD2txt.Text = line.LeftDefence.Overall.ToString();
                        RD2txt.Text = line.RightDefence.Name;
                        ORD2txt.Text = line.RightDefence.Overall.ToString();
                        break;
                    case 3:
                        LW3txt.Text = line.LeftWing.Name;
                        OLW3txt.Text = line.LeftWing.Overall.ToString();
                        C3txt.Text = line.Center.Name;
                        OC3txt.Text = line.Center.Overall.ToString();
                        RW3txt.Text = line.RightWing.Name;
                        ORW3txt.Text = line.RightWing.Overall.ToString();
                        LD3txt.Text = line.LeftDefence.Name;
                        OLD3txt.Text = line.LeftDefence.Overall.ToString();
                        RD3txt.Text = line.RightDefence.Name;
                        ORD3txt.Text = line.RightDefence.Overall.ToString();
                        break;
                    case 4:
                        LW4txt.Text = line.LeftWing.Name;
                        OLW4txt.Text = line.LeftWing.Overall.ToString();
                        C4txt.Text = line.Center.Name;
                        OC4txt.Text = line.Center.Overall.ToString();
                        RW4txt.Text = line.RightWing.Name;
                        ORW4txt.Text = line.RightWing.Overall.ToString();
                        break;
                    case 5:
                        LW5txt.Text = line.LeftWing.Name;
                        OLW5txt.Text = line.LeftWing.Overall.ToString();
                        C5txt.Text = line.Center.Name;
                        OC5txt.Text = line.Center.Overall.ToString();
                        RW5txt.Text = line.RightWing.Name;
                        ORW5txt.Text = line.RightWing.Overall.ToString();
                        LD4txt.Text = line.LeftDefence.Name;
                        OLD4txt.Text = line.LeftDefence.Overall.ToString();
                        RD4txt.Text = line.RightDefence.Name;
                        ORD4txt.Text = line.RightDefence.Overall.ToString();
                        break;
                }
            }

            G1txt.Text = team.Goalies.Starter.Name;
            OG1txt.Text = team.Goalies.Starter.Overall.ToString();
            G2txt.Text = team.Goalies.Backup.Name;
            OG2txt.Text = team.Goalies.Backup.Overall.ToString();
            G3txt.Text = team.Goalies.ThirdString.Name;
            OG3txt.Text = team.Goalies.ThirdString.Overall.ToString();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            // Clear Left Wings
            LW1txt.Text = "";
            OLW1txt.Text = "";
            LW2txt.Text = "";
            OLW2txt.Text = "";
            LW3txt.Text = "";
            OLW3txt.Text = "";
            LW4txt.Text = "";
            OLW4txt.Text = "";
            LW5txt.Text = "";
            OLW5txt.Text = "";

            // Clear Centers
            C1txt.Text = "";
            OC1txt.Text = "";
            C2txt.Text = "";
            OC2txt.Text = "";
            C3txt.Text = "";
            OC3txt.Text = "";
            C4txt.Text = "";
            OC4txt.Text = "";
            C5txt.Text = "";
            OC5txt.Text = "";

            // Clear Right Wings
            RW1txt.Text = "";
            ORW1txt.Text = "";
            RW2txt.Text = "";
            ORW2txt.Text = "";
            RW3txt.Text = "";
            ORW3txt.Text = "";
            RW4txt.Text = "";
            ORW4txt.Text = "";
            RW5txt.Text = "";
            ORW5txt.Text = "";

            // Clear Left Defence
            LD1txt.Text = "";
            OLD1txt.Text = "";
            LD2txt.Text = "";
            OLD2txt.Text = "";
            LD3txt.Text = "";
            OLD3txt.Text = "";
            LD4txt.Text = "";
            OLD4txt.Text = "";

            // Clear Right Defence
            RD1txt.Text = "";
            ORD1txt.Text = "";
            RD2txt.Text = "";
            ORD2txt.Text = "";
            RD3txt.Text = "";
            ORD3txt.Text = "";
            RD4txt.Text = "";
            ORD4txt.Text = "";

            // Goalies
            G1txt.Text = "";
            OG1txt.Text = "";
            G2txt.Text = "";
            OG2txt.Text = "";
            G3txt.Text = "";
            OG3txt.Text = "";
        }

        #endregion Buttons
    }
}
