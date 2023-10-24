namespace TicTacToe
{
    public partial class MainForm : Form
    {
        private bool enableAI = false;

        public MainForm()
        {
            InitializeComponent();
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
            Presenter.switchGameState();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void board_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString() + "|" + e.ToString);
        }
    }
}