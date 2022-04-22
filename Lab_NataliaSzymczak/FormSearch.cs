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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {


            if (checkBoxDelivery.Checked && checkBoxPrice.Checked && checkBoxName.Checked) //DPN
            {
                List<Product> searchResults = Product.commonList
                    .Where(a => a.WhereName(textBoxName.Text))
                    .Where(a => a.WherePrice(Convert.ToInt32(numericUpDownFrom.Value), Convert.ToInt32(numericUpDownTo.Value)))
                    .Where(a => a.WhereDate(Convert.ToDateTime(dateTimePickerFrom.Value), Convert.ToDateTime(dateTimePickerTo.Value)))
                    .ToList();

                listView1.Items.Clear();
                foreach (Product Pr in searchResults)
                    Pr.WriteShortly(listView1);
            }
            else if (checkBoxDelivery.Checked && checkBoxPrice.Checked) //DP
            {
                List<Product> searchResults = Product.commonList
                .Where(a => a.WherePrice(Convert.ToInt32(numericUpDownFrom.Value), Convert.ToInt32(numericUpDownTo.Value)))
                .Where(a => a.WhereDate(Convert.ToDateTime(dateTimePickerFrom.Value), Convert.ToDateTime(dateTimePickerTo.Value)))
                 .ToList();
                listView1.Items.Clear();
                foreach (Product Pr in searchResults)
                    Pr.WriteShortly(listView1);
            }
            else if (checkBoxDelivery.Checked && checkBoxName.Checked) //DN
            {
                List<Product> searchResults = Product.commonList
                .Where(a => a.WhereName(textBoxName.Text))
                .Where(a => a.WhereDate(Convert.ToDateTime(dateTimePickerFrom.Value), Convert.ToDateTime(dateTimePickerTo.Value)))
                .ToList();

                listView1.Items.Clear();
                foreach (Product Pr in searchResults)
                    Pr.WriteShortly(listView1);
            }
            else if (checkBoxPrice.Checked && checkBoxName.Checked) //PN
            {
                List<Product> searchResults = Product.commonList
                .Where(a => a.WherePrice(Convert.ToInt32(numericUpDownFrom.Value), Convert.ToInt32(numericUpDownTo.Value)))
                .Where(a => a.WhereName(textBoxName.Text))

                .ToList();

                listView1.Items.Clear();
                foreach (Product Pr in searchResults)
                    Pr.WriteShortly(listView1);
            }
            else if (checkBoxPrice.Checked) //P
            {
                List<Product> searchResults = Product.commonList
                .Where(a => a.WherePrice(Convert.ToInt32(numericUpDownFrom.Value), Convert.ToInt32(numericUpDownTo.Value)))

                .ToList();

                listView1.Items.Clear();
                foreach (Product Pr in searchResults)
                    Pr.WriteShortly(listView1);
            }
            else if (checkBoxName.Checked) //N
            {
                List<Product> searchResults = Product.commonList
                .Where(a => a.WhereName(textBoxName.Text))

                .ToList();

                listView1.Items.Clear();
                foreach (Product Pr in searchResults)
                    Pr.WriteShortly(listView1);
            }
            else if (checkBoxDelivery.Checked) //D
            {
                List<Product> searchResults = Product.commonList
                .Where(a => a.WhereDate(Convert.ToDateTime(dateTimePickerFrom.Value), Convert.ToDateTime(dateTimePickerTo.Value)))
                .ToList();

                listView1.Items.Clear();
                foreach (Product Pr in searchResults)
                    Pr.WriteShortly(listView1);
            }

            else
            {
                listView1.Items.Clear();
                foreach (Product Pr in Product.commonList)
                    Pr.WriteShortly(listView1);
            }
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.CustomFormat = "yyyy/MM/dd";
            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;

            dateTimePickerTo.CustomFormat = "yyyy/MM/dd";
            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
        }
    }
}
