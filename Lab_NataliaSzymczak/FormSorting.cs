using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_NataliaSzymczak
{
    public partial class Sortowanie : Form
    {
        public Sortowanie()
        {
            InitializeComponent();
        }

        private void buttonSortingDown_Click(object sender, EventArgs e)
        {

            Product.commonList=Product.commonList.OrderByDescending(a => a).ToList();
            listView1.Items.Clear();

            foreach (Product p in Product.commonList)
                p.WriteShortly(listView1);
        }

        private void buttonSortingUp_Click(object sender, EventArgs e)
        {

            Product.commonList.Sort();
            listView1.Items.Clear();

            foreach (Product p in Product.commonList)
                p.WriteShortly(listView1);
        }
    }
    
}
