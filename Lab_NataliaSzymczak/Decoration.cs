using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;


namespace Lab_NataliaSzymczak
{
    class Decoration : Product
    {
        protected decimal amount;
        protected string adornment;
        protected string package;
        protected decimal option;


        //Definicja konstruktora bezargumentowego
        public Decoration() : base()
        {
            amount = 0;
            adornment = "";
            package = "";
            option = 0;
        }

        //Definicja konstruktora wieloargumentowego
        public Decoration(string senderName, string senderSurname, string recipientName, string recipientSurname,
            string address, DateTime deliveryDate, string TelNumer, string additionalInformation,
            string productName,string fileName,
            decimal amount, string adornment, string package, decimal option)
            : base(senderName, senderSurname, recipientName, recipientSurname, address, deliveryDate,
                  TelNumer, additionalInformation, productName,fileName)
        {
            this.amount = amount;
            this.adornment = adornment;
            this.package = package;
            this.option = option;
            price= PackagePrice(DecorationPrice(BasePrice()));
            nr=Nr();
        }

        //Definicja konstruktora kopiującego
        public Decoration(Decoration b) : base(b)
        {
            amount = b.amount;
            adornment = b.adornment;
            package = b.package;
            option = b.option;
        }
        public Decoration(StreamReader sr) // nowy konstruktor - tworzenie obiektu na podstawie fragmentu pliku
        {
            Deserialize(sr);
            commonList.Add(this);
        }

        private void SaveBmp(StreamWriter sw)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Bmp);
                byte[] bytes = ms.ToArray();
                sw.WriteLine(Convert.ToBase64String(bytes, 0, bytes.Length));
            }
        }

        private Bitmap LoadBmp(StreamReader sr)
        {
            byte[] bytes = Convert.FromBase64String(sr.ReadLine());
            using (MemoryStream ms = new MemoryStream(bytes))
                return new Bitmap(ms);
        }

        override public void Serialize(StreamWriter sw) 
        {
            sw.WriteLine("== Decoration ==");
            sw.WriteLine(senderName);
            sw.WriteLine(senderSurname);
            sw.WriteLine(recipientName);
            sw.WriteLine(recipientSurname);
            sw.WriteLine(address);
            sw.WriteLine(dateOfPurchase);
            sw.WriteLine(deliveryDate);
            sw.WriteLine(TelNumer);
            sw.WriteLine(additionalInformation);
            sw.WriteLine(productName);
            sw.WriteLine(deliveryCost);
            sw.WriteLine(nr);
            sw.WriteLine(amount);
            sw.WriteLine(adornment);
            sw.WriteLine(package);
            sw.WriteLine(option);
            sw.WriteLine(price);
            sw.WriteLine(nr);
            SaveBmp(sw);

        }

        override public void Deserialize(StreamReader sr)
        {
            senderName = sr.ReadLine();
            senderSurname = sr.ReadLine();
            recipientName = sr.ReadLine();
            recipientSurname = sr.ReadLine();
            address = sr.ReadLine();
            dateOfPurchase = Convert.ToDateTime(sr.ReadLine());
            deliveryDate = Convert.ToDateTime(sr.ReadLine());
            TelNumer = sr.ReadLine();
            additionalInformation = sr.ReadLine();
            productName = sr.ReadLine();
            deliveryCost = Convert.ToDouble(sr.ReadLine());
            nr = Convert.ToInt32(sr.ReadLine());
            amount = Convert.ToInt32(sr.ReadLine());
            adornment = sr.ReadLine();
            package = sr.ReadLine();
            option = Convert.ToInt32(sr.ReadLine());
            price = Convert.ToDouble(sr.ReadLine());
            nr = Convert.ToInt32(sr.ReadLine());


            bitmap = LoadBmp(sr);
        }
        private string KindOfAdornment() 
        {
            if (option == 1) return "Przybranie minimalistyczne";
            if (option == 2) return "Przybranie podstawowe";
            if (option == 3) return "Przybranie podstawowe + dodatek";
            if (option == 4) return "Przybranie specjalne";
            if (option == 5) return "Pełne przybranie";
            return "";
        }
        private double DecorationPrice(double price)
        {
            if (option == 1) return price + 4;
            if (option == 2) return  price + 8;
            if (option == 3) return  price + 10;
            if (option == 4) return price + 15;
            if (option == 5) return price + 20;
            return price;

        }
        private double PackagePrice(double price) 
        {
            if (package == "papier") return price + 2;
            if (package=="folia") return price + 10;
            if (package == "torebka prezentowa") return price + 15;
            return price;


        }
        override public void Write(ListView listview1)
        {
            listview1.Items.Add(new ListViewItem(new[] {"", senderName, senderSurname, recipientName,
                recipientSurname, address, DateTime.Now.ToString(), deliveryDate.ToString(),
                TelNumer, price.ToString(), deliveryCost.ToString(), Allcost().ToString(),
                productName,"-","-","-","-","-","-", amount.ToString(), adornment, package,
                option.ToString(), KindOfAdornment(), additionalInformation }));

        }
        public static bool operator ==(Decoration c1, Decoration c2) => (c1.recipientName == c2.recipientName && c1.recipientSurname == c2.recipientSurname && c1.deliveryDate==c2.deliveryDate);
        public static bool operator !=(Decoration c1, Decoration c2) => !(c1.recipientName == c2.recipientName && c1.recipientSurname == c2.recipientSurname && c1.deliveryDate == c2.deliveryDate);

        public static bool operator <(Decoration c1, Decoration c2) => (c1.deliveryDate < c2.deliveryDate); 
        public static bool operator >(Decoration c1, Decoration c2) => (c1.deliveryDate > c2.deliveryDate);
    }
}



