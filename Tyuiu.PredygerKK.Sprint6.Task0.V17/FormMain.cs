using Tyuiu.PredygerKK.Sprint6.Task0.V17.Lib;

namespace Tyuiu.PredygerKK.Sprint6.Task0.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void SolveButton_PKK_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                TextBoxResult_PKK.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(TextBoxInPut_PKK.Text)));
            }
            catch
            {
                MessageBox.Show("���������� - ������ ����� �����!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxInPut_PKK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void ButtonHelp_PKK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ ����-24-1 �������� ������ ��������������", "���������");
        }

        private void TextBoxResult_PKK_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
