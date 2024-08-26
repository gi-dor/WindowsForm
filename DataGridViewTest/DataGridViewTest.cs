using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.AxHost;

namespace Example01
{
    public partial class DataGridViewTest : Form
    {

        // 데이터베이스 연결
   
        public static String uid = "";
        public static String password = "";  // 비밀번호가 없으므로 빈 문자열
        public static String database = "";
        public static String server = "localhost";

        public static String conStr = $"Server={server}; Database={database}; User Id={uid}; Password={password}; Integrated Security=True";
        SqlConnection conn = new SqlConnection(conStr);

        public DataGridViewTest()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
            conn.Open();
            MessageBox.Show("DB 연결 되었습니다");
            } catch(Exception ex)
            {
                MessageBox.Show($"DB 연결실패 \r\n Error : {ex.Message}", "DB Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {

            String sqlQuery = "select * from dbo.gridViewTest order by USER_ID";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);

            // 데이터 읽기
            SqlDataReader reader = cmd.ExecuteReader();

            // DataTable 생성 및 데이터 로드
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            // 데이터그리드뷰에 데이터 바인딩 (컬럼은 디자인에서 정의된 것을 사용)
            dataGridView1.DataSource = dataTable;

            // 리더와 커맨드를 닫습니다.
            reader.Close();
            cmd.Dispose();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            String sqlQuery = "INSERT INTO dbo.gridViewTest (" +
                "USER_ID , USER_NAME , CUST_ID , AGY_ID , COD , COD_CONT , BRA_ID , BRA_NAME)" +
                "VALUES " +
                "('E003134' , '인천 교차지점' , 0297 , 1307 , '' , '' , 100, '인천' )";

            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
        }
        

        private void dataSelect_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // Next(x) x값보다 작은 랜덤한 양수 반환
            // 랜덤 돌려서 숫자뽑아서 해당하는 데이터 삽입
            int randomChart = random.Next(6);

            switch (randomChart)
            {
                case 0:
                    dataGridView1.Rows.Add("red640", "남양주점", "0320", "0089", "BA93", "거래처 일반사용자", "195", "서울");
                    break;
                case 1:
                    dataGridView1.Rows.Add("rf635", "하남점", "0320", "0635", "BA93", "거래처 일반사용자", "075", "하남");
                    break;
                case 2:
                    dataGridView1.Rows.Add("red790", "동부산점", "0320", "0790", "BA93", "거래처 일반사용자", "025", "부산");
                    break;
                case 4:
                    dataGridView1.Rows.Add("rf563", "안산 선부점", "0320", "0563", "BA93", "거래처 일반사용자", "130");
                    break;
                case 5:
                    dataGridView1.Rows.Add("red658", "E 서인천", "0320", "0658", "BA93", "거래처 일반사용자", "100");
                    break;
            }
            return;
        }

        private void dataSelectAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("red640", "남양주점", "0320", "0089", "BA93", "거래처 일반사용자", "195");
            dataGridView1.Rows.Add("red790", "동부산점", "0320", "0790", "BA93", "거래처 일반사용자", "025");
            dataGridView1.Rows.Add("rf635", "하남점", "0320", "0635", "BA93", "거래처 일반사용자", "075");
            dataGridView1.Rows.Add("rf563", "안산 선부점", "0320", "0563", "BA93", "거래처 일반사용자", "130");
            dataGridView1.Rows.Add("red658", "E 서인천", "0320", "0658", "BA93", "거래처 일반사용자", "100");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void buuttonSelectDelete_Click(object sender, EventArgs e)
        {
            // 선택된 행이 있는지 확인
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                dataGridView1.Rows.RemoveAt(index);
            }
        }

    }
}
