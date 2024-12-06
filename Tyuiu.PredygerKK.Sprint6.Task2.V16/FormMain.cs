using Tyuiu.PredygerKK.Sprint6.Task2.V16.Lib;

namespace Tyuiu.PredygerKK.Sprint6.Task2.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void SolveButton_PKK_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(InPutFieldStart_PKK.Text);
                int stopValue = Convert.ToInt32(InPutFieldStop_PKK.Text);

                string str;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] TempArray;
                TempArray = new double[len];

                TempArray = ds.GetMassFunction(startValue, stopValue);

                this.ChartFunction_PKK.Titles.Add($"График функии на отрезке [{startValue};{stopValue}]");

                this.ChartFunction_PKK.ChartAreas[0].AxisX.Title = "Ось X";
                this.ChartFunction_PKK.ChartAreas[0].AxisX.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.DataGridViewFunction_PKK.Rows.Add(Convert.ToString(startValue), Convert.ToString(TempArray[i]));
                    this.ChartFunction_PKK.Series[0].Points.AddXY(startValue, TempArray[i]);

                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HelpButton_PKK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ПКТб-24-1 Предыгер Кирилл Константинович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DataGridViewFuction_PKK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SolveButton_PKK_MouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            SolveButton_PKK.BackColor = Color.Green;
        }

        private void HelpButton_PKK_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ПКТб-24-1 Предыгер Кирилл Константинович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
