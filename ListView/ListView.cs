using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
            dataGridView1.DataSource = products;

            String imagePath = "C:\\Users\\Daun\\Desktop\\image";


            /**
             *  ListView 다루기
             */
            listView1.View = View.Details;

            // 컬럼명 추가
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Lv");
            listView1.Columns.Add("ATK");
            listView1.Columns.Add("DEF");
            listView1.Columns.Add("HP");

            // 보여질 항목을 생성 new ListViewItem(항목명 , 인덱스 순서)
            ListViewItem item1 = new ListViewItem("무에나", 0);
            item1.SubItems.Add("90");
            item1.SubItems.Add("15");
            item1.SubItems.Add("27");
            item1.SubItems.Add("220");

            ListViewItem item2 = new ListViewItem("위샤델", 1);
            item2.SubItems.Add("90");
            item2.SubItems.Add("19");
            item2.SubItems.Add("15");
            item2.SubItems.Add("210");

            ListViewItem item3 = new ListViewItem("특사스", 2);
            item3.SubItems.Add("90");
            item3.SubItems.Add("21");
            item3.SubItems.Add("19");
            item3.SubItems.Add("280");

            ListViewItem item4 = new ListViewItem("총웨", 3);
            item4.SubItems.Add("90");
            item4.SubItems.Add("15");
            item4.SubItems.Add("30");
            item4.SubItems.Add("300");


            // ListView 이미지
            ImageList imageListSmall = new ImageList();

            imageListSmall.Images.Add(Image.FromFile(imagePath + "\\무에나.jpg"));  // 무에나 이미지 추가
            imageListSmall.Images.Add(Image.FromFile(imagePath + "\\위샤델.jpg"));  // 위샤델 이미지 추가
            imageListSmall.Images.Add(Image.FromFile(imagePath + "\\특사스.jpg"));  // 특사스 이미지 추가
            imageListSmall.Images.Add(Image.FromFile(imagePath + "\\총웨.jpg"));  // 총웨 이미지 추가

  
            // ImageList 크기 조절
            imageListSmall.ImageSize = new Size(50, 50); // Small Icon 크기 설정


            // ListView에 ImageList 연결
            listView1.SmallImageList = imageListSmall;


            // 데이터 삽입
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);
            listView1.Items.Add(item4);

            // 컬럼 너비 자동 조정
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);



            // **********************************************************************************************************   //

            /**
          *  ListView2 다루기
          */
          
            listView2.View = View.LargeIcon;

            // 컬럼명 추가
            listView2.Columns.Add("이름");
            listView2.Columns.Add("ATK");
            listView2.Columns.Add("DEF");
            listView2.Columns.Add("ASPD");
            listView2.Columns.Add("HP");


            // ListView 이미지
            ImageList imageListLarge = new ImageList();

            imageListLarge.Images.Add(Image.FromFile(imagePath + "\\무에나.jpg"));  // 무에나 이미지 추가
            imageListLarge.Images.Add(Image.FromFile(imagePath + "\\위샤델.jpg"));  // 위샤델 이미지 추가
            imageListLarge.Images.Add(Image.FromFile(imagePath + "\\특사스.jpg"));  // 특사스 이미지 추가
            imageListLarge.Images.Add(Image.FromFile(imagePath + "\\총웨.jpg"));  // 총웨 이미지 추가


            // 이미지 사이즈 조정
            imageListLarge.ImageSize = new Size(180, 100); // Large Icon 크기 설정

            // ListView2에 ImageList 연결
            listView2.LargeImageList = imageListLarge;



            // 컬럼 내용 추가 new ListViewItem(항목명 , 인덱스 순서)
            ListViewItem item21 = new ListViewItem("무에나", 0);
            item21.SubItems.Add("15");
            item21.SubItems.Add("27");
            item21.SubItems.Add("180");
            item21.SubItems.Add("220");

            ListViewItem item22 = new ListViewItem("위샤델", 1);
            item22.SubItems.Add("19");
            item22.SubItems.Add("15");
            item22.SubItems.Add("190");
            item22.SubItems.Add("210");

            ListViewItem item23 = new ListViewItem("특사스", 2);
            item23.SubItems.Add("21");
            item23.SubItems.Add("19");
            item23.SubItems.Add("193");
            item23.SubItems.Add("280");

            ListViewItem item24 = new ListViewItem("총웨", 3);
            item24.SubItems.Add("15");
            item24.SubItems.Add("30");
            item24.SubItems.Add("185");
            item24.SubItems.Add("300");

          

            // 데이터 삽입
            listView2.Items.Add(item21);
            listView2.Items.Add(item22);
            listView2.Items.Add(item23);
            listView2.Items.Add(item24);



         


            // 컬럼 너비 자동 조정
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

       // ListView2 아이콘 클릭시 해당 정보 보이는 이벤트
        private void ListView2_ItemActivate(object sender, EventArgs e)
        {
            if(listView2.SelectedItems.Count > 0 )
            {
                ListViewItem selectItem = listView2.SelectedItems[0];
                String name = selectItem.Text;
                String atk = selectItem.SubItems[1].Text;
                String def = selectItem.SubItems[2].Text;
                String aspd = selectItem.SubItems[3].Text;
                String hp = selectItem.SubItems[4].Text;

                MessageBox.Show($"이름  : {name}\nATK  : {atk}\nDEF  : {def}\nHP   : {hp}", "캐릭터 정보");
            }
        }



        // colorDialog 

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            color.ShowHelp = true;

            color.Color = this.BackColor;

            if (color.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = color.Color;
            }
        }



        // 하이퍼링크 버튼
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://naver.com");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://daum.net");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://oioirang.tistory.com/148");
        }

     
        
            
        // form 종료
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        
        


        /******************************************************************************************/
        // dataGridView
       
       public class Product
       {
           public String id { get; set; }

           public String name { get; set; }

           public int ATK { get; set; }

           public int DEF { get; set; }

           public int ASPD { get; set; }

           public int HP { get; set; }

           public int MP { get; set; }

        }


        List<Product> products = new List<Product>

       {
           new Product { id = "0001" , name = " 무에나 " , ATK = 15 , DEF = 27 , ASPD = 10 , HP = 210 , MP = 180 },
           new Product { id = "0002" ,  name = " 위샤델 " , ATK = 19 , DEF = 15 , ASPD = 20 , HP = 210 , MP = 150 } ,
           new Product { id = "0003" , name = " 특사스 " , ATK = 21 , DEF = 19 , ASPD = 10 , HP = 280 , MP = 200} , 
           new Product { id = "0004" ,  name = " 총웨 " , ATK = 15 , DEF = 30 , ASPD = 15 , HP = 300 , MP = 100}
       };

    }
}
