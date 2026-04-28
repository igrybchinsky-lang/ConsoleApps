using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StoreManagement
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ////WE DONT NEED THIS ANYMORE. WE DID IT IN STATIC CLASS
            ////FileStream fs = new FileStream("Products.txt", FileMode.Append, FileAccess.Write);
            ////StreamWriter sw = new StreamWriter(fs);

            ////sw.WriteLine($"{tbName.Text};{tbProducer.Text};{numericUpDown1.Value}");

            ////sw.Close();
            ////fs.Close();


           
            
            try
            {
                Product p = new Product(tbName.Text, tbProducer.Text,
                Convert.ToInt32(numericUpDown1.Value));
                MyDataBase.WriteProduct(p);

                tbName.Clear();
                tbProducer.Clear();
                numericUpDown1.Value = 0;
                MessageBox.Show("Product has been added");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblId.Text = $"{rnd.Next(10000, 100000)}";
        }
    }
}
