using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void BtnClickThis(object sender, EventArgs e)
        {
            try
            {
                int a = 10;
                int b = 20;

                if (a + b == 3)
                    throw new Exception("정답임.");
            } catch (Exception ex){
                MessageBox.Show(ex.Message,"확인",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
      
            }

        }

        private void Btn_clickHere(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tboxItem.Text);
        }

        private void tboxItem_TextChanged(object sender, EventArgs e)
        { 
          
            

        }
           
        private void button8(object sender , EventArgs e)
        {
       
        }
    }
}
