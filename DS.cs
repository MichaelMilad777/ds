using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace DS
{
    public partial class DS : Form
    {
        public DS()
        {
            InitializeComponent();
            con.Open();

        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=out.mdb");
        cust cust = new cust();
        orders orders = new orders();



        private async void savecustbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (addorderbtn.Text == "اضافة اوردر")
                {
                    await cust.addcust();
                    await cust.GetCust();
                    cust.Clear();
                }
                else
                {
                    cust.AddOrder();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
       

        private async void editcustbtn_Click(object sender, EventArgs e)
        {
            try
            {
                await cust.editcust();
                await cust.GetCust();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        


        private void clearbtn_Click(object sender, EventArgs e)
        {
            cust.Clear();
        }

        private async void DS_Load(object sender, EventArgs e)
        {
            await cust.GetCust();
            orders.Hide();
            cust.MdiParent = this;
            cust.Show();
            cust.Location = new Point(0, 0);
        }

        private async void deketecustbtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                await cust.delcust();
                await cust.GetCust();
                cust.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        

        private void DS_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
        }
       
        
        private void addorderbtn_Click(object sender, EventArgs e)
        {
            if (addorderbtn.Text == "اضافة اوردر")
            {
                addorderbtn.Text = "اضافة عميل";
                cust.Hide();
                orders.MdiParent = this;
                orders.Show();
                orders.Location = new Point(0, 0);
            }
            else
            {
                addorderbtn.Text = "اضافة اوردر";
                orders.Hide();
                cust.MdiParent = this;
                cust.Show();
                cust.Location = new Point(0, 0);


            }

        }





    }


}
