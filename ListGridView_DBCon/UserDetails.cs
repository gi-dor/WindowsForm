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

namespace test0828
{
    public partial class UserDetails : Form
    {



        // 데이터베이스 연결
        public static String uid = "DESKTOP-TFDKFVS\\Daun";
        public static String password = "";  // 비밀번호가 없으므로 빈 문자열
        public static String database = "";
        public static String server = "";

        public static String conStr = $"Server={server}; Database={database}; User Id={uid}; Password={password}; Integrated Security=True";
        SqlConnection conn = new SqlConnection(conStr);


        public UserDetails()
        {
            InitializeComponent();
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                MessageBox.Show("DB 연결 되었습니다");

                // 해당 컬럼의 ReadOnly 속성 true 
                dataGridView2.ReadOnly = true;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"DB 연결실패 \r\n Error : {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
           try
            {
                String sqlQuery = " SELECT * FROM dbo.USERS order by USER_NO ASC";
                // SQL 쿼리를 실행하기 위한 객체
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                // SqlDataAdapter 는 DB에서 데이터를 가져와 Data Table을 채운다
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                // 가져온 데이터를 담기
                DataTable dataTable = new DataTable();

                // 데이터 어댑터를 통해 데이터를 데이터 테이블에 채움
                dataAdapter.Fill(dataTable);

                // 데이터 테이블을 DataGridView에 연결
                dataGridView1.DataSource = dataTable;
            } catch (Exception ex)
            {
                MessageBox.Show($"데이터 조회 실패 \r\n Error : {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void USERS_CLICK(object sender, DataGridViewCellEventArgs e)
        {
            // 선택한 행의 USER_NO 값을 가져오기
            if (e.RowIndex >= 0 ) // 유효한 행인지 확인
            {
                try
                {
                    // DataGridView1 에서 클릭한 행에서 USER_NO를 가져오기 ... 어케함 ?
                    String column =  dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                    int userNo = Int32.Parse(column);

                    // 선택된 USER_NO에 해당하는 상세 정보를 가져오는 쿼리
                    String sqlQuery = "SELECT A.USER_NO, " +
                                   "A.USER_ID, " +
                                   "A.PASSWORD, " +
                                   "A.PASSWORD_CHECK, " +
                                   "A.NAME, " +
                                   "A.CREATED_DATE, " +
                                   "A.UPDATED_DATE " +
                             "FROM dbo.USER_DETAIL A " +
                             "INNER JOIN dbo.USERS B ON A.USER_NO = B.USER_NO " +
                             $"WHERE A.USER_NO = {userNo}" +
                             "ORDER BY A.USER_NO ASC";

                    // SQL 쿼리를 실행하기 위한 객체
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                    // SqlDataAdapter 는 DB에서 데이터를 가져와 Data Table을 채운다
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    // 가져온 데이터를 담기
                    DataTable dataTable = new DataTable();

                    // 데이터 어댑터를 통해 데이터를 데이터 테이블에 담는다
                    dataAdapter.Fill(dataTable);

                    // 데이터 테이블을 DataGridView2에 연결한다
                    dataGridView2.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 조회 실패 \r\n Error : {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
