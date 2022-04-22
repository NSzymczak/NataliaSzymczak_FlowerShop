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

namespace Lab_NataliaSzymczak
{
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
        }
        // zmieszana pierwsza i druga metoda
        int i = 0;
        private void FormView_Load(object sender, EventArgs e)
        {
            if (Product.commonList.Count > 0)
            {
                Product.commonList[i].Write(listView1);
                Product.commonList[i].ShowPhoto(pictureBox1);
                label1.Text = "Zamówienie nr " + (i + 1);
            }
            buttonPhoto.Visible = false;
            numericUpDownRemove.Maximum = Product.commonList.Count;
            numericUpDownRemove.Minimum = 1;

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if(i>0 && i <= Product.commonList.Count)
            {
                i--;
            }
            if (Product.commonList.Count > 0)
            {
                listView1.Items.Clear();
                pictureBox1.Image = null;
                Product.commonList[i].Write(listView1);
                Product.commonList[i].ShowPhoto(pictureBox1);      //jeśli chcemy żeby zdjęcie pokazało się od razu 
                label1.Text = "Zamówienie nr " + (i + 1);
            }

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            
            if(i>=0 && i<(Product.commonList.Count)-1)
            {
                i++;
            }
            if (Product.commonList.Count > 0)
            {
                listView1.Items.Clear();
                pictureBox1.Image = null;
                Product.commonList[i].Write(listView1);
                Product.commonList[i].ShowPhoto(pictureBox1);  //jeśli chcemy żeby zdjęcie pokazało się od razu 
                label1.Text = "Zamówienie nr " + (i + 1);
            }
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            Product.commonList[i].ShowPhoto(pictureBox1);
        }

        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            try { 

            if (Product.commonList.Count == 0)
            {
                MessageBox.Show("Lista zamówień jest pusta, nie ma co zapisać ");
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        foreach (Product rw in Product.commonList)
                            rw.Serialize(sw);
            } 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLoadOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                        while (!sr.EndOfStream)
                        {
                            string header = sr.ReadLine();
                            if (header == "== Floristry ==") new Floristry(sr);
                            if (header == "== Decoration ==") new Decoration(sr);
                        }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wybrano nieprawidłowy plik. Pojawił się błąd " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uwaga " + ex.Message);
            }
            finally
            {
                if (Product.commonList.Count > 0)
                {
                    listView1.Items.Clear();
                    Product.commonList[i].Write(listView1);
                    Product.commonList[i].ShowPhoto(pictureBox1);
                    label1.Text = "Zamówienie nr " + (i + 1);
                    numericUpDownRemove.Maximum = Product.commonList.Count;

                }
            }
        }

        private void buttonRemoveOrder_Click(object sender, EventArgs e)
        {
            if (Product.commonList.Count > 0)
            { 
                Product.commonList.RemoveAt(Convert.ToInt32(numericUpDownRemove.Value) - 1);
                i = 0;
                listView1.Items.Clear();
                pictureBox1.Image = null;
                label1.Text = "Zamówienie nr";
                if (Product.commonList.Count > 0)
                {
                    Product.commonList[i].Write(listView1);
                    Product.commonList[i].ShowPhoto(pictureBox1);
                    label1.Text = "Zamówienie nr " + (i + 1);
                    numericUpDownRemove.Maximum = Product.commonList.Count;

                }
            }
            else
            {
                MessageBox.Show("Brak zamówień do usunięcia");

            }
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            DialogResult odp1 = MessageBox.Show("Chcesz dodać zamówienie na florystykę?", "Uwaga!", MessageBoxButtons.YesNo);
            if (odp1 == DialogResult.Yes)
            {
                new FormFloristry().ShowDialog();
                numericUpDownRemove.Maximum = Product.commonList.Count;

            }
            else
            {
                DialogResult odp2 = MessageBox.Show("Chcesz dodać zamówienie na dekoracje?", "Uwaga!", MessageBoxButtons.YesNo);
                if (odp2 == DialogResult.Yes)
                {
                    new FormDecoration().ShowDialog();
                    numericUpDownRemove.Maximum = Product.commonList.Count;

                }

            }

        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < Product.commonList.Count; i++)
            {
                sum = sum + Product.commonList[i].Allcost();

            }
            MessageBox.Show("Suma zamównień wynosi " + sum.ToString());
        }

        private void buttonMean_Click(object sender, EventArgs e)
        {
            double mean = 0;
            if (Product.commonList.Count > 0)
            {
                for (int i = 0; i < Product.commonList.Count; i++)
                {
                    mean = mean + Product.commonList[i].Allcost();

                }
                mean = mean / Product.commonList.Count;
            }
                MessageBox.Show("Średnia zamównień wynosi " + mean.ToString());
        }
    }
}
