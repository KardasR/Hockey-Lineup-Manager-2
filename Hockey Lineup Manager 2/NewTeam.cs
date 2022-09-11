namespace Hockey_Lineup_Manager_2
{
    public partial class NewTeam : Form
    {
        public NewTeam()
        {
            InitializeComponent();
        }

        private bool ActionTaken = false;

        /// <summary>
        /// Load form onto my vertical screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewTeam_Load(object sender, EventArgs e)
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
                        break;
                    }
                }
                // Change the window to the vertical monitor
                Location = monitor.Location;
            }
        }

        private void NewTeam_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!ActionTaken)
                Application.Exit();
        }

        /// <summary>
        /// Load Even Strength form and pass user input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateTeambtn_Click(object sender, EventArgs e)
        {
            new ESform(NHLtb.Text, AHLtb.Text, Starttb.Text).Show();
            ActionTaken = true;
            this.Close();
        }
    }
}
