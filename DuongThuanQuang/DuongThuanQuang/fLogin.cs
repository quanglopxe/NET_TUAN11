using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DuongThuanQuang
{
    public partial class fLogin : Form
    {
        bool isExit = true;
        SqlConnection conn = new SqlConnection("Data Source=A209PC38;Initial Catalog=QL_SP;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public fLogin()
        {
            InitializeComponent();
            conn.Open();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string sql = "select * from ACCOUNT where USERNAME = '" + txt_UserName.Text + "'";
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            int count = 0;
            while(rdr.Read())
            {
                string userName = txt_UserName.Text;
                string password = txt_Password.Text;
                bool re_pw = rbtn_Remember.Checked;
                if (re_pw)
                {
                    userName = rdr.GetString(1);
                    password = rdr.GetString(2);
                }
                if(userName==rdr[1].ToString() && password==rdr[2].ToString())
                {
                    isExit = false;
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();
                    count = 1;
                }
            }
            rdr.Close();
            if (count == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                txt_UserName.Clear();
                txt_Password.Clear();
            }
                
        }

        private void fLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit == true)
                Application.Exit();
        }
    }
}
