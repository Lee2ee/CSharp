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
    public partial class Form6 : Form
    {
        DBManager dbManager;
        public Form6()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dbManager = DBManager.Instance;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FillComboBox()
        {
            string query = "SELECT title FROM book";
            string[] columns = { "title" };

            List<string[]> list = DBManager.Instance.GetData(query, columns);

            foreach (var row in list)
            {
                comboBox1.Items.Add(row[0]);
            }
        }
    }
}
