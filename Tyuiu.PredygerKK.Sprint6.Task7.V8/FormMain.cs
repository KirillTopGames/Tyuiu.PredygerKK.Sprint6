using System.Drawing.Drawing2D;
using System.Security.AccessControl;
using Tyuiu.PredygerKK.Sprint6.Task7.V8.Lib;

namespace Tyuiu.PredygerKK.Sprint6.Task7.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_PKK.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_PKK.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows, columns;
        static string path;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string path)
        {
            string[] file = File.ReadAllLines(path);

            columns = file[0].Split(";").Length;
            rows = file.Length;

            int[,] matrix = new int[columns, rows];

            for (int i = 0; i < file.Length; i++)
            {

                string[] digits = file[i].Split(";");
                for (int j = 0; j < digits.Length; j++)
                {
                    int digit = Convert.ToInt32(digits[j]);
                    matrix[i, j] = digit;
                }
            }
            return matrix;
        }

        private void OpenFileButton_PKK_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
            OpenFileButton_PKK.BackColor = Color.PaleGoldenrod;
        }

        private void OpenFileButton_PKK_MouseLeave(object sender, EventArgs e)
        {
            OpenFileButton_PKK.BackColor = Color.LemonChiffon;
        }
        private void OpenFileButton_PKK_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PKK.ShowDialog();
            path = openFileDialogTask_PKK.FileName;

            int[,] matrix = new int[rows, columns];
            matrix = LoadFromFileData(path);

            dataGridInput_PKK.ColumnCount = columns;
            dataGridInput_PKK.RowCount = rows;
            dataGridOutput_PKK.ColumnCount = columns;
            dataGridOutput_PKK.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridInput_PKK.Columns[i].Width = 35;
                dataGridOutput_PKK.Columns[i].Width = 35;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridInput_PKK.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }

            matrix = ds.GetMatrix(path);
            SolveButton_PKK.Enabled = true;
        }

        private void SaveFileButton_PKK_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить файл";
            SaveFileButton_PKK.BackColor = Color.RoyalBlue;
        }
        private void SaveFileButton_PKK_MouseLeave(object sender, EventArgs e)
        {
            SaveFileButton_PKK.BackColor = Color.CornflowerBlue;
        }
        private void SaveFileButton_PKK_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PKK.FileName = "OutPutDataFileTask7V8.csv";
            saveFileDialogMatrix_PKK.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PKK.ShowDialog();

            string path = saveFileDialogMatrix_PKK.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if(fileExist)
            {
                File.Delete(path);
            }

            int rows = dataGridOutput_PKK.RowCount;
            int columns = dataGridOutput_PKK.ColumnCount;

            string str = "";

            for(int i = 0;  i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if(j != columns - 1)
                    {
                        str += dataGridOutput_PKK.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridOutput_PKK.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }


        }
        private void HelpButton_PKK_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Информация";
            HelpButton_PKK.BackColor = SystemColors.Control;
        }

        private void HelpButton_PKK_MouseLeave(object sender, EventArgs e)
        {
            HelpButton_PKK.BackColor = Color.White;
        }
        private void HelpButton_PKK_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void SolveButton_PKK_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Запустить";
            SolveButton_PKK.BackColor = Color.LightGreen;
        }
        private void SolveButton_PKK_MouseLeave(object sender, EventArgs e)
        {
            SolveButton_PKK.BackColor = Color.PaleGreen;
        }
        private void SolveButton_PKK_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[rows, columns];
            matrix = ds.GetMatrix(path);

            for(int r = 0; r < rows; r++)
            {
                for(int c = 0; c < columns; c++)
                {
                    dataGridOutput_PKK.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }

            SaveFileButton_PKK.Enabled = true;
        }
    }
}
