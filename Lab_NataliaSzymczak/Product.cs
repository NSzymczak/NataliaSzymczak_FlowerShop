using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab_NataliaSzymczak
{
    abstract class Product : IComparable<Product>
    {
        static public List<Product> commonList = new List<Product>();
        static public int indeks = -1;

        //informacje o nadawcy
        protected string senderName; //imie nadawcy                        DO WPISANIA #1
        protected string senderSurname; //nazwisko nadawcy                 DO WPISANIA #2
        protected string recipientName; //imie odbiorcy                    DO WPISANIA #3
        protected string recipientSurname; //nazwisko odbiorcy             DO WPISANIA #4

        //Informacje o dostawie
        protected string address;           //adres dostawy                DO WPISANIA #5
        protected DateTime dateOfPurchase; //Data zakupu produktu          DO WPISANIA #6
        protected DateTime deliveryDate;   //Data i godzina dostawy        DO WPISANIA #7
        protected string TelNumer;             //numer telefonu klienta    DO WPISANIA #8
        protected string additionalInformation; // szczegóły zamowienia    DO WPISANIA #9
        protected Bitmap bitmap;

        protected string productName;     //Nazwa produktu                 DO WYBORU #10     
        protected double price;            //cena                          generuje się 
        protected int nr;                 //numer Katalogowy               generuje się 

        protected double deliveryCost;       //koszt dostawy               generuje się 
        static int numberOfProducts; //numeracja

        //Definicja konstruktora bezargumentowego
        public Product()
        {
            senderName = "";
            senderSurname = "";
            recipientName = "";
            recipientSurname = "";

            address = "";
            dateOfPurchase = new DateTime();
            deliveryDate = new DateTime();
            TelNumer = "";
            additionalInformation = "";

            productName = "-";

            price = 0;
            nr = 0;
            deliveryCost = 0;
        }

        //Definicja konstruktora wieloargumentowego
        public Product(string senderName, string senderSurname, string recipientName, string recipientSurname,
            string address, DateTime deliveryDate, string TelNumer, string additionalInformation,
            string productName, string fileName)

        {
            this.senderName = senderName;
            this.senderSurname = senderSurname;
            this.recipientName = recipientName;
            this.recipientSurname = recipientSurname;


            this.address = address;
            this.dateOfPurchase = DateTime.Now;
            this.deliveryDate = deliveryDate;
            this.TelNumer = TelNumer;
            this.additionalInformation = additionalInformation;

            this.productName = productName;

            bitmap = new Bitmap(fileName);
            this.deliveryCost = DeliveryCost();
            numberOfProducts++;
        }

        //Destruktor
        ~Product()
        {

        }

        //konstruktor kopiujący
        public Product(Product product)
        {
            this.senderName = product.senderName;
            this.senderSurname = product.senderSurname;
            this.recipientName = product.recipientName;
            this.recipientSurname = product.recipientSurname;


            this.address = product.address;
            this.dateOfPurchase = product.dateOfPurchase;
            this.deliveryDate = product.deliveryDate;
            this.TelNumer = product.TelNumer;
            this.additionalInformation = product.additionalInformation;

            this.productName = product.productName;

            this.deliveryCost = product.deliveryCost;
            this.nr = product.nr;

            numberOfProducts++;
        }

        //metoda #1
        public double Allcost()
        {
            return price + deliveryCost;
        }

        //metoda #2
        public double DeliveryCost()
        {
            if (price >= 150) return deliveryCost = 0;
            else return deliveryCost = 10;
        }

        public double BasePrice()
        {
            if (productName == "Bukiet Romantyczny") return 200;
            if (productName == "Bukiet Urodzinowy") return 100;
            if (productName == "Bukiet Suptelny") return 150;
            if (productName == "Wiązanka pogrzebowa") return 80;
            if (productName == "FlowerBox") return 100;
            if (productName == "Kwiatek doniczkowy") return 60;
            if (productName == "Świeczka") return 15;
            if (productName == "Figurka") return 90;
            if (productName == "Wazon") return 40;
            return 1;

        }

        public int Nr()
        {
            if (productName == "Bukiet Romantyczny") return 5010;
            if (productName == "Bukiet Urodzinowy") return 5011;
            if (productName == "Bukiet Suptelny") return 5012;
            if (productName == "Wiązanka pogrzebowa") return 5100;
            if (productName == "FlowerBox") return 5200;
            if (productName == "Kwiatek doniczkowy") return 5301;
            if (productName == "Świeczka") return 5302;
            if (productName == "Figurka") return 5303;
            if (productName == "Wazon") return 5304;
            return 1;
        }

        //definicja metody wirtualnej
        virtual public void Write(ListView listview1) { }
        virtual public void Serialize(StreamWriter sw) { }
        virtual public void Deserialize(StreamReader sr) { }

        public void ShowPhoto(PictureBox pictureBox1)
        {
            pictureBox1.Image = bitmap;
        }

        static public void Add(Product p)
        {
            commonList.Add(p);
            if (commonList.Count > 0) indeks = commonList.Count - 1;
        }
        public void WriteShortly(ListView listview1)
        {
            listview1.Items.Add(new ListViewItem(new[] { recipientSurname, recipientName, deliveryDate.ToString(), dateOfPurchase.ToString(), Allcost().ToString() }));

        }
        public bool WhereName(string phrase)
        {
            return recipientSurname.Contains(phrase);
        }

        public bool WherePrice(int from, int to)
        {
            return (price >= from && price <= to);
        }

        public bool WhereDate( DateTime from, DateTime to)
        {
            return (deliveryDate >= from && deliveryDate <= to);
        }

        public int CompareTo(Product product)
        {
            if (product == null)
                return 1;
            //Będziemy chcieli sortować obiekty według nazwiska
            if (String.Compare(this.recipientSurname, product.recipientSurname) == 1)
                return 1;
            else if (String.Compare(this.recipientSurname, product.recipientSurname) == -1)
                return -1;
            else
            {
                //Obiekty o takich samych nazwiskach będziemy chcieli sortować (dodatkowo) według imienia
                if (String.Compare(this.recipientName, product.recipientName) == 1)
                    return 1;
                else if (String.Compare(this.recipientName, product.recipientName) == -1)
                    return -1;
                else
                {
                    //Obiekty o takich samych nazwiskach i imionach będziemy chcieli sortować (dodatkowo)
                    //według daty urodzenia
                    if (this.deliveryDate > product.deliveryDate)
                        return 1;
                    else if (this.deliveryDate < product.deliveryDate)
                        return -1;
                    else
                    {
                        if (this.dateOfPurchase > product.dateOfPurchase)
                            return 1;
                        else if (this.dateOfPurchase < product.dateOfPurchase)
                            return -1;
                        return 0;
                    }

                }
            }
        }
    }
}
