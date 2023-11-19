namespace Openfiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Menuexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult)
            {
                Application.Exit();
            }
        }

        private void Menucut_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void undoMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
                richTextBox1.ClearUndo();
            }
        }

        private void viewTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Enabled == true)
            {
                richTextBox1.Visible = true;
            }
            else
            {
                richTextBox1.Visible = false;
            }
        }

        private void Menuopen_Click(object sender, EventArgs e)
        {
            String openfile;
            openFileDialog1.ShowDialog(this);
            openFileDialog1.Filter = "Text Files|*.txt|Word Documents|*.doc";
            openfile = openFileDialog1.FileName;
            if (openfile != null) 
            {
                richTextBox1.LoadFile(openfile,RichTextBoxStreamType.PlainText);
            
            }
        }
    }
}