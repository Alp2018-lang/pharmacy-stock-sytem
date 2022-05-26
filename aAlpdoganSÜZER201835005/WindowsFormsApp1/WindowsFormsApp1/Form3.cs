using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security;
using System.Net.Mail;


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("data source=LAPTOP-GNU743MN\\SQLEXPRESS;Initial Catalog=Pharmacy store stock system;Integrated Security=true");
        private void data()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From parola", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();            
                ekle.Text = read["id"].ToString();
                ekle.SubItems.Add(read["Ad"].ToString());
                ekle.SubItems.Add(read["Sifre"].ToString());
                listView1.Items.Add(ekle);

            }
            baglan.Close();


        }
        int id = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update parola set Ad='" + textBox1.Text.ToString() + "',Sifre='" + textBox3.Text.ToString() + "'where id=" + id + "", baglan);


            komut.ExecuteNonQuery();
            baglan.Close();
            data();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f4 = new Form2();
            f4.Show();
            this.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            data();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
