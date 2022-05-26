using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;




namespace WindowsFormsApp1


{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("data source=LAPTOP-GNU743MN\\SQLEXPRESS;Initial Catalog=Pharmacy store stock system;Integrated Security=true");



        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sql = "Select *from parola where Ad=@adi AND Sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglan);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    Form1 fr = new Form1();
                    fr.Show();
                    this.Hide();
                }


            }
            catch (Exception)
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
       


                /*

                Form1 f8 = new Form1();
                f8.Show();
                this.Hide();


                 Form4 f6 = new Form4();
                    f6.Show();
                    this.Hide();










                /*
                string usern = textBox1.Text;
                int passw= int.Parse(textBox2.Text);

                if (usern == username & passw == password)
                 {
                    Form1 f2 = new Form1();
                    f2.Show();
                    this.Hide();


                }

                else 
                {
                    Form4 f6 = new Form4();
                    f6.Show();
                    this.Hide();

                }

            }
                */
            

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
    





            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
