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
    public partial class FlowerShop : Form
    {
        public FlowerShop()
        {
            InitializeComponent();
        }

        private void ButtonDecoration_Click(object sender, EventArgs e)
        {
            new FormDecoration().ShowDialog();
        }

        private void ButtonFloristry_Click(object sender, EventArgs e)
        {
            new FormFloristry().ShowDialog();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            //if (Product.commonList.Count == 0)
                //MessageBox.Show("Lista zamówień jest pusta! Dodaj zamówienia do listy.");
           // else
            new FormView().ShowDialog();
        }

        private void buttonManagement_Click(object sender, EventArgs e)
        {
            if (Product.commonList.Count == 0)
                MessageBox.Show("Lista zamówień jest pusta! Dodaj zamówienia do listy.");
            else
                new FormManagement().ShowDialog();
        }

        private void buttonSorting_Click(object sender, EventArgs e)
        {
            new Sortowanie().ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            new FormSearch().ShowDialog();
        }
    }
}
