using System;
using System.Collections;
using static ConsoleApp1.Session8;

namespace ConsoleApp1
{
    public class Session8
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.studentData();

            Addition add = new Addition();
            add.Calc(4, 5);

            Multiplication mul = new Multiplication();
            mul.Calc(4, 5);


            Generic generic = new Generic();
            bool result = generic.checkData<int>(7, 9);
            Console.WriteLine(result);




        }


        //#1 Create a C# console application that manages student information using tuples. Add information into tuple and apply foreach loop and display information.
        public class Student
        {
            public void studentData()
            {
                var mylist = new List<Tuple<int, string, string>>();
                mylist.Add(Tuple.Create(1, "Chetan", "chetan123@gmail.com"));
                mylist.Add(Tuple.Create(2, "Rutin", "rutin13@gmail.com"));
                mylist.Add(Tuple.Create(3, "Sahil", "sahil189@gmail.com"));
                foreach (var t in mylist)
                {
                    Console.WriteLine(t);
                }
            }
        }


        //#2 Create a C# console application that demonstrates the use of abstract classes by creating a hierarchy of shapes.

        abstract class Calculation
        {
            public abstract void Calc(int x, int y);
        }

        class Addition : Calculation
        {
            public override void Calc(int x, int y)
            {
                Console.WriteLine("Addition is :" + (x + y));
            }

        }

        class Multiplication : Calculation
        {
            public override void Calc(int x, int y)
            {
                Console.WriteLine("Multiplication is : " + (x*y));
            }
        }


        //#5 create a method to equal two objects with using Generic

        public class Generic
        {
            public bool checkData<T>(T a, T b)
            {
                return a.Equals(b);
            }
        }







    }
























}

