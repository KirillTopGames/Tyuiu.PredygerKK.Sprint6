using Tyuiu.PredygerKK.Sprint6.Task6.V13.Lib;

namespace Tyuiu.PredygerKK.Sprint6.Task6.V13
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path;
        public FormMain()
        {
            InitializeComponent();
        }

        private void SolveButton_PKK_Click(object sender, EventArgs e)
        {

            textBoxOut.Text = ds.CollectTextFromFile(path);
        }

        private void HelpButton_PKK_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void OpenFileButton_PKK_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            path = openFileDialogTask.FileName;
            textBoxIn.Text = File.ReadAllText(path);
            InputGroupBox_PKK.Text += openFileDialogTask.FileName;
            SolveButton_PKK.Enabled = true;
        }
    }
}
