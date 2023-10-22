namespace TicTacToe
{
    public partial class MainForm : Form
    {
        private bool enableAI = false;

        public MainForm() { InitializeComponent(); }

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
    }
}