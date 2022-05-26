using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("data source=LAPTOP-GNU743MN\\SQLEXPRESS;Initial Catalog=Pharmacy store stock system;Integrated Security=true");
        private void verilerigörüntüle()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from pharmacy", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["medicinename"].ToString());
                ekle.SubItems.Add(oku["medicinecompany"].ToString());
                ekle.SubItems.Add(oku["typeofthemedicine"].ToString());
                ekle.SubItems.Add(oku["stock"].ToString());
                listView1.Items.Add(ekle);





            }
            baglan.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigörüntüle();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into pharmacy(id,medicinename,medicinecompany,typeofthemedicine,stock)values('"
                + textBox1.Text.ToString()
                + "','"
                + textBox2.Text.ToString()
                + "','"
                + textBox3.Text.ToString()
                + "','"
                + textBox4.Text.ToString()
                + "','"
                + textBox5.Text.ToString()
                + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigörüntüle();
            //text boxlardaki kaydetme işlemi sırasında yazılan ınfoları delete etmek için bir clear komutu yazdım
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

            int id = 0;
       

        private void button3_Click(object sender, EventArgs e)
        {
        baglan.Open();
            SqlCommand komut = new SqlCommand("delete from pharmacy where id=(" + id + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigörüntüle();

                }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id=int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update pharmacy set id='" + textBox1.Text.ToString() + "',medicinename='" + textBox2.Text.ToString() + "',medicinecompany='" + textBox3.Text.ToString() + "',typeofthemedicine='" + textBox4.Text.ToString() + "',stock='" + textBox5.Text.ToString() + "' where id=" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigörüntüle();


                

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }
        }
}
