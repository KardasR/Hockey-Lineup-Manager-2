using DevExpress.XtraEditors;
using System.IO;
using System.Text.Json;

namespace Hockey_Lineup_Manager_2
{
    public partial class ESform : Form
    {
        #region Constructors

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ESform()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for loading a franchise.
        /// </summary>
        /// <param name="org">franchise to load</param>
        public ESform(Dictionary<string, NHLTeam> org)
        {
            InitializeComponent();
            
            TeamNamelbl.Text = org.First().Value.Name;
            AHLlbl.Text = org.First().Value.AHLLines.Name;
            Yearlb.Items.Add(org.First().Key);
            Methods.SetCurrent(org.First().Key);
            Methods.GiveHistory(org);
            NewTeam = false;
        }

        /// <summary>
        /// Constructor for creating a franchise.
        /// </summary>
        /// <param name="NHLname">NHL team name of franchise</param>
        /// <param name="AHLname">AHL team name of franchise</param>
        /// <param name="Startyear">Starting year of franchise</param>
        public ESform(string NHLname, string AHLname, string Startyear)
        {
            InitializeComponent();

            TeamNamelbl.Text = NHLname;
            AHLlbl.Text = AHLname;
            Yearlb.Items.Add(Startyear);
            Methods.SetCurrent(Startyear);
            NewTeam = true;
        }

        #endregion Constructors

        private bool NewTeam;

        #region Events

        private void ESform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ESform_Load(object sender, EventArgs e)
        {
            // Set the screen to the monitor that is sideways for me
            if (Screen.AllScreens.Length >= 1)
            {
                Rectangle monitor = Screen.PrimaryScreen.WorkingArea;
                foreach (Screen screen in Screen.AllScreens)
                {
                    if (screen.Bounds.Width.Equals(1050))
                    {
                        monitor = screen.WorkingArea;
                        break;
                    }
                }
                // Change the window to the vertical monitor
                Location = monitor.Location;
            }

            // Load the lines and set the year listbox to the most recent year, then load the latest lines
            Loadbtn.PerformClick();
            Yearlb.SelectedIndex = Yearlb.Items.Count - 1;
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

        private void PPbtn_Click(object sender, EventArgs e)
        {
            Methods.SetCurrent(Yearlb.SelectedItem.ToString());
            new PPform().Show();
        }

        private void PKbtn_Click(object sender, EventArgs e)
        {
            Methods.SetCurrent(Yearlb.SelectedItem.ToString());
            new PKform().Show();
        }

        private void FFbtn_Click(object sender, EventArgs e)
        {
            Methods.SetCurrent(Yearlb.SelectedItem.ToString());
            new FFform().Show();
        }

        private void TTbtn_Click(object sender, EventArgs e)
        {
            Methods.SetCurrent(Yearlb.SelectedItem.ToString());
            new TTform().Show();
        }

        private void SOEAbtn_Click(object sender, EventArgs e)
        {
            Methods.SetCurrent(Yearlb.SelectedItem.ToString());
            new SOEAform().Show();
        }

        private void Yearbtn_Click(object sender, EventArgs e)
        {
            // Parse the textbox for the latest year, increase it and add it to the listbox.
            Yearlb.Items.Add(string.Format("{0}-{1}", int.Parse(Yearlb.Items[Yearlb.Items.Count - 1].ToString().Substring(5)), int.Parse(Yearlb.Items[Yearlb.Items.Count - 1].ToString().Substring(5)) + 1));                   // Add the new season string to the listbox
            Yearlb.SelectedItem = Yearlb.Items[Yearlb.Items.Count - 1];
            Methods.SetCurrent(Yearlb.SelectedItem.ToString());
            // Clear some textboxes of old data
            Recordtb.Text = "";
            Playofftb.Text = "";
        }

        private void AHLbtn_Click(object sender, EventArgs e)
        {
            Methods.SetCurrent(Yearlb.SelectedItem.ToString());
            new AHLform(AHLlbl.Text).Show();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            NHLTeam team = Methods.SelectCurrent<NHLTeam>();

            team.Name = TeamNamelbl.Text;
            if (team.AHLLines == null)
                team.AHLLines = new AHLTeam();

            team.AHLLines.Name = AHLlbl.Text;
            team.Record = Recordtb.Text;
            team.Playoff = Playofftb.Text;

            EvenStrengthLines line = new EvenStrengthLines();

            //--------------------------------------------  1st Line / 1st Pairing  --------------------------------------------
            line.Line = 1;

            // Save 1st line Left Wing
            Player player = new Player();
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

            team.Goalies = goalies;

            //--------------------------------------------  Other  --------------------------------------------
            Methods.Add(Yearlb.SelectedItem.ToString(), team);
            Methods.SetCurrent(Yearlb.SelectedItem.ToString());

            // Save the franchise
            using (StreamWriter file = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ("\\Rosters\\" + TeamNamelbl.Text + ".team")))
            {
                string jsonstring = JsonSerializer.Serialize(Methods.GetHistory<Dictionary<string, NHLTeam>>());
                file.Write(jsonstring);
            }

            NewTeam = false;
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            string nhlTeamName = TeamNamelbl.Text;
            string fileContent = string.Empty;
            Dictionary<string, NHLTeam> org = new Dictionary<string, NHLTeam>();

            try
            {
                using (var sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Rosters\\" + nhlTeamName + ".team"))
                {
                    fileContent = sr.ReadToEnd();
                }

                org = JsonSerializer.Deserialize<Dictionary<string, NHLTeam>>(fileContent);
            }
            catch
            {
                //Yearlb.ClearSelected();
            }

            foreach (var season in org)
            {
                // Check if year is not already in the year listbox before adding the year to the listbox
                if (Yearlb.FindString(season.Key) == ListBox.NoMatches)
                    Yearlb.Items.Add(season.Key);

                // Check if year is not already in the dictionary before adding the team to the franchise
                if (!Methods.SetCurrent(season.Key))
                    Methods.Add(season.Key, season.Value);
            }

            if (Yearlb.SelectedItem != null)
                Methods.SetCurrent(Yearlb.SelectedItem.ToString());
            else
                Methods.SetCurrent(Yearlb.Items[0].ToString());

            NHLTeam team = Methods.SelectCurrent<NHLTeam>();

            // This is here only because I call this function on form load
            if (!NewTeam)
            {
                Recordtb.Text = team.Record;
                Playofftb.Text = team.Playoff;

                // Clear Left Wings
                LW1txt.Text = team.ESL[0].LeftWing.Name;
                OLW1txt.Text = team.ESL[0].LeftWing.Overall.ToString();
                LW2txt.Text = team.ESL[1].LeftWing.Name;
                OLW2txt.Text = team.ESL[1].LeftWing.Overall.ToString();
                LW3txt.Text = team.ESL[2].LeftWing.Name;
                OLW3txt.Text = team.ESL[2].LeftWing.Overall.ToString();
                LW4txt.Text = team.ESL[3].LeftWing.Name;
                OLW4txt.Text = team.ESL[3].LeftWing.Overall.ToString();
                LW5txt.Text = team.ESL[4].LeftWing.Name;
                OLW5txt.Text = team.ESL[4].LeftWing.Overall.ToString();

                // Clear Centers
                C1txt.Text = team.ESL[0].Center.Name;
                OC1txt.Text = team.ESL[0].Center.Overall.ToString();
                C2txt.Text = team.ESL[1].Center.Name;
                OC2txt.Text = team.ESL[1].Center.Overall.ToString();
                C3txt.Text = team.ESL[2].Center.Name;
                OC3txt.Text = team.ESL[2].Center.Overall.ToString();
                C4txt.Text = team.ESL[3].Center.Name;
                OC4txt.Text = team.ESL[3].Center.Overall.ToString();
                C5txt.Text = team.ESL[4].Center.Name;
                OC5txt.Text = team.ESL[4].Center.Overall.ToString();

                // Clear Right Wings
                RW1txt.Text = team.ESL[0].RightWing.Name;
                ORW1txt.Text = team.ESL[0].RightWing.Overall.ToString();
                RW2txt.Text = team.ESL[1].RightWing.Name;
                ORW2txt.Text = team.ESL[1].RightWing.Overall.ToString();
                RW3txt.Text = team.ESL[2].RightWing.Name;
                ORW3txt.Text = team.ESL[2].RightWing.Overall.ToString();
                RW4txt.Text = team.ESL[3].RightWing.Name;
                ORW4txt.Text = team.ESL[3].RightWing.Overall.ToString();
                RW5txt.Text = team.ESL[4].RightWing.Name;
                ORW5txt.Text = team.ESL[4].RightWing.Overall.ToString();

                // Clear Left Defence
                LD1txt.Text = team.ESL[0].LeftDefence.Name;
                OLD1txt.Text = team.ESL[0].LeftDefence.Overall.ToString();
                LD2txt.Text = team.ESL[1].LeftDefence.Name;
                OLD2txt.Text = team.ESL[1].LeftDefence.Overall.ToString();
                LD3txt.Text = team.ESL[2].LeftDefence.Name;
                OLD3txt.Text = team.ESL[2].LeftDefence.Overall.ToString();
                LD4txt.Text = team.ESL[4].LeftDefence.Name;
                OLD4txt.Text = team.ESL[4].LeftDefence.Overall.ToString();

                // Clear Right Defence
                RD1txt.Text = team.ESL[0].RightDefence.Name;
                ORD1txt.Text = team.ESL[0].RightDefence.Overall.ToString();
                RD2txt.Text = team.ESL[1].RightDefence.Name;
                ORD2txt.Text = team.ESL[1].RightDefence.Overall.ToString();
                RD3txt.Text = team.ESL[2].RightDefence.Name;
                ORD3txt.Text = team.ESL[2].RightDefence.Overall.ToString();
                RD4txt.Text = team.ESL[4].RightDefence.Name;
                ORD4txt.Text = team.ESL[4].RightDefence.Overall.ToString();

                // Goalies
                G1txt.Text = team.Goalies.Starter.Name;
                OG1txt.Text = team.Goalies.Starter.Overall.ToString();
                G2txt.Text = team.Goalies.Backup.Name;
                OG2txt.Text = team.Goalies.Backup.Overall.ToString();
            }
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
        }

        #endregion Buttons
    }
}
