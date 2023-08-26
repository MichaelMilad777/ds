using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS
{
    public partial class cust : Form
    {
        public cust()
        {
            InitializeComponent();
            con.Open();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=out.mdb");
        DataTable dt = new DataTable();
        OleDbDataAdapter adapter;
        OleDbCommand cmd;

        public DataGridView MyDataGridView
        {
            get { return dataGridView1; }
        }
        public void Clear()
        {
            nametxt.Clear();
            tel1txt.Clear();
            tel2txt.Clear();
            adresstxt.Clear();
            towntxt.Clear();
            nametxt.Focus();

        }

        public async Task GetCust()
        {
            string query3 = "SELECT * FROM Customers ORDER BY CustCode ASC";
            OleDbCommand command3 = new OleDbCommand(query3, con);
            adapter = new OleDbDataAdapter(command3);
            await command3.ExecuteNonQueryAsync();
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns.Remove("ID");
        }

        public int CustCode()
        {
            string query = "SELECT MAX(CustCode) FROM Customers";
            OleDbCommand command = new OleDbCommand(query, con);
            object maxCustCode = command.ExecuteScalar();
            return Convert.ToInt32(maxCustCode) + 1;
        }

        public async Task addcust()
        {
            if (!(nametxt.Text.Length > 0 && tel1txt.Text.Length > 0 && tel2txt.Text.Length > 0 && adresstxt.Text.Length > 0 && towntxt.Text.Length > 0))
            {
                MessageBox.Show("برجاء كتابة كل البيانات");
            }
            else
            {
                string query = "INSERT INTO Customers (CustCode, CustName, Tel1, Tel2, Address, Town) VALUES (@CustCode, @CustName, @Tel1, @Tel2, @Address, @Town)";
                cmd = new OleDbCommand(query, con);
                int custCode = CustCode();
                //Console.WriteLine(custCode);
                cmd.Parameters.AddWithValue("@CustCode", custCode);
                cmd.Parameters.AddWithValue("@CustName", nametxt.Text);
                cmd.Parameters.AddWithValue("@Tel1", tel1txt.Text);
                cmd.Parameters.AddWithValue("@Tel2", tel2txt.Text);
                cmd.Parameters.AddWithValue("@Address", adresstxt.Text);
                cmd.Parameters.AddWithValue("@Town", towntxt.Text);
                await cmd.ExecuteNonQueryAsync();
                MessageBox.Show("تم إضافة العميل بنجاح");
            }
        }
        public async Task editcust()
        {
            if (!(nametxt.Text.Length > 0 && tel1txt.Text.Length > 0 && tel2txt.Text.Length > 0 && adresstxt.Text.Length > 0 && towntxt.Text.Length > 0))
            {
                MessageBox.Show("برجاء كتابة كل البيانات");
            }
            else
            {

                string query = "UPDATE Customers SET  CustName=@CustName, Tel1=@Tel1, Tel2=@Tel2, Address=@Address, Town=@Town WHERE Tel1= @Tel1";
                cmd = new OleDbCommand(query, con);

                cmd.Parameters.AddWithValue("@CustName", nametxt.Text);
                cmd.Parameters.AddWithValue("@Tel1", tel1txt.Text);
                cmd.Parameters.AddWithValue("@Tel2", tel2txt.Text);
                cmd.Parameters.AddWithValue("@Address", adresstxt.Text);
                cmd.Parameters.AddWithValue("@Town", towntxt.Text);
                //cmd.Parameters.AddWithValue("@ID",Convert.ToInt32( IDtxt.Text));
                await cmd.ExecuteNonQueryAsync();
                MessageBox.Show("تم تعديل العميل بنجاح");
            }
        }
        public async Task delcust()
        {
            try
            {
                if (!(nametxt.Text.Length > 0 && tel1txt.Text.Length > 0 && tel2txt.Text.Length > 0 && adresstxt.Text.Length > 0 && towntxt.Text.Length > 0))
                {
                    MessageBox.Show("برجاء كتابة كل البيانات");
                }
                else
                {
                    string query = "DELETE FROM Customers WHERE CustName=@CustName";
                    cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@CustName", nametxt.Text);
                    await cmd.ExecuteNonQueryAsync();
                    MessageBox.Show("تم حذف العميل ");
                    await GetCust();
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void AddOrder()
        {

            if (!(nametxt.Text.Length > 0 && tel1txt.Text.Length > 0 && tel2txt.Text.Length > 0 && adresstxt.Text.Length > 0 && towntxt.Text.Length > 0))
            {
                string query = "INSERT INTO Orders (OrdCode, OrdDate, Order, Price, Notes) SELECT Customer.CustCode, VALUES(@OrdCode, NOW(), @Order, @Price, @Notes) FROM Customer WHERE Customer.CustCode = @CustCode";
                cmd = new OleDbCommand(query, con);
                String OrdCode = "";
                for (int i = 1; i <= 999; i++)
                {
                    OrdCode = i.ToString("D3");
                }
                cmd.Parameters.AddWithValue("@OrdCode", OrdCode);
                cmd.Parameters.AddWithValue("@Order", tel1txt.Text);
                cmd.Parameters.AddWithValue("@Price", tel2txt.Text);
                cmd.Parameters.AddWithValue("@Notes", adresstxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم إضافة الاوردر بنجاح");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                nametxt.Text = row.Cells[2].Value.ToString();
                tel1txt.Text = row.Cells[3].Value.ToString();
                tel2txt.Text = row.Cells[4].Value.ToString();
                adresstxt.Text = row.Cells[5].Value.ToString();
                towntxt.Text = row.Cells[6].Value.ToString();

            }
        }
        private void tel1txt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (tel1txt.Text.Length > 0)
                {
                    string query = "SELECT * FROM Customers WHERE Tel1=@Tel OR Tel2=@Tel";
                    cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@Tel", tel1txt.Text);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nametxt.Text = reader["CustName"].ToString();
                        tel1txt.Text = reader["Tel1"].ToString();
                        tel2txt.Text = reader["Tel2"].ToString();
                        adresstxt.Text = reader["Address"].ToString();
                        towntxt.Text = reader["Town"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tel1txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tel2txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void nametxt_Enter(object sender, EventArgs e)
        {
            nametxt.Text = Clipboard.GetText();

        }

        private void tel1txt_Enter(object sender, EventArgs e)
        {
            tel1txt.Text = Clipboard.GetText();
        }

        private void tel2txt_Enter(object sender, EventArgs e)
        {
            tel2txt.Text = Clipboard.GetText();
        }

        private void towntxt_Enter(object sender, EventArgs e)
        {
            towntxt.Text = Clipboard.GetText();
        }

        private void adresstxt_Enter(object sender, EventArgs e)
        {
            adresstxt.Text = Clipboard.GetText();
        }
    }
}
