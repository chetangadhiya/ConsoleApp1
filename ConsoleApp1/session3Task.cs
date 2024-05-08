using System;

namespace consoleapp1
{
    class stringSession
    {
        static void Main(string[] args)
        {
            //1# Write a program to create a list and add value and perform first and first or default

            List<string> fList = new List<string>();
            fList.Add("chetan");
            fList.Add("Gadhiya");

            string firstElement = fList.First();
            string firstOrDefaultElement = fList.FirstOrDefault();
            //Console.WriteLine(fList);

            List<int> intList = new List<int>();

            //int firstList = intList.First();
            int fodList = intList.FirstOrDefault();
            Console.WriteLine("FirstOrDefault value is: " + fodList);


            //2# Write a sample program to convert nullable integer value to string

            int? aa = null;

            string strVal = Convert.ToString(aa);

            Console.WriteLine("convert nullable integer value to string : " + strVal.GetType());



            //3# write a program to perform boxing and unboxing operation

            double x = 9.99;
            object y = (int)x;

             int z = (int)y;

            Console.WriteLine("boxing value is:" + z);



            //4# write a program to create a constant and use it in method

            Console.WriteLine("constant value is : " + constClass.constVar);




            //5# write a program to create a read only and modify value and use it in method
            readClass rd = new readClass();
            Console.WriteLine("update readonly value is : " + rd.readVar);


        }


        public class constClass
        {
            public const int constVar = 10;

        }

        public class readClass
        {
            public readonly int readVar = 20;

            public readClass()
            {
                readVar = 30;


            }
        }



















    }
}
