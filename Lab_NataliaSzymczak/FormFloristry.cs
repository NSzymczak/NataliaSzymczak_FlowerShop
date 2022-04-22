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
    public partial class FormFloristry : Form
    {
        public FormFloristry()
        {
            InitializeComponent();
        }


        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Product zamówienie = new Floristry(textBoxSenderName.Text, textBoxSenderSurname.Text, textBoxRecipientName.Text, textBoxRecipientSurname.Text,
                    textBoxAddress.Text, dateTimePickerDeliveryDate.Value, textBoxTel.Text, textBoxAdditionalInformation.Text, listBoxProductName.SelectedItem.ToString(),
                    openFileDialog1.FileName, listBoxFlowerColor.SelectedItem.ToString(), textBoxAdditivesColor.Text, textBoxInscription.Text, listBoxProductSize.SelectedItem.ToString());

                    Product.Add(zamówienie);
                    zamówienie.Write(listView1);


                    textBoxSenderName.Clear();
                    textBoxSenderSurname.Clear();
                    textBoxRecipientName.Clear();
                    textBoxRecipientSurname.Clear();
                    textBoxAddress.Clear();
                    textBoxTel.Clear();
                    textBoxAdditionalInformation.Clear();
                    textBoxAdditivesColor.Clear();
                    textBoxInscription.Clear();

                    zamówienie.ShowPhoto(pictureBox1);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Nie dodałeś poprawnego zdjęcia wystąpił wyjątek. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd" + ex.Message);
            }
            finally
            {
                MessageBox.Show("Zamawianie zakończone");
            }

        }

        private void FormFloristry_Load(object sender, EventArgs e)
        {
            listBoxFlowerColor.SelectedIndex = 0;
            listBoxProductName.SelectedIndex = 0;
            listBoxProductSize.SelectedIndex = 0;
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            if (Floristry.listFlower.Count < 10)
            {
                Floristry.listFlower.Add(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Nie można dodać więcej kwiatów");
                textBox1.Clear();
            }
        }

        private void buttonShowList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < Floristry.listFlower.Count; i++)
            {
                listBox1.Items.Add(Floristry.listFlower[i]);
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Floristry.listFlower.Clear();
            listBox1.Items.Clear();
        }

        private void buttonFillIn_Click(object sender, EventArgs e)
        {
            //Obrazka do zamówienia nie uzupełniam automatycznie ponieważ generuje się on w oparciu o ścieżkę do pliku która na każdym komputerze będzie inna

            Random rnd = new Random();
            int a = rnd.Next(0, 3);

            if (a == 0)
            {
                listBoxProductName.SelectedItem = "Bukiet Romantyczny";
                listBoxProductSize.SelectedItem = "duży";
                listBoxFlowerColor.SelectedItem = "czerwony";
                textBoxInscription.Text = "";
                textBoxAdditivesColor.Text = "czarne";
                textBoxAdditionalInformation.Text = "brak";
                textBoxSenderName.Text = "Kamil";
                textBoxSenderSurname.Text = "Kozak";
                textBoxRecipientName.Text = "Natalia";
                textBoxRecipientSurname.Text = "Szymczak";
                textBoxAddress.Text = "ul.Kraszewskiego 67/2, 48-340 Głuchołazy";
                textBoxTel.Text = "+48 888 242 109";
                dateTimePickerDeliveryDate.Value = new DateTime(2021, 05, 06);
            }
            if (a == 1)
            {
                listBoxProductName.SelectedItem = "Bukiet Urodzinowy";
                listBoxProductSize.SelectedItem = "duży";
                listBoxFlowerColor.SelectedItem = "czerwony";
                textBoxInscription.Text = "";
                textBoxAdditivesColor.Text = "czarne";
                textBoxAdditionalInformation.Text = "brak";
                textBoxSenderName.Text = "Marcin";
                textBoxSenderSurname.Text = "Krzywon";
                textBoxRecipientName.Text = "Kacper";
                textBoxRecipientSurname.Text = "Kowal";
                textBoxAddress.Text = "ul.Miodowa 31/2, 41-300 Sosnowiec";
                textBoxTel.Text = "+48 978 242 856";
                dateTimePickerDeliveryDate.Value = new DateTime(2021, 05, 01);
            }
            if (a == 2)
            {
                listBoxProductName.SelectedIndex = 3;
                listBoxProductSize.SelectedItem = "duży";
                listBoxFlowerColor.SelectedItem = "czerwony";
                textBoxInscription.Text = "";
                textBoxAdditivesColor.Text = "czarne";
                textBoxAdditionalInformation.Text = "brak";
                textBoxSenderName.Text = "Jarek";
                textBoxSenderSurname.Text = "Kaczor";
                textBoxRecipientName.Text = "Jan";
                textBoxRecipientSurname.Text = "Kowalski";
                textBoxAddress.Text = "ul. Powązkowska 1, 01 - 797 Warszawa";
                textBoxTel.Text = "+48 978 242 856";
                dateTimePickerDeliveryDate.Value = new DateTime(2021, 05, 11);
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

        private void textBoxInscription_Leave(object sender, EventArgs e)
        {
            if (textBoxInscription.Text.Length == 0)
            {
                MessageBox.Show("Nie wprowadzono tekstu");
            }
        }

        private void textBoxAdditivesColor_Leave(object sender, EventArgs e)
        {
            if (textBoxAdditivesColor.Text.Length == 0)
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

        private void textBoxSenderName_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxSenderName.Text.Length; i++)
            {
                if ((textBoxSenderName.Text[i] > 64 && textBoxSenderName.Text[i] < 91) ||
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
                if ((textBoxSenderSurname.Text[i] > 64 && textBoxSenderSurname.Text[i] < 91) ||
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
                        || textBoxSenderSurname.Text[i] == 211)
                {

                }
                else
                {
                    MessageBox.Show("Wprowadzono nieprawidłowy znak");
                    textBoxSenderSurname.Clear();
                }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if ((textBox1.Text[i] > 64 && textBox1.Text[i] < 91) ||
                        (textBox1.Text[i] > 95 && textBox1.Text[i] < 123)
                        || textBox1.Text[i] == 260
                        || textBox1.Text[i] == 261
                        || textBox1.Text[i] == 262
                        || textBox1.Text[i] == 263
                        || textBox1.Text[i] == 280
                        || textBox1.Text[i] == 281
                        || textBox1.Text[i] == 346
                        || textBox1.Text[i] == 347
                        || textBox1.Text[i] == 377
                        || textBox1.Text[i] == 378
                        || textBox1.Text[i] == 379
                        || textBox1.Text[i] == 380
                        || textBox1.Text[i] == 322
                        || textBox1.Text[i] == 321
                        || textBox1.Text[i] == 243
                        || textBox1.Text[i] == 211
                        || textBox1.Text[i] == 323
                        || textBox1.Text[i] == 324)
                {

                }
                else
                {
                    MessageBox.Show("Wprowadzono nieprawidłowy znak");
                    textBox1.Clear();
                }
            }
        }
    }
}
