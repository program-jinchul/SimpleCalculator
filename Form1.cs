namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int num1 = 0;      // 첫 번째 숫자 저장
        string op = "";    // 연산자 저장
        bool isOperatorClicked = false; // 연산자 눌렀는지 체크
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0) // 글자가 있을 때만 실행
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                // 마지막 글자 하나 제거
            }
            if (txtExpression.Text.Length > 0)
                txtExpression.Text = txtExpression.Text.Substring(0, txtExpression.Text.Length - 1);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            num1 = int.Parse(txtDisplay.Text); // 첫 번째 숫자 저장
            op = btn.Text; // ⭐ 버튼에 적힌 연산자 가져오기 (+ - * /)

            txtExpression.Text += " " + op + " "; // 수식에 연산자 추가
            
            isOperatorClicked = true;            // 다음 입력은 새 숫자
        }

        private void txtExpression_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text)) return;

            int num2 = int.Parse(txtDisplay.Text); // 두번째 숫자 가져오기
            int result = 0;

            if (op == "+") result = num1 + num2;
            else if (op == "-") result = num1 - num2;
            else if (op == "*" || op == "X") result = num1 * num2;
            else if (op == "/" || op == "÷") result = num1 / num2;

            txtDisplay.Text = result.ToString(); // 결과를 텍스트박스에 표시
            txtExpression.Text += " = " + result;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (isOperatorClicked)
            {
                txtDisplay.Text = "";   // 새 숫자 시작
                isOperatorClicked = false;
            }

            txtDisplay.Text += btn.Text;        // 아래
            txtExpression.Text += btn.Text;     // 위
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();   // 현재 입력값 삭제
            txtExpression.Clear(); // 위도 같이 초기화
            num1 = 0;             // 저장된 첫 번째 숫자 초기화
            op = "";              // 연산자 초기화
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();   // 현재 입력값만 삭제
        }
    }
}
