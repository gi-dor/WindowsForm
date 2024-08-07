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
    public partial class login : Form
    {
        // 회원가입 폼 열기 위해 전역변수로 설정
        Register _register;

        public login()
        {
            InitializeComponent();

            // 버튼 색상변경
            //button1.BackColor = Color.SkyBlue;
            //userRegisterButton.BackColor = Color.Yellow;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String userId = "940120";
            //String userPassword = "zxcv1234";
            

            if(userId.Text.Equals("940120") && userPassword.Text.Equals("zxcv1234")) {
                MessageBox.Show("로그인 성공 !", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("로그인 실패 ! \r\n아이디 혹은 비밀번호를 확인하세요", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private void userRegister_Click(object sender, EventArgs e)
        {

            if(_register == null)
            {
                // 회원가입 객체생성
                _register = new Register();


                // 회원가입 객체를 이용한 폼 열기
                // 회원가입 폼을 열면 로그인창은 비활성화 시키기 - 중복된 회원가입 폼 띄우기 않게
                _register.Show();
            }

        }



    }
}
