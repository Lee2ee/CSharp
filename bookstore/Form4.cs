using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bookstore
{
    public partial class Form4 : Form
    {
        int id;
        DBManager dbManager;
        public Form4(int id)
        {
            InitializeComponent();
            dbManager = DBManager.Instance;
            this.id = id;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                List<string[]> list = new List<string[]>();
                string query = "select * from publisher";
                string[] colums = { "id", "p_name", "manager", "ph" };
                list = dbManager.GetData(query, colums, id);

                textBox1.Text = list[0][0].ToString();
                textBox2.Text = list[0][1].ToString();
                textBox3.Text = list[0][2].ToString();
                textBox4.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //출판사 수정버튼
        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update publisher set p_name = @p1, manager = @p2, ph = @p3 where id = @p4";

                dbManager.ExecuteQuery(query, textBox1.Text, textBox2.Text, textBox3.Text, id);

                MessageBox.Show("수정완료");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //삭제 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete from publisher where id = @p1";
                dbManager.ExecuteQuery(query, id);

                MessageBox.Show("삭제완료");
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
