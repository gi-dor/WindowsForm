using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }

        private void registerOkButton_Click(object sender, EventArgs e)
        {
            // 우선 이름 , 비밀번호 , 확인 , 핸드폰 , 사업장 위치를 설정해두고 테스트 하자
            //String registerName = "한기선";
            //String registerPassword = "zxcv1234";
            //String registerPasswordCheck = "zxcv1234";
            //String registerTel1 = "010";
            //String registerTel2 = "1111";
            //String registerTel3 = "2222";
            //String registerAddress = "경기도 집 주소";
            //String registerLocation = "회사 위치 서울";


            // 회원 가입
            // 1. 모든 정보 입력
            // 1 - 2. 모든정보 입력 -> 비밀번호 일치 확인
            // 1 - 3 . 회원가입 완료
            // 2. 


            // 1. 이름 , 비밀번호 , 비밀번호 확인 , 핸드폰 , 사업지 위치 모두 입력했는지
            // 1-1 모두 null 이 아니면 회원가입 완료
            if (!((registerName.Text == "") || (registerPassword.Text == "") || (registerPasswordCheck.Text == "") ||
                (registerTel1.Text == "") || (registerTel2.Text == "") || (registerTel3.Text == "") ||
                (registerAddress.Text == "") || (registerLocation.Text == "") ))
            {
                // 입력은 다 했으니 비밀번호 확인하기 
                // 비밀번호가 확인되었으면 return 으로 빠져나가 회원가입 완료하기
                if (registerPassword.Text == registerPasswordCheck.Text)
                {
                    String str = " 이름 : " + registerName.Text + "\r\n" +
                                 " 핸드폰 : " + registerTel1.Text + " - " + registerTel2.Text + " - " + registerTel3.Text + "\r\n" +
                                 " 주소 : " + registerAddress.Text + "\r\n " +
                                 "사업 소재지 : " + registerLocation.Text;

                    //String registerInfo = str.ToString();
                    
                    MessageBox.Show("회원가입 완료되었습니다 \r\n" +"================ \r\n\r\n" + str 
                         , "회원가입" , MessageBoxButtons.OK,MessageBoxIcon.Information); 
                } else
                {
                    // 비밀번호가 일치하지 않으니 가입 거부
                    MessageBox.Show("비밀번호가 일치하지 않습니다", "비밀번호 확인", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            } else
            {
                MessageBox.Show("모든 정보를 입력해주세요", "미입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }


        // 회원가입 취소 버튼 - 단순 창닫기
        private void registerCancelButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
