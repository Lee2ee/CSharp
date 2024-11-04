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
    public partial class Form2 : Form
    {
        DBManager dBManager;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dBManager = DBManager.Instance;
            try
            {
                dataGridView1.Rows.Clear();

                string query = "select * from publisher";
                string[] colums = { "id", "p_name", "manager", "ph" };

                List<string[]> list = new List<string[]>();
                list = dBManager.GetData(query, colums);

                foreach (string[] row in list)
                {
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 출판사 검색 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();

                List<string[]> list = new List<string[]>();
                string[] colums = { "id", "p_name", "manager", "ph" };
                string query;
                object parameter;

                if (int.TryParse(textBox1.Text, out int id))
                {
                    Form4 form4 = new Form4(id);
                    form4.ShowDialog();
                }

                query = "select * from publisher where p_name like '%' + @p1 + '%'";
                parameter = textBox1.Text;
                list = dBManager.GetData(query, colums, parameter);

                foreach (string[] row in list)
                {
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Form4 form4 = new Form4(id);
                form4.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
