using System.IO;
using System.Text.Json;

namespace Hockey_Lineup_Manager_2
{
    public partial class MainMenu : Form
    {
        #region Constructors

        public MainMenu()
        {
            InitializeComponent();
        }

        #endregion Constructors

        private bool actionTaken = false;

        #region Events

        /// <summary>
        /// Load form onto my vertical screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Load(object sender, EventArgs e)
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
        }

        /// <summary>
        /// If the user closes the form before creating/loading a team, make sure the application exits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!actionTaken)
                Application.Exit();
        }

        #endregion Events

        #region Buttons

        /// <summary>
        /// Open a NewTeam form, then close this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewTeambtn_Click(object sender, EventArgs e)
        {
            new NewTeam().Show();
            actionTaken = true;
            this.Close();
        }

        /// <summary>
        /// Load an franchise from a team file, then open an EvenStrength form with the given organiztion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectTeambtn_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Rosters\\";
                ofd.Filter = "Team files (*.team)|*.team";

                try
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (var sr = new StreamReader(ofd.FileName))
                        {
                            fileContent = sr.ReadToEnd();
                        }
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    string title = "File Load Fail";
                    MessageBox.Show(message, title);
                }
            }
            if (fileContent != "")
            {
                Dictionary<string, NHLTeam> org = JsonSerializer.Deserialize<Dictionary<string, NHLTeam>>(fileContent);

                foreach (var team in org)
                {
                    // Check if the year is already in the dictionary before adding the team.
                    if (!Methods.SetCurrent(team.Key))
                        Methods.Add(team.Key, team.Value);
                }

                new ESform(org).Show();
                actionTaken = true;
                this.Close();
            }
        }

        #endregion Buttons
    }
}