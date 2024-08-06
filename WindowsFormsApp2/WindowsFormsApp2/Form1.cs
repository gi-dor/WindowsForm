using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("이곳은 메시지박스에 출력될 내용 부분입니다 ,  OK ", "단순 메시지 박스입니다", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes or No , Warning!", "메시지 박스 제목 타이틀 부분입니다", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void mjhf(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBox Information Box ", "메시지 박스 제목", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }



        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                int i = 10;
                int j = 20;

                if (i + j == 50)
                {
                    MessageBox.Show("i의 값과 j의 값의 합이 맞습니다", "알맞은 정답", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("i의 값과 j의 값의 합이 알맞지 않고 있습니다 \r\n" +
                        "i의 값은 10 j의 값은 20 ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "값을 확인해주세요", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
            String str1 = "hello";
            String str2 = "hello";
            var str3 = "Hello";

            try
            {
                if (str1 == str2)
                {
                    MessageBox.Show("str1 == str2 비교", "String 비교 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (str1.Equals(str2))
                {
                    MessageBox.Show("str1.equals(str2)", "String 비교 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (object.Equals(str1, str2))
                {
                    MessageBox.Show("object.Equals(str1,str2) ", "String 비교3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("str1과 str2의 값이 어느 조건에도 일치하지 않습니다");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "다시 확인해주세요", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var intVar = 12;
                var doubleVar = 12.7;
                var floatVar = 12.0f;

                MessageBox.Show($"intVar: {intVar}, doubleVar: {doubleVar}, floatVar: {floatVar}", " 변수값 확인하기", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (intVar == doubleVar && doubleVar == floatVar)
                {
                    MessageBox.Show("intVar == doubleVar && doubleVar == floatVar 의 값이 일치합니다", "int , double , float 비교", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception($"intVar =  {intVar} , doubleVar =  {doubleVar} , floatVar = {floatVar} 의 값이 서로 일치하지 않습니다 ");
                }

            }
            // 왜 여기까지 안오고 else 문에서 끝나지 ?
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "catch 문 메세지 제목", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // var 타입을 사용 - 변수의 자료형을 자동으로 지정해준다
                // 지역변수 lv 로서 메서드 내애서 선언해줘야한다 CV 전역변수는 안된다

                var intVar = 10;
                var doubleVar = 10.1;
                var floatVar = 10.0f;

                if (intVar == doubleVar && doubleVar == floatVar)
                {
                    MessageBox.Show("intVar == doubleVar && doubleVar == floatVar 값 일치", "var - int double float 비교", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (intVar == doubleVar || doubleVar == floatVar)
                {
                    MessageBox.Show("intVar == double || doubleVar == floatVar 값 일치", "var - ||연산자 int double float 비교", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("intVar == doubleVar 와 doubleVar == floatVar 의 값이 불일치", " 불일치 ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Console.WriteLine("예..뭐 intVar == doubleVar || doubleVar == floatVar  일치하지 않은게 있나보죠 뭐..");
                }
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message, "다시 확인하세요 ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Console.WriteLine("finally 로 인한 종료 END");
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {

        }



        private void button9_Click(object sender, EventArgs e)
        {
            // 입력값을 메세지 문으로 띄우기 
            // 정규화? 가 있다면 사용해서 입력하는데 제한주기
            String str;
            str = "입사일 : " + textDate.Text + "\r\n";
            //str = "입사일 : " + textDate.Text;
            // str = "휴대폰 번호 : " + textTel.Text;
            // 사용시 기존에 초기화한 입사일에 대한 정보가 사라지고 휴대폰 번호만 메세지 출력됨
            str += "휴대폰 번호 : " + textTel.Text + "\r\n";
            str += "이름 : " + textName.Text + "\r\n";
            str += "주소 : " + textAddress.Text + "\r\n";

            MessageBox.Show(str);

            // 정규표현식 
            // 0 : 0에서 9 사이의모든 한자리 숫자 필수 입력값  d
            // 9 : 숫자 또는 공백  [\d]?
            // & : 문자 필수 입력
            // C : 문자 선택 입력

        }



        private void textDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // 입력값 설정 
            textDate.Mask = "0000-00-00";

            if (textDate.MaskFull)
            {
                MessageBox.Show("입사 날짜 입력을 완료 하셨습니다");
            }
            else if (textDate.Mask.Length == e.Position)
            {
                MessageBox.Show("빈칸 혹은 잘못 입력하셨습니다", "경고 메세지 제목부분", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("뭔가 잘못된거 같습니다", "경고 메세지 제목부분2", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void textTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            textTel.Mask = "000-0000-0000";

            if (textTel.MaskFull)
            {
                MessageBox.Show("전화번호를 입력을 완료 하셨습니다");
            }
            else if (textTel.Mask.Length == e.Position)
            {
                MessageBox.Show("공백 발생", "공백 경고 메세지", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("빈칸 혹은 잘못 입력하셨습니다", "경고 메세지2", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

            //Regex addressRegex = new Regex(@"[가-힣0-9]");
            //Boolean addressChecker = addressRegex.IsMatch(textAddress.Text);

            //if ( addressChecker == false)
            //{
            //    MessageBox.Show("알맞은 주소의 값이 아닙니다 , 다시 입력해주세요", "주소 경고 메세지1", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            //}
            //else {
            //    MessageBox.Show("주소를 입력 완료하셨습니다", "완료 메세지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }
        // 공백입력시 , 정규표현식 발생 , 지우는 과정에서 다시 또 정규표현식 메세지 발생함
        // 정규 표현식 한글 , 숫자 제대로 적용이 안되는중

        private void textName_TextChanged(object sender, EventArgs e)
        {

            // 이름은 2글자에서 5글자 입력
            Regex nameRegex = new Regex(@"[가-힣]", RegexOptions.Compiled);
            Boolean nameChecker = nameRegex.IsMatch(textName.Text);

            if (nameChecker == false)
            {
                MessageBox.Show("알맞은 이름이 아닙니다 \n영어와 공백이 아닌지 확인해주세요 ", "이름 경고 메세지", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }


        // 잘못입력시 백스페이스를 쓰면서 남아있는 공백때문에 정규표현식이 계속 발생함
        // 정규표현식 한글 제대로 작동 안됨

        private void button10_Click(object sender, EventArgs e)
        {
            if (empNo.Text == "20240805" && empPassword.Text == "zxcv1234")
            {
                MessageBox.Show("로그인 성공!  ", "로그인 완료 메세지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("로그인 실패! \n아이디 혹은 비밀번호를 확인해주세요", "로그인 실패 메세지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void userInfo_TextChanged(object sender, EventArgs e)
        {

        }


        // 폼 시작시 데이터 값 집어 넣기 
        // 집어 넣은 값으로 회원정보 수정 ? 이런거 가능할지도  ?
        private void Form1_Load(object sender, EventArgs e)
        {
            // 맨위 상단 이름
            textBoxName.Text = "한기선";

            // 멀티라인 + 읽기 전용 
            readText.ReadOnly = true;
            readText.Text = "이름 : 한기선 \r\n";
            readText.Text += "주소 : 덕소로 270 \r\n";
            readText.Text += "입사일 : 2024.08.05 \r\n";
            readText.Text += "생년월일 : 940120";


            // 입력 하기
            anotherInfo.Text = "=========  기본 정보1 ======== \r\n";
            anotherInfo.Text += "============================= \r\n";
            anotherInfo.Text += "======   += 연산 TEST ========\r\n";
            anotherInfo.Text += " String은 불변객체이며 + 연산자를 사용시 \r\n";
            anotherInfo.Text += " 계속해서 String객체가 생성되며 + 를 1000번 한다면 \r\n";
            anotherInfo.Text += "1000 번개의 String 객체가 생성되어 메모리 낭비가 된다고한다 \r\n";


            // String + 연산자가 아닌 StringBuilder() 를 사용해 이어 붙이기
            var anotherInfo2 = new StringBuilder();
            anotherInfo2.Append("====== 기본정보2 ====== \r\n");
            anotherInfo2.Append("=== StringBuilder.Append() Test === \r\n");
            anotherInfo2.Append("StringBuilder를 사용하게되면 가변 객체이며 String 객체를 생성하지 않고 \r\n");
            anotherInfo2.Append("Append() 메서드를 통해 이어 붙이기가 가능하다 \r\n");
            anotherInfo2.Append("기존 anotherInfo.Text = anotherInfo2.ToString()을 사용하면 anotherInfo 내용은 덮어씌워져 사라진다 \r\n");
            anotherInfo2.Append("그렇다면 어떻게 해야 anotherInfo.Text 와 StringBuilder()를 사용한 문장을 붙이려면 ? \r\n");
            anotherInfo2.Append("→  anotherInfo.Text += anotherInfo2.ToString() ");

            anotherInfo.Text += anotherInfo2.ToString();


        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel.LinkColor = (linkLabel.LinkColor == Color.Blue) ? Color.Yellow : Color.Black;

            // 메세지박스 Yes No 사용 하기 
            // DialogResult 를 사용 하면 yes 와 no에 의한 if문으로 결과를 줄수있다

            // 링크 클릭시 페이지 이동 . 사용 하려면 
            // using System.Diagnostics 사용

            DialogResult dialogResult = MessageBox.Show("링크 이동 하시겠습니까 ?", "링크 이동여부 메세지", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            //if (dialogResult == DialogResult.OK)
            //{
            //    MessageBox.Show("링크 이동하겠습니다", "링크 이동 메세지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Process.Start("www.naver.com");
            //}
            //else if (dialogResult == DialogResult.Cancel)
            //{
            //    MessageBox.Show("링크 이동 취소 ", "링크 이동 취소메세지", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //if (dialogResult != DialogResult.OK)
            //{
            //    MessageBox.Show("링크 이동 취소 ", "링크 이동 취소메세지", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //MessageBox.Show("링크 이동하겠습니다", "링크 이동 메세지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Process.Start("www.naver.com");

            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show("링크 이동하겠습니다", "링크 이동 메세지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start("www.naver.com");
                return;
            }

            if (dialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("링크 이동 취소 ", "링크 이동 취소메세지", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
