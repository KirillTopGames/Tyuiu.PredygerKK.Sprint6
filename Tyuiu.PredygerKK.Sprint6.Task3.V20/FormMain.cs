using Tyuiu.PredygerKK.Sprint6.Task3.V20.Lib;

namespace Tyuiu.PredygerKK.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void DataGridViewFunction_PKK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -14, 17, -19, 3, 2 },
                                       { -4, -14, -19, -9, -1 },
                                       { 1, 0, 13, 14, 8 },
                                       { 13, 7, 8, -3, -15 },
                                       { 2, -20, 12, -14, 4 }, };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            DataGridViewFunction_PKK.RowCount = rows;
            DataGridViewFunction_PKK.ColumnCount = columns;


            for (int i = 0; i < columns; i++)
            {
                DataGridViewFunction_PKK.Columns[i].Width = 40;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    DataGridViewFunction_PKK.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void SolveButton_PKK_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[5, 5] { { -14, 17, -19, 3, 2 },
                                       { -4, -14, -19, -9, -1 },
                                       { 1, 0, 13, 14, 8 },
                                       { 13, 7, 8, -3, -15 },
                                       { 2, -20, 12, -14, 4 }, };

            try
            {

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        this.DataGridViewResult_PKK.Rows.Add(Convert.ToString(matrix[i,j]));
                    }
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
    }
}
