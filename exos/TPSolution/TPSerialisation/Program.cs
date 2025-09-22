using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace TPSerialisation
{
    class Program
    {

        static void Main(string[] args)
        {
            testDeSerializeDeuxXml();
        }

        static void testDeSerializeDeuxXml()
        {

            FileStream inStream = new FileStream(@"c:\tmp\marque2.xml", FileMode.Open, FileAccess.Read);
            SoapFormatter binReader = new SoapFormatter();

            Article x = (Article)binReader.Deserialize(inStream);
            Article y = (Article)binReader.Deserialize(inStream);
            inStream.Close();
            Console.WriteLine(x);
            Console.WriteLine(y);

        }

        static void testSerializeDeuxXml()
        {

            Article a1 = new Article("Toto", 3);
            Article a2 = new Article("Tata",2);
            FileStream outStream = new FileStream(@"c:\tmp\marque2.xml", FileMode.OpenOrCreate, FileAccess.Write);
            SoapFormatter binWriter = new SoapFormatter();
            binWriter.Serialize(outStream, a1);
            binWriter.Serialize(outStream, a2);
            outStream.Close();

        }

        static void testDeSerializeOneXml()
        {
            FileStream inStream = new FileStream(@"c:\tmp\marque.xml", FileMode.Open, FileAccess.Read);
            SoapFormatter binReader = new SoapFormatter();

            Article a = (Article)binReader.Deserialize(inStream);
            inStream.Close();
            Console.WriteLine(a);

        }


        static void testSerializeOneXml()
        {
            Article p = new Article("zara", 1);
            FileStream outStream = new FileStream(@"c:\tmp\marque.xml", FileMode.OpenOrCreate, FileAccess.Write);
            SoapFormatter binWriter = new SoapFormatter();
            binWriter.Serialize(outStream, p);
            outStream.Close();
        }

    }
}
