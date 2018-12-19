using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Work_12
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\0Введите имя класса для получения нужной информации:\0");
            string nameClass = Console.ReadLine();

            Reflector reflector = new Reflector();

            if (nameClass != "First" | nameClass != "Second")
                Console.WriteLine("\0Данного класса не существует!");
            else
            {               

                Console.WriteLine("\0Вся информация о классе:");
                FileStream file2 = new FileStream("F:\\A.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file2);
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();
                //reflector.A(nameClass);
                Console.WriteLine();

                Console.WriteLine("\0Информация о методах:");
                reflector.B(nameClass);
                Console.WriteLine();

                Console.WriteLine("\0Информация о полях:");
                reflector.C(nameClass);
                Console.WriteLine();

                Console.WriteLine("\0Информация об интерфейсах:");
                reflector.D(nameClass);
                Console.WriteLine();

                Console.WriteLine("\0Информация о заданном методе:");
                reflector.E(nameClass);
                Console.WriteLine();
            }

            Console.WriteLine("\0Информация значениях параметров метода по заданным названиям метода и соответствующего класса:");
            Console.Write("\0Введите название класса:\0");
            string oneF = Console.ReadLine();
            Console.Write("\0Введите название метода:\0");
            string twoF = Console.ReadLine();
            reflector.F(oneF, twoF);

            if (twoF == "Method" && oneF == "First")
            {
                FileStream fileF = new FileStream("F:\\F1.txt", FileMode.Open);
                StreamReader readerF1 = new StreamReader(fileF);
                Console.WriteLine(readerF1.ReadToEnd());
                readerF1.Close();
            }

            else if (twoF == "Method2" && oneF == "Second")
            {
                FileStream fileF2 = new FileStream("F:\\F2.txt", FileMode.Open);
                StreamReader readerF2 = new StreamReader(fileF2);
                Console.WriteLine(readerF2.ReadToEnd());
                readerF2.Close();
            }

            else
            {
                Console.WriteLine("\0Неправильно введено название класса или метода!");
            }



        }
    }

    public class First:IForD
    {
        public int years = 19;

        public void Method(int a)
        {            
            Console.WriteLine($"\0I am {years + a}");
        }

        public int Math()
        {
            return 1 + 1;
        }
    }

    public class Second
    {
        public string myName  = "Anastasia";
               
        public void Method2(string b)
        {
            Console.WriteLine(b);
        }
    }


}
