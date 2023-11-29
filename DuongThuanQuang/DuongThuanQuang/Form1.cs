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
    public partial class Form1 : Form
    {
        bool isExit = true;
        SqlConnection conn = new SqlConnection("Data Source=A209PC38;Initial Catalog=QL_SP;Integrated Security=True");
        DataSet ds_SP = new DataSet();
        SqlDataAdapter da;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            conn.Open();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(txt_MaSP.Text);
            string tenSP = txt_TenSP.Text;
            string sql = "insert into SANPHAM values (" + maSP + ",'" + tenSP + "')";
            string sql2 = "select count(*) from SANPHAM where MASP = '" + maSP + "'";
            SqlCommand cmd = new SqlCommand(sql2, conn);
            int countRow = (int)cmd.ExecuteScalar();
            if (countRow == 0)
            {
                SqlCommand cmd2 = new SqlCommand(sql, conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            else
                MessageBox.Show("Trùng mã sản phẩm!");
            
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            string sql = "select * from SANPHAM";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            dt = new DataTable();
            da.Fill(dt);
            dtgv_SP.DataSource = dt;
            
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from SANPHAM where MASP = '" + txt_MaSP.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            dtgv_SP.DataSource = dt;
            if (dt != null)
                MessageBox.Show("Xóa thành công!");
            else
                MessageBox.Show("Không có dữ liệu để xóa!");
        }

        private void dtgv_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dtgv_SP.Rows[e.RowIndex];
                txt_MaSP.Text = row.Cells["MASP"].Value.ToString();
                txt_TenSP.Text = row.Cells["TENSP"].Value.ToString();
            }
            catch
            {
                txt_MaSP.Clear();
                txt_TenSP.Clear();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "update SANPHAM set MASP = " + txt_MaSP.Text + ",TENSP = '" + txt_TenSP.Text + "' where MASP = '" + txt_MaSP.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            dtgv_SP.DataSource = dt;
            MessageBox.Show("Sửa thành công!");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit == true)
                Application.Exit();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            isExit = false;
            this.Hide();
            fLogin f = new fLogin();
            f.Show();
        }

        

    }
}
