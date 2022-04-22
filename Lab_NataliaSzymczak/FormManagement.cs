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
    public partial class FormManagement : Form
    {
        public FormManagement()
        {
            InitializeComponent();
        }

        private void buttonOneOrder_Click(object sender, EventArgs e)
        {
            Product order1 = Decoration.commonList[(int)numericUpDownOrder1.Value-1];
            Product order2 = Decoration.commonList[(int)numericUpDownOrder2.Value-1];
            if (order1 is Decoration && order2 is Decoration)
            {
                if ((Decoration)order1 == (Decoration)order2)
                    MessageBox.Show("Tak zamówienia można spakować razem");
                else if ((Decoration)order1 != (Decoration)order2)
                    MessageBox.Show("Nie można spakować razem wybranych zamówień ");
            }
            else
            {
                MessageBox.Show("Wybrane zamówienia nie dotyczą dekoracji");
            }
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            Product order1 = Decoration.commonList[(int)numericUpDownOrder1.Value-1];
            Product order2 = Decoration.commonList[(int)numericUpDownOrder2.Value-1];
            if (order1 is Decoration && order2 is Decoration)
            {
                if ((Decoration)order1 < (Decoration)order2)
                {
                    MessageBox.Show("Zamówienie 1 należy dostarczyć szybciej");
                }
                else if ((Decoration)order1 > (Decoration)order2)
                {
                    MessageBox.Show("Zamówienie 2 należy dostarczyć szybciej ");
                }
                else
                {
                    MessageBox.Show("Zamówienia są na ten sam dzień");
                }
            }
            else
            {
                MessageBox.Show("Wybrane zamówienia nie dotyczą dekoracji");
            }
        }

        private void FormManagement_Load(object sender, EventArgs e)
        {
            numericUpDownOrder1.Minimum = 1;
            numericUpDownOrder2.Minimum = 1;
            numericUpDownOrder1.Maximum = Product.commonList.Count;
            numericUpDownOrder2.Maximum = Product.commonList.Count;

            for (int i = 0; i < Product.commonList.Count; i++)
            {
                Product.commonList[i].Write(listView1);
            }
        }
    }
}
