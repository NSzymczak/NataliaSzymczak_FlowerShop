using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;


namespace Lab_NataliaSzymczak
{
    class Floristry:Product
    {
        protected string flowerColor;
        protected string additivesColor;
        protected string inscription;

        public static List<string> listFlower = new List<string>();

        protected string sizeofProduct;
        protected string kindofProduct;

        //Definicja konstruktora bezargumentowego
        public Floristry() :base()
        {
            flowerColor = "";
            additivesColor = "";
            inscription = "";
            sizeofProduct="";
            kindofProduct = "";
        }

        //Konstruktor wieloargumentowy
        public Floristry(string senderName, string senderSurname, string recipientName, string recipientSurname,
            string address, DateTime deliveryDate, string TelNumer, string additionalInformation,
            string productName,string fileName, 
            string flowerColor,string additivesColor, string inscription,string sizeofProduct)
            : base(senderName, senderSurname, recipientName,recipientSurname, address, deliveryDate, 
                  TelNumer, additionalInformation, productName, fileName)
        {
            this.flowerColor = flowerColor;
            this.additivesColor = additivesColor;
            this.inscription = inscription;
            this.sizeofProduct = sizeofProduct;
            this.kindofProduct = KindOf();
            this.nr=Nr();
            this.price=AdditionalFlower(PriceFloristry(BasePrice()));
        }

        //Konstruktor kopiujący
        public Floristry(Floristry b) : base(b)
        {
            flowerColor = b.flowerColor;
            additivesColor = b.additivesColor;
            inscription = b.inscription;
            sizeofProduct = b.sizeofProduct;
        }

        public Floristry(StreamReader sr) // nowy konstruktor - tworzenie obiektu na podstawie fragmentu pliku
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
            sw.WriteLine("== Floristry ==");
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
            sw.WriteLine(price);
            sw.WriteLine(flowerColor);
            sw.WriteLine(additivesColor);
            sw.WriteLine(inscription);
            sw.WriteLine(sizeofProduct);
            sw.WriteLine(kindofProduct);
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
            price = Convert.ToDouble(sr.ReadLine());
            flowerColor = sr.ReadLine();
            additivesColor = sr.ReadLine();
            inscription = sr.ReadLine();
            sizeofProduct = sr.ReadLine();
            kindofProduct = sr.ReadLine();
   
            bitmap = LoadBmp(sr);
        }


        private double PriceFloristry (double price) //cena florystyki 
        {
      
            if (sizeofProduct == "średni") return  price+0.25 * price;
            if (sizeofProduct == "duży") return price+0.5 * price;
            return price;
        }


        private string KindOf() //Rodzaj produktu
        {
            if (productName == "Bukiet Romantyczny") return "Bukiet";
            if (productName == "Bukiet Urodzinowy") return "Bukiet";
            if (productName == "Bukiet Suptelny") return "Bukiet";
            if (productName == "Wiązanka pogrzebowa") return "Wiązanka";
            if (productName == "FlowerBox") return "Box";
            else return "";
        }

        private double AdditionalFlower(double price)
        {
            if (listFlower.Count > 0 && listFlower.Count < 3) return price + 10;
            if (listFlower.Count > 3) return price + 20;
            return price;
        }

        override public void Write(ListView listview1)
        {
            listview1.Items.Add(new ListViewItem(new[] { "",senderName, senderSurname, recipientName,
                recipientSurname, address, DateTime.Now.ToString(), deliveryDate.ToString(),
                TelNumer, price.ToString(), deliveryCost.ToString(), Allcost().ToString(),
                productName, KindOf(), nr.ToString(), flowerColor, additivesColor, sizeofProduct,
                inscription, "-","-","-","-","-", additionalInformation }));

        }

    }
}
