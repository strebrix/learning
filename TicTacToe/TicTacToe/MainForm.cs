namespace TicTacToe
{
    public partial class MainForm : Form
    {
        private bool enableAI = false;

        public MainForm()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
        }

        private void aIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aIToolStripMenuItem.Checked)
            {
                aIToolStripMenuItem.Checked = false;
                enableAI = false;
            }
            else
            {
                aIToolStripMenuItem.Checked = true;
                enableAI = true;
            }
        }

        private void helpStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutMessageBox box = new AboutMessageBox();
            box.Show();
        }

        private void startstopStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controller.switchGameState();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        #region[Localization]
        private void polishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pl");
            InitializeComponent();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
        }
        #endregion
    }
}