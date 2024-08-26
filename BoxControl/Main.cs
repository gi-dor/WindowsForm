using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void reStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램 재 시작 되었습니다 ", "재 시작 메세지", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form2WarfButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // 체크박스 이벤트

        // 1. Label 출력
        private void updateCheckBoxLabel()
        {
            String checkStock1 = "";
            String checkStock2 = "";
            String checkStock3 = "";
            String checkStock4 = "";

          

            if(checkBox1.Checked)
            {
                checkStock1 = checkBox1.Text;
            } else
            {
                checkStock1 = "";
            }
            
            // 삼항으로 변경
            checkStock2 =  checkBox2.Checked ? checkBox2.Text : "";
            checkStock3 = checkBox3.Checked ? checkBox3.Text : "";
            checkStock4 = checkBox4.Checked ? checkBox4.Text : "";
            
            /*
            if (checkBox2.Checked)
            {
                checkStock2 = checkBox2.Text;
            } else
            {
                checkStock2 = "";
            }

            if(checkBox3.Checked)
            {
                checkStock3 = checkBox3.Text;
            } else
            {
                checkStock3 = "";
            }
            

            if(checkBox4.Checked)
            {
                checkStock4 = checkBox4.Text;
            } else
            {
                checkStock4 = "";
            }
            */

            checkBoxLabel.Text = checkStock1 + "  " + checkStock2 + "  " + checkStock3 + " " + checkStock4;
        }

        private void checkBox1_Changed(object sender, EventArgs e)
        {
            updateCheckBoxLabel();
        }

        private void checkBox2_Changed(object sender, EventArgs e)
        {
            updateCheckBoxLabel();
        }

        private void checkBox3_Changed(object sender, EventArgs e)
        {
            updateCheckBoxLabel();
        }

        private void checkBox4_Changed(object sender, EventArgs e)
        {
            updateCheckBoxLabel();
        }

        private void checkBoxButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 체크박스에 checked 된것을 확인한다
                // checkBox1.checked 되었다면 checkBox1.Text를 메세지에 보여준다

                string message = "";

                // 체크박스가 체크되어 있으면 해당 텍스트를 메시지에 추가

                // if else-if 구조로 작성하니 이전에 체크한 항목이 메세지에 출력이 되지 않는다
                // if 문 구조로 변경
                if (checkBox1.Checked)
                {
                    message += checkBox1.Text + " ";
                }
                
                if (checkBox2.Checked)
                {
                    message += checkBox2.Text + " ";
                } 
                
                if (checkBox3.Checked)
                {
                    message += checkBox3.Text + " ";
                } 

                if (checkBox4.Checked)
                {
                    message += checkBox4.Text + " ";
                } else
                {
                    message += " 체크된 항목이 없습니다.";
                }
                MessageBox.Show($"체크된 항목 : {message}", "Check Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch(Exception ex)
            {
                MessageBox.Show($"체크박스 이벤트 메세지 내용 부분입니다 \r\n Message : {ex.Message} \r\n Error : {ex.Source}", "Error");
            }


        }

        /**
         *  radio 버튼 변화에 따른 상태변화
         */
        private void updateRadioLabel()
        {
            String radioCheck1 = "";
            String radioCheck2 = "";
            String radioCheck3 = "";
            String radioCheck4 = "";

            radioCheck1 = radioButton1.Checked ? radioButton1.Text : "";
            radioCheck2 = radioButton2.Checked ? radioButton2.Text : "";
            radioCheck3 = radioButton3.Checked ? radioButton3.Text : "";
            radioCheck4 = radioButton4.Checked ? radioButton4.Text : "";

            radioLabel.Text = "선택 : " +  radioCheck1 + " " + radioCheck2 + " " + radioCheck3 + " " + radioCheck4; 
        }


        private void button4_Click(object sender, EventArgs e)
        {
            String radioButtonMessage = "";


            try
            {
                if (radioButton1.Checked)
                {
                    radioButtonMessage = radioButton1.Text;
                    MessageBox.Show($"선택된 radioButton : {radioButtonMessage} " , "Select Mesage" , MessageBoxButtons.OK , MessageBoxIcon.Information );
                }

                if (radioButton2.Checked)
                {
                    radioButtonMessage = radioButton2.Text;
                    MessageBox.Show($"선택된 radioButton : {radioButtonMessage} ", "Select Mesage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (radioButton3.Checked)
                {
                    radioButtonMessage = radioButton3.Text;
                    MessageBox.Show($"선택된 radioButton : {radioButtonMessage} ", "Select Mesage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (radioButton4.Checked)
                {
                    radioButtonMessage = radioButton4.Text;
                    MessageBox.Show($"선택된 radioButton : {radioButtonMessage} ", "Select Mesage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (!(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked))
                {
                    MessageBox.Show("선택된 항목이 없습니다  " , "No Select Message" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"에러가 발생 ! \r\n{ex.Message} " ,"Exception" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

        }

        /**
         * 각각의 radio 버튼 Checked 변화시 이벤트 생성
         */

        private void radioButton1_changed(object sender, EventArgs e)
        {
            updateRadioLabel();
        }

        private void radioButton2_changed(object sender, EventArgs e)
        {
            updateRadioLabel();
        }
        

        private void radioButton3_changed(object sender, EventArgs e)
        {
            updateRadioLabel();
        }

        private void radioButton4_changed(object sender, EventArgs e)
        {
            updateRadioLabel();
        }


        /**
        * 콤보 박스 다루기
        * 
        */



        // 콤보박스 항목 추가
        private void comboTextAddButton_Click(object sender, EventArgs e)
        {
            String str = comboText.Text;
            comboBox1.Items.Add(str);
        }


        // 선택된 콤보박스 항목 제거
        private void comboTextDeleteButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }




        /**
         * 리스트 박스 다루기
         * 
         */


        //  리스트 박스 항목 추가
        private void ListAdd_Click(object sender, EventArgs e)
        {
            if(listBoxText.Text != "")
            {
                // listBox 항목 추가
                listBox1.Items.Add(listBoxText.Text);
                // comboBox 항목추가
                listComboBox.Items.Add(listBoxText.Text);
            }
            listBoxText.Text = "";

            // Focus() 를 사용하면 커서가 해당 텍스트 박스를 클릭되어있어 바로바로 입력가능함
            listBoxText.Focus(); 
        }

        
        /**
         * 삭제 버튼 하나로 리스트박스 , 콤보박스 한번에 삭제하는게 안됨 
         * 둘다 삭제하려고 하면 오류가뜨네..
         */
        // 리스트 박스 항목 제거
        private void ListDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
             //   listComboBox.Items.RemoveAt(listComboBox.SelectedIndex);
            }
        }

        private void comboDelete_Click(object sender, EventArgs e)
        {
            if(listComboBox.SelectedIndex >= 0)
            {
             //   listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listComboBox.Items.RemoveAt(listComboBox.SelectedIndex);
            }
        }
    }
}
