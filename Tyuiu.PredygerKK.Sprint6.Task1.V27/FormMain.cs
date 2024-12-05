using Tyuiu.PredygerKK.Sprint6.Task1.V27.Lib;

namespace Tyuiu.PredygerKK.Sprint6.Task1.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void StopField_PKK_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartField_PKK_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SolveButton_PKK_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(StartField_PKK.Text);
                int stopValue = Convert.ToInt32(StopField_PKK.Text);

                string str;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] TempArray;
                TempArray = new double[len];

                TempArray = ds.GetMassFunction(startValue, stopValue);
                ResultBox_PKK.Text = "";
                ResultBox_PKK.AppendText("+----------+----------+" + Environment.NewLine);
                ResultBox_PKK.AppendText(" |       X       |       f(x)    |" + Environment.NewLine);
                ResultBox_PKK.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format(" |{0,5:d}           | {1,6 :f2}     |", startValue, TempArray[i]);
                    ResultBox_PKK.AppendText(str + Environment.NewLine);
                    startValue++;
                }
                ResultBox_PKK.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonHelp_PKK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ПКТб-24-1 Предыгер Кирилл Константинович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}