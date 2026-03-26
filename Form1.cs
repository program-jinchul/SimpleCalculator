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
            Button btn = sender as Button;

            num1 = int.Parse(txtDisplay.Text); // 첫 번째 숫자 저장
            op = btn.Text; // ⭐ 버튼에 적힌 연산자 가져오기 (+ - * /)
            txtDisplay.Clear(); // 다음 숫자 입력 준비
        }

        private void txtExpression_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int num2 = int.Parse(txtDisplay.Text); // 두번째 숫자 가져오기
            int result = 0;

            if (op == "+") result = num1 + num2;
            else if (op == "-") result = num1 - num2;
            else if (op == "*") result = num1 * num2;
            else if (op == "/") result = num1 / num2;

            txtDisplay.Text = result.ToString(); // 결과를 텍스트박스에 표시
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();   // 현재 입력값 삭제
            num1 = 0;             // 저장된 첫 번째 숫자 초기화
            op = "";              // 연산자 초기화
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();   // 현재 입력값만 삭제
        }
    }
}
