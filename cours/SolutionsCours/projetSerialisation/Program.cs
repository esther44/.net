using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace projetSerialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            testDeSerializeDeuxXmlBis();
        }

        static void testDeSerializeDeuxXmlBis()
        {

            FileStream inStream = new FileStream(@"c:\tmp\personnedeuxbis.xml", FileMode.Open, FileAccess.Read);
            SoapFormatter binReader = new SoapFormatter();

            try
            {
                while (true)
                {
                    object o = binReader.Deserialize(inStream);

                    if (o is Personne)
                        Console.WriteLine(((Personne)o).Nom);

                    else if (o is Item)
                        Console.WriteLine(((Item)o).Name);
                }
            }
            catch
            {

            }

            inStream.Close();


        }

        static void testSerializeDeuxXmlBis()
        {

            Personne p1 = new Personne("aa", "bb", 10);
            Personne p2 = new Personne("xx", "yy", 10);
            Item i1 = new Item("coca");
            Item i2 = new Item("fanta");

            FileStream outStream = new FileStream(@"c:\tmp\personnedeuxbis.xml", FileMode.OpenOrCreate, FileAccess.Write);
            SoapFormatter binWriter = new SoapFormatter();
            binWriter.Serialize(outStream, p1);
            binWriter.Serialize(outStream, p2);
            binWriter.Serialize(outStream, i1);
            binWriter.Serialize(outStream, i2);
            outStream.Close();

        }

        static void testDeSerializeDeuxXml()
        {

            FileStream inStream = new FileStream(@"c:\tmp\personnedeux.xml", FileMode.Open, FileAccess.Read);
            SoapFormatter binReader = new SoapFormatter();

            Personne x = (Personne)binReader.Deserialize(inStream);
            Personne y = (Personne)binReader.Deserialize(inStream);
            inStream.Close();
            Console.WriteLine(x);
            Console.WriteLine(y);

        }

        static void testSerializeDeuxXml()
        {

            Personne p1 = new Personne("aa", "bb", 10);
            Personne p2 = new Personne("xx", "yy", 10);
            FileStream outStream = new FileStream(@"c:\tmp\personnedeux.xml", FileMode.OpenOrCreate, FileAccess.Write);
            SoapFormatter binWriter = new SoapFormatter();
            binWriter.Serialize(outStream, p1);
            binWriter.Serialize(outStream, p2);
            outStream.Close();

        }

        static void testDeSerializeOneXml()
        {
            FileStream inStream = new FileStream(@"c:\tmp\personne.xml", FileMode.Open, FileAccess.Read);
            SoapFormatter binReader = new SoapFormatter();

            Personne p = (Personne)binReader.Deserialize(inStream);
            inStream.Close();
            Console.WriteLine(p);

        }


        static void testSerializeOneXml()
        {
            Personne p = new Personne("aa", "bb", 10);
            FileStream outStream = new FileStream(@"c:\tmp\personne.xml", FileMode.OpenOrCreate, FileAccess.Write);
            SoapFormatter binWriter = new SoapFormatter();
            binWriter.Serialize(outStream, p);
            outStream.Close();
        }


        static void testSerializeOneBin()
        {
            Personne p = new Personne("aa", "bb", 10);
            FileStream outStream = new FileStream(@"c:\tmp\personne.txt", FileMode.OpenOrCreate, FileAccess.Write); // création de flux d'écriture
            BinaryFormatter binWriter = new BinaryFormatter();
            binWriter.Serialize(outStream, p);
            outStream.Close();

        }

        static void testDeSerializeOneBin()
        {
            FileStream inStream = new FileStream(@"c:\tmp\personne.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter binReader = new BinaryFormatter();

            Personne p = (Personne)binReader.Deserialize(inStream);
            inStream.Close();
            Console.WriteLine(p);

        }
    }
}
