using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetException2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDivv2();
        }

        static void TestDivv2()
        {

            try
            {
                Console.WriteLine("num");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("denom");
                int denom = Convert.ToInt32(Console.ReadLine());
                int res = Calcul.Div(num, denom);
                Console.WriteLine(res);

            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("probleme de division");
                Console.WriteLine("MESSAGE " + e.Message);
                // Console.WriteLine("ToString " + e.ToString());traitement en rapport 
            }
            catch (ArithmeticException e)
            {

            }

            catch (FormatException e)
            {
                Console.WriteLine("probleme de format");
                Console.WriteLine("MESSAGE " + e.Message);
            }
            catch (NumeratorException e)
            {
                Console.WriteLine("probleme de NUMERATEUR");//traitement
                Console.WriteLine("-----------------------");
                Console.WriteLine(e.Message);
                Console.WriteLine("-----------------------");
                Console.WriteLine(e.Complement);
                Console.WriteLine("-----------------------");
                Console.WriteLine(e.ToString());

            }

            catch (Exception e)
            {
                Console.WriteLine("pas bien");
                Console.WriteLine("probleme global");
                Console.WriteLine("TS " + e.ToString());
            }

            finally
            {
                Console.WriteLine("dans le finally");

            }

            Console.WriteLine("a bientot");
        }


        public static int Div(int a, int b)
        {
            if (b == 0)
            {
                DivideByZeroException x = new DivideByZeroException("anomalie technique attention denom a zero");
                throw x;
            }

            if (a == 0)
            {
                NumeratorException x = new NumeratorException("coucou cest moi!!!!", "infos en complement");
                throw x;
            }
            return a / b;
        }
        
}
}
