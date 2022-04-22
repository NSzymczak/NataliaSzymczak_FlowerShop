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
    public partial class FormDecoration : Form
    {
        public FormDecoration()
        {
            InitializeComponent();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Product zamówienie = new Decoration(textBoxSenderName.Text, textBoxSenderSurname.Text, textBoxRecipientName.Text, textBoxRecipientSurname.Text,
                    textBoxAddress.Text, dateTimePickerDeliveryDate.Value, textBoxTel.Text, textBoxAdditionalInformation.Text, listBoxProductName.SelectedItem.ToString(),
                     openFileDialog1.FileName, numericUpDownAmount.Value, listBoxAdornment.SelectedItem.ToString(), listBoxPackage.SelectedItem.ToString(), numericUpDownOption.Value);

                    zamówienie.Write(listView1);
                    Product.Add(zamówienie);


                    //czyszczenie kontrolek
                    textBoxAdditionalInformation.Clear();
                    textBoxAddress.Clear();
                    textBoxRecipientName.Clear();
                    textBoxRecipientSurname.Clear();
                    textBoxSenderName.Clear();
                    textBoxSenderSurname.Clear();
                    textBoxTel.Clear();
                    listBoxPackage.SelectedIndex = 0;
                    listBoxAdornment.SelectedIndex = 0;
                    listBoxProductName.SelectedIndex = 0;
                    numericUpDownAmount.Value = 0;
                    numericUpDownOption.Value = 0;

                    zamówienie.ShowPhoto(pictureBox1);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Nie dodałeś poprawnego zdjęcia wystąpił wyjątek. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd"+ex.Message);
            }
            finally
            {
                MessageBox.Show("Zamawianie zakończone");
            }
        }

        private void FormDecoration_Load(object sender, EventArgs e)
        {
            listBoxAdornment.SelectedIndex = 0;
            listBoxProductName.SelectedIndex = 0;
            listBoxPackage.SelectedIndex = 0;
        }

        private void buttonFillIn_Click(object sender, EventArgs e)
        {
            //Obrazka do zamówienia nie uzupełniam automatycznie ponieważ generuje się on w oparciu o ścieżkę do pliku która na każdym komputerze będzie inna
            Random rnd = new Random();
            int a = rnd.Next(0, 3);
                if (a == 0)
                {
                    listBoxProductName.SelectedItem = "Kwiatek doniczkowy";
                    numericUpDownAmount.Value = 1;
                    listBoxPackage.SelectedItem = "folia";
                    numericUpDownOption.Value = 1;
                    textBoxAdditionalInformation.Text = "brak";
                    textBoxSenderName.Text = "Jan";
                    textBoxSenderSurname.Text = "Kowalski";
                    textBoxRecipientName.Text = "Basia";
                    textBoxRecipientSurname.Text = "Nowak";
                    textBoxAddress.Text = "ul. Kwiatowa 43/2, 42-300 Myszków";
                    textBoxTel.Text = "+48 123 456 789";
                    dateTimePickerDeliveryDate.Value = new DateTime(2021, 05, 05);
                }
                if (a == 1)
                {
                    listBoxProductName.SelectedItem = "Świeczka";
                    numericUpDownAmount.Value = 1;
                    listBoxPackage.SelectedItem = "papier";
                    numericUpDownOption.Value = 1;
                    textBoxAdditionalInformation.Text = "brak";
                    textBoxSenderName.Text = "Natalia";
                    textBoxSenderSurname.Text = "Szymczak";
                    textBoxRecipientName.Text = "Kamil";
                    textBoxRecipientSurname.Text = "Kozak";
                    textBoxAddress.Text = "ul. ";
                    textBoxTel.Text = "+48 655 456 789";
                    dateTimePickerDeliveryDate.Value = new DateTime(2021, 05, 10);
                }
                if (a == 2)
                {
                    listBoxProductName.SelectedItem = "Wazon";
                    numericUpDownAmount.Value = 2;
                    listBoxPackage.SelectedItem = "papier";
                    numericUpDownOption.Value = 1;
                    textBoxAdditionalInformation.Text = "brak";
                    textBoxSenderName.Text = "Katarzyna";
                    textBoxSenderSurname.Text = "Mysz";
                    textBoxRecipientName.Text = "Ludwik";
                    textBoxRecipientSurname.Text = "Opolski";
                    textBoxAddress.Text = "ul. Ratuszowa 9-7, 03-407 Warszawa ";
                    textBoxTel.Text = "+48 654 456 546";
                    dateTimePickerDeliveryDate.Value = new DateTime(2021, 05, 19);
                }

    }

        private void textBoxSenderName_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxSenderName.Text.Length; i++)
            {
                if ((textBoxSenderName.Text[i]>64 && textBoxSenderName.Text[i]<91)||
                    (textBoxSenderName.Text[i] > 95 && textBoxSenderName.Text[i] < 123)
                    || textBoxSenderName.Text[i] == 260
                    || textBoxSenderName.Text[i] == 261
                    || textBoxSenderName.Text[i] == 262
                    || textBoxSenderName.Text[i] == 263
                    || textBoxSenderName.Text[i] == 280
                    || textBoxSenderName.Text[i] == 281
                    || textBoxSenderName.Text[i] == 346
                    || textBoxSenderName.Text[i] == 347
                    || textBoxSenderName.Text[i] == 377
                    || textBoxSenderName.Text[i] == 378
                    || textBoxSenderName.Text[i] == 379
                    || textBoxSenderName.Text[i] == 380
                    || textBoxSenderName.Text[i] == 322
                    || textBoxSenderName.Text[i] == 321
                    || textBoxSenderName.Text[i] == 243
                    || textBoxSenderName.Text[i] == 211
                    || textBoxSenderName.Text[i] == 323
                    || textBoxSenderName.Text[i] == 324
                    )
                {

                }
                else
                {
                    MessageBox.Show("Wprowadzono nieprawidłowy znak");
                    textBoxSenderName.Clear();
                }
            }
        }

        private void textBoxSenderSurname_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxSenderSurname.Text.Length; i++)
            {
                if ((textBoxSenderSurname.Text[i] > 64 && textBoxSenderSurname.Text[i] < 91)||
                        (textBoxSenderSurname.Text[i] > 95 && textBoxSenderSurname.Text[i] < 123)
                        || textBoxSenderSurname.Text[i] == 260
                        || textBoxSenderSurname.Text[i] == 261
                        || textBoxSenderSurname.Text[i] == 262
                        || textBoxSenderSurname.Text[i] == 263
                        || textBoxSenderSurname.Text[i] == 280
                        || textBoxSenderSurname.Text[i] == 281
                        || textBoxSenderSurname.Text[i] == 346
                        || textBoxSenderSurname.Text[i] == 347
                        || textBoxSenderSurname.Text[i] == 377
                        || textBoxSenderSurname.Text[i] == 378
                        || textBoxSenderSurname.Text[i] == 379
                        || textBoxSenderSurname.Text[i] == 380
                        || textBoxSenderSurname.Text[i] == 322
                        || textBoxSenderSurname.Text[i] == 321
                        || textBoxSenderSurname.Text[i] == 243
                        || textBoxSenderSurname.Text[i] == 211
                        || textBoxSenderSurname.Text[i] == 323
                        || textBoxSenderSurname.Text[i] == 324)
                {

                }
                else
                {
                    MessageBox.Show("Wprowadzono nieprawidłowy znak");
                    textBoxSenderSurname.Clear();
                }
            }
        }

        private void textBoxRecipientName_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxRecipientName.Text.Length; i++)
            {
                if ((textBoxRecipientName.Text[i] > 64 && textBoxRecipientName.Text[i] < 91) ||
                        (textBoxRecipientName.Text[i] > 95 && textBoxRecipientName.Text[i] < 123)
                        || textBoxRecipientName.Text[i] == 260
                        || textBoxRecipientName.Text[i] == 261
                        || textBoxRecipientName.Text[i] == 262
                        || textBoxRecipientName.Text[i] == 263
                        || textBoxRecipientName.Text[i] == 280
                        || textBoxRecipientName.Text[i] == 281
                        || textBoxRecipientName.Text[i] == 346
                        || textBoxRecipientName.Text[i] == 347
                        || textBoxRecipientName.Text[i] == 377
                        || textBoxRecipientName.Text[i] == 378
                        || textBoxRecipientName.Text[i] == 379
                        || textBoxRecipientName.Text[i] == 380
                        || textBoxRecipientName.Text[i] == 322
                        || textBoxRecipientName.Text[i] == 321
                        || textBoxRecipientName.Text[i] == 243
                        || textBoxRecipientName.Text[i] == 211
                        || textBoxRecipientName.Text[i] == 323
                        || textBoxRecipientName.Text[i] == 324)
                {

                }
                else
                {
                    MessageBox.Show("Wprowadzono nieprawidłowy znak");
                    textBoxRecipientName.Clear();
                }
            }
        }

        private void textBoxRecipientSurname_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxRecipientSurname.Text.Length; i++)
            {
                if ((textBoxRecipientSurname.Text[i] > 64 && textBoxRecipientSurname.Text[i] < 91) ||
                        (textBoxRecipientSurname.Text[i] > 95 && textBoxRecipientSurname.Text[i] < 123)
                        || textBoxRecipientSurname.Text[i] == 260
                        || textBoxRecipientSurname.Text[i] == 261
                        || textBoxRecipientSurname.Text[i] == 262
                        || textBoxRecipientSurname.Text[i] == 263
                        || textBoxRecipientSurname.Text[i] == 280
                        || textBoxRecipientSurname.Text[i] == 281
                        || textBoxRecipientSurname.Text[i] == 346
                        || textBoxRecipientSurname.Text[i] == 347
                        || textBoxRecipientSurname.Text[i] == 377
                        || textBoxRecipientSurname.Text[i] == 378
                        || textBoxRecipientSurname.Text[i] == 379
                        || textBoxRecipientSurname.Text[i] == 380
                        || textBoxRecipientSurname.Text[i] == 322
                        || textBoxRecipientSurname.Text[i] == 321
                        || textBoxRecipientSurname.Text[i] == 243
                        || textBoxRecipientSurname.Text[i] == 211
                        || textBoxRecipientSurname.Text[i] == 323
                        || textBoxRecipientSurname.Text[i] == 324)
                {

                }
                else
                {
                    MessageBox.Show("Wprowadzono nieprawidłowy znak");
                    textBoxRecipientName.Clear();
                }
            }
        }

        private void buttonOrder_MouseEnter(object sender, EventArgs e)
        {
            buttonOrder.BackColor = Color.Gray;
        }

        private void buttonOrder_MouseLeave(object sender, EventArgs e)
        {
            buttonOrder.BackColor = Color.LightGray;
        }

        private void buttonFillIn_MouseEnter(object sender, EventArgs e)
        {
            buttonFillIn.BackColor = Color.Gray;
        }

        private void buttonFillIn_MouseLeave(object sender, EventArgs e)
        {
            buttonFillIn.BackColor = Color.LightGray;
        }

        private void textBoxAdditionalInformation_DoubleClick(object sender, EventArgs e)
        {
            textBoxAdditionalInformation.Text = "brak";
        }
 

        private void textBoxSenderName_Leave(object sender, EventArgs e)
        {
            if (textBoxSenderName.Text.Length == 0)
            {
                MessageBox.Show("Nie wprowadzono tekstu");
            }
        }

        private void textBoxSenderSurname_Leave(object sender, EventArgs e)
        {
            if (textBoxSenderSurname.Text.Length == 0)
            {
                MessageBox.Show("Nie wprowadzono tekstu");
            }
        }

        private void textBoxRecipientName_Leave(object sender, EventArgs e)
        {
            if (textBoxRecipientName.Text.Length == 0)
            {
                MessageBox.Show("Nie wprowadzono tekstu");
            }
        }

        private void textBoxRecipientSurname_Leave(object sender, EventArgs e)
        {
            if (textBoxRecipientSurname.Text.Length == 0)
            {
                MessageBox.Show("Nie wprowadzono tekstu");
            }
        }

        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            if (textBoxAddress.Text.Length == 0)
            {
                MessageBox.Show("Nie wprowadzono tekstu");
            }
        }

        private void textBoxTel_Leave(object sender, EventArgs e)
        {
            if (textBoxTel.Text.Length == 0)
            {
                MessageBox.Show("Nie wprowadzono tekstu");
            }
        }

        private void textBoxAdditionalInformation_Leave(object sender, EventArgs e)
        {
            if (textBoxAdditionalInformation.Text.Length == 0)
            {
                MessageBox.Show("Nie wprowadzono tekstu");
            }
        }

        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxTel.Text.Length; i++)
            {
                if (textBoxTel.Text[i] != '1' &&
                    textBoxTel.Text[i] != '2' &&
                    textBoxTel.Text[i] != '3' &&
                    textBoxTel.Text[i] != '4' &&
                    textBoxTel.Text[i] != '5' &&
                    textBoxTel.Text[i] != '6' &&
                    textBoxTel.Text[i] != '7' &&
                    textBoxTel.Text[i] != '8' &&
                    textBoxTel.Text[i] != '9' &&
                    textBoxTel.Text[i] != '0' &&
                    textBoxTel.Text[i] != ' ' &&
                    textBoxTel.Text[i] != '+')
                {
                    MessageBox.Show("Nieprawidłowy znak!");
                    textBoxTel.Clear();
                }

            }
        }
    }
}
