using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;


namespace SerializationDemo
{
    [Serializable]
    public class Product
    {
        public int id { get; set; }
        public String name { get; set; }
        public int price { get; set; }
    }
    class Assign3_Demo
    {
        static void BinarySerializeWrite(Product pro)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\Productfileile.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, pro);
                Console.WriteLine("Binary data Added....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void BinarySerializeRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\Productfile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Product pro = (Product)bf.Deserialize(fs);
                Console.WriteLine(pro.id);
                Console.WriteLine(pro.name);
                Console.WriteLine(pro.price);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /*----------------------------------XML---------------------------------------------------------*/

        static void XmlSerializationWrite(Product pro1)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\Product.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                xs.Serialize(fs, pro1);
                Console.WriteLine("Xml Data Added...");
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void XmlSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\Product.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                Product pro1 = (Product)xs.Deserialize(fs);
                Console.WriteLine(pro1.id);
                Console.WriteLine(pro1.name);
                Console.WriteLine(pro1.price);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /*-----------------------SOAP---------------------------------*/
        static void SoapSerializationWrite(Product pro)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\Product.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, pro);
                Console.WriteLine("SOAP Data Added....");
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void SoapSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\Product.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                Product pro2 = (Product)sf.Deserialize(fs);
                Console.WriteLine(pro2.id);
                Console.WriteLine(pro2.name);
                Console.WriteLine(pro2.price);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /*----------------JSON----------------------------------------*/
        static void JsonSerializationWrite(Product pro3)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\Product.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Product>(fs, pro3);

                Console.WriteLine("Json data added.....");
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void JsonSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\Product.json", FileMode.Open, FileAccess.Read);

                Product pro3 = JsonSerializer.Deserialize<Product>(fs);
                Console.WriteLine(pro3.id);
                Console.WriteLine(pro3.name);
                Console.WriteLine(pro3.price);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            Product pro = new Product { id = 1, name = "Mobile", price = 20000 };
            // BinarySerializeWrite(pro);
            //BinarySerializeRead();
            Console.WriteLine("///////////////////////////");
            // XmlSerializationWrite(pro);
            //XmlSerializationRead();
            Console.WriteLine("////////////////////");
            //SoapSerializationWrite(pro);
            //SoapSerializationRead();
            Console.WriteLine("///////////////////");
            JsonSerializationWrite(pro);
            JsonSerializationRead();
        }
    }
}

