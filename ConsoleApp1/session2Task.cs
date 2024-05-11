//using System;
//using System.Diagnostics;
//using System.Text;

//namespace ConsoleApp1
//{

//    class Student
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//    }
//    class session2Task
//    {
//        static void Main(string[] args)
//        {


//            //1# Factorial of a Number Using Recursion

//            Console.WriteLine("Enter any single number : ");
//            int num = Convert.ToInt32(Console.ReadLine());

//            int n = factNum(num);

//            Console.WriteLine("Factorial of a Number is:" + n);

//            static int factNum(int n1)
//            {
//                if (n1 == 0)
//                {
//                    return 1;
//                }
//                else
//                {
//                    return n1 * factNum(n1 - 1);
//                }

//            }


//            //2# print multiple Command line value

//            foreach (var arg in args)
//            {
//                Console.WriteLine(arg);
//            }


//            //3# Update Name of student using call by reference
//            Student student = new Student();

//            student.Id = 22;
//            student.Name = "Chetan";

//            Console.WriteLine("Value before update:" + student.Name);

//            ChangeVal(student);

//            Console.WriteLine("Value after changes:" + student.Name);


//            //#4 Append string using string builder class

//            StringBuilder sb = new StringBuilder();

//            sb.Append("My name is ");
//            sb.Append("Gadhiya");

//            Console.WriteLine(sb.ToString());


//            //#5 Replace string using string builder class

//             var aa = sb.Replace("Gadhiya", "Chetan");

//            Console.WriteLine("String after replace : " + aa);




//        }


//        static void ChangeVal(Student student)
//        {
//            student.Name = "Gadhiya Chetan";
//        }



//    }


//}
