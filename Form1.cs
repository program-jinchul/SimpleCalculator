namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int num1 = 0;      // 첫 번째 숫자 저장
        string op = "";    // 연산자 저장
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtDisplay.Text); // string → int 변환
            op = "+";
            txtDisplay.Clear();
        }

        private void txtExpression_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int num2 = int.Parse(txtDisplay.Text); // 두 번째 숫자

            int result = 0;

            if (op == "+")
                result = num1 + num2;

            txtDisplay.Text = result.ToString(); // int → string 변환
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            num1 = 0;
            op = "";
        }
    }
}
