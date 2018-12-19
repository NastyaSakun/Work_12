using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Work_12
{
    class Reflector
    {
        

        public void A(string cls)
        {
            FileStream file1 = new FileStream("F:\\A.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            

            Type myType = Type.GetType("Work_12." + cls, false, true);

            foreach (MemberInfo one in myType.GetMembers())
            {
                writer.WriteLine(one.DeclaringType + " " + one.MemberType + " " + one.Name);
            }
            Console.WriteLine();
            writer.Close();
        }

        public void B(string cls)
        {
            Type myType = Type.GetType("Work_12." + cls, false, true);

            foreach (MethodInfo two in myType.GetMethods())
            {
                string mod = "";
                if (two.IsStatic)
                    mod += "static";
                if (two.IsVirtual)
                    mod += "virtual";

                Console.Write(mod + two.ReturnType.Name + " " + two.Name + "(");

                ParameterInfo[] parameters = two.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length)
                        Console.Write(", ");
                }

                Console.WriteLine(")");
            }
        }

        public void C(string cls)
        {
            Type myType = Type.GetType("Work_12." + cls, false, true);

            foreach (FieldInfo three in myType.GetFields())
            {
                Console.WriteLine("{0} {1}", three.FieldType, three.Name);
            }
        }

        public void D(string cls)
        {
            Type myType = Type.GetType("Work_12." + cls, false, true);

            foreach (Type four in myType.GetInterfaces())
            {
                Console.WriteLine(four.Name);
            }
        }

        public void E(string cls)
        {
            Type myType = Type.GetType("Work_12." + cls, false, true);

            Console.Write("\0Введите необходимый тип параметра метода:");
            string typeMethod = Console.ReadLine();

            foreach (MethodInfo five in myType.GetMethods())
            {                               
                ParameterInfo[] parameters = five.GetParameters();

                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].ParameterType.Name == typeMethod)
                    {
                        Console.WriteLine(five.Name); break;
                    }
                }

            }

        }

        public void F(string cls, string meth)
        {
            FileStream file1 = new FileStream("F:\\F1.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            writer.Write("a = 7");                               
            writer.Close();

            FileStream file2 = new FileStream("F:\\F2.txt", FileMode.Create);
            StreamWriter writer2 = new StreamWriter(file2);
            writer2.Write("b = Sakun");
            writer2.Close();                     

            

        }
    }
}
