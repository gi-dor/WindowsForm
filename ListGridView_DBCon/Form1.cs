using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0828
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void panelMouseLeaveEvent()
        {

        }


        public void panelMouseMoveEvent()
        {

        }


        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        // 시스템 계정현황

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = SystemColors.ControlLightLight; // 원래 패널 색상으로 복구
            panel4.BorderStyle = BorderStyle.None; // 테두리 제거
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.LightBlue; // 원하는 색상으로 변경
            panel4.BorderStyle = BorderStyle.FixedSingle; // 테두리 스타일 추가
        }


        // 대리점 사용자 관리
        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.ControlLightLight; // 원래 패널 색상으로 복구
            panel3.BorderStyle = BorderStyle.None; // 테두리 제거
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.LightBlue; // 원하는 색상으로 변경
            panel3.BorderStyle = BorderStyle.FixedSingle; // 테두리 스타일 추가
        }

        // 거래처 시스템관리
        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = SystemColors.ControlLightLight; // 원래 패널 색상으로 복구
            panel5.BorderStyle = BorderStyle.None; // 테두리 제거
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.BackColor = Color.LightBlue; // 원하는 색상으로 변경
            panel5.BorderStyle = BorderStyle.FixedSingle; // 테두리 스타일 추가
        }



        // 계정 Role관리
        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = SystemColors.ControlLightLight; // 원래 패널 색상으로 복구
            panel2.BorderStyle = BorderStyle.None; // 테두리 제거
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.LightBlue; // 원하는 색상으로 변경
            panel2.BorderStyle = BorderStyle.FixedSingle; // 테두리 스타일 추가
        }

        private void UserDetail(object sender, EventArgs e)
        {
            UserDetails userDetails = new UserDetails();
            userDetails.TopLevel = false;
            userDetails.FormBorderStyle = FormBorderStyle.None;
            userDetails.Dock = DockStyle.Fill;

            // Panel에 UserDetailsForm을 추가합니다.
            this.panel6.Controls.Clear(); // 기존 컨트롤을 제거합니다.
            this.panel6.Controls.Add(userDetails);
            userDetails.Show();
        }
    }

  
}
