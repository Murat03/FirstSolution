using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            TryCatch();

            //Method
            HandleException(() =>
            {
                Find();
            });
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(1,2));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1,100);
            };
            Func<int> getRandomNumber2 = () => new Random().Next(1,100);
            Console.WriteLine(getRandomNumber());
            Console.WriteLine(getRandomNumber2());

            Console.ReadLine();
        }
        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Murat", "Melih", "Dilruba" };

            if (!students.Contains("Fatıma"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Murat", "Melih", "Dilruba" };
                students[3] = "Fatıma";
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
