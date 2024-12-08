using Tyuiu.PredygerKK.Sprint6.Task5.V12.Lib;

namespace Tyuiu.PredygerKK.Sprint6.Task5.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask5V12.txt");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void HelpButton_PKK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� ������� ������ ����-24-1 �������� ������ ��������������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SolveButton_PKK_Click(object sender, EventArgs e)
        {
            this.ChartFunctionResultVisual_PKK.ChartAreas[0].AxisX.Title = "��� X";
            this.ChartFunctionResultVisual_PKK.ChartAreas[0].AxisY.Title = "��� Y";

            ChartFunctionResultVisual_PKK.Series[0].Points.Clear();

            double[] ValuesArray = new double[ds.len];
            ValuesArray = ds.LoadFromDataFile(path);

            for(int i = 0; i < ValuesArray.Length; i++)
            {
                OutputBox_PKK.AppendText(ValuesArray[i] + Environment.NewLine);
                ChartFunctionResultVisual_PKK.Series[0].Points.AddXY(i, ValuesArray[i]);
            }
        }

        private void OpenFileButton_PKK_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("�� ������� ����� ���� InPutDataFileTask5V12.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SolveButton_PKK_MouseEnter(object sender, EventArgs e)
        {
            SolveButton_PKK.BackColor = Color.Green;
        }

        private void SolveButton_PKK_MouseLeave(object sender, EventArgs e)
        {
            SolveButton_PKK.BackColor = Color.PaleGreen;
        }
    }
}
