using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01HelloCSharpWin
{
    public enum Operators { Add, Sub, Multi, Div }
    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;
        // isNewNum - true면 새로운 숫자를 화면에 표시
        // isNewNum - flase면 더한 

        public Operators Opt = Operators.Add;

        public Calculator()
        {
            InitializeComponent();
        }

        /*steamedrice Cook(rice, water) // 밥을 하는 함수
            // 함수의 프로토 타입
        {
        
        }*/

        // 더하기 함수의 프로토 타입
        public int Add(int number1, int number2) 
        {
            int sum = number1 + number2;
            // return : 결과물을 만들어 내는 키워드
            return sum;
        }

        // 함수의 오버로딩
        public float Add(float number1, float number2) 
        { 
            float sum = number1 + number2;
            return sum;
        }

        public int Sub(int number1, int number2) 
        { 
            int sub = number1 - number2;
            return sub;
        }

        private void NumButton1_Click(object sender, EventArgs e)
        {
            Button NumButton = (Button)sender;
            SetNum(NumButton.Text);
        }

        public void SetNum(string num) 
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }
        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            { 
                int num = int.Parse(NumScreen.Text);
                if (Opt == Operators.Add) 
                    Result = Add(Result, num);
                else if (Opt == Operators.Sub)
                    Result = Sub(Result, num);
            
                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }
            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }

        // 변수 = 0
        // 연산자 = +

        // 숫자 입력
        // 연산자 버튼 - 숫자 완성, 변수와 숫자를 저장된 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장.
        // 숫자 입력
        // 연산자 버튼 - 숫자 완성, 변수와 숫자를 저장된 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장.

    }
}
