using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore
{
    public partial class Form5 : Form
    {
        DBManager dbManager;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dbManager = DBManager.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO book (title, author, price, publisher_id) VALUES (@p1, @p2, @p3, @p4)";
                dbManager.ExecuteQuery(query, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

                MessageBox.Show("추가완료");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
