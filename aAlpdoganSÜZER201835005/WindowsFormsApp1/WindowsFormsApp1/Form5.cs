using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        ArrayList objects = new ArrayList();


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            objects.Add(texteleman.Text);
            texteleman.Clear();



        }

        private void btnGoster_Click(object sender, EventArgs e)


        {


            
            foreach(var eleman in objects)
            {
                lstGoster.Items.Add(eleman);

            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstGoster.Items.Clear();
        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            objects.Sort();//küçükten -büyüğe sıralama şeklinde unutma bunu!!
            }

        private void btnTersCevir_Click(object sender, EventArgs e)
        {
            objects.Reverse();
        }

        private void btnKapasiteGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capasity=" + objects.Capacity);

        }

        private void btnUzunlukGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MedicinNumber=" + objects.Count);
        }

        private void btnElemanSil_Click(object sender, EventArgs e)
        {
            objects.Remove(lstGoster.SelectedItem);
            MessageBox.Show("Deleted");
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            bool ara;
            ara = objects.Contains(textAra.Text);
            if (ara == true)
            {
                MessageBox.Show("Founded");
            }
            else
            {
                MessageBox.Show("Item dont consist");
            }
        }

        private void lstGoster_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
