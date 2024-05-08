//using System;

//namespace ConsoleApp1
//{
//    class LoopAndCondition
//    {
//        static void Main(string[] args)
//        {
//            LoopAndCondition p = new LoopAndCondition();
//            Console.WriteLine("================== Task1 =========================== \n");
//            p.Task1();

//            Console.WriteLine("================== Task2 =========================== \n");

//            p.Task2();

//            Console.WriteLine("================== Task3 =========================== \n");

//            p.Task3();

//            Console.WriteLine("================== Task4 =========================== \n");

//            p.Task4(5);

//            Console.WriteLine("================== Task5 =========================== \n");

//            p.Task5(3);


//        }



//        public void Task1()
//        {
//            int sum = 0;


//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine("The first 10 natural number is :" + i);
//                sum = sum + i;
//            }

//            Console.WriteLine($"Sum of 10 numbers is : {sum}");

//        }


//        public void Task2()
//        {

//            int sum = 0, i = 1, n = 0;
//            double avg = 0.0d;

//            Console.WriteLine("Input the 10 numbers :");
//            while (i <= 10)
//            {
//                Console.Write($"Number{i}:");
//                n = Convert.ToInt32(Console.ReadLine());
//                sum += n;
//                i++;

//            }
//            Console.WriteLine("The sum of 10 no is :" + sum);
//            Console.WriteLine("The Average is :" + sum / 10.0);
//        }

//        public void Task3()
//        {
//            for (int i = 1; i <= 4; i++)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write(j);
//                }
//                Console.WriteLine();
//            }

//        }

//        void Task4(int day)
//        {
//            switch (day) 
//            {
//                case 1: Console.WriteLine("Monday");
//                    break;
//                case 2: Console.WriteLine("Tuesday");
//                    break;
//                case 3: Console.WriteLine("Wednesday");
//                    break;
//                case 4: Console.WriteLine("Thursday");
//                    break;
//                case 5: Console.WriteLine("Friday");
//                    break;
//                case 6: Console.WriteLine("Saturday");
//                    break;
//                case 7: Console.WriteLine("Sunday");
//                    break;
//            }
                    
//        }

//        void Task5(int day)
//        {
//            if(day == 1)
//            {
//                Console.WriteLine("Monday");
//            }
//            else if(day == 2)
//            {
//                Console.WriteLine("Tuesday");
//            }
//            else if(day == 3)
//            {
//                Console.WriteLine("Wednesday");
//            }
//            else if( day == 4)
//            {
//                Console.WriteLine("Thurday");
//            }
//            else if(day == 5)
//            {
//                Console.WriteLine("Friday");
//            }
//            else if(day == 6)
//            {
//                Console.WriteLine("Saturday");
//            }
//            else if (day == 7)
//            {
//                Console.WriteLine("Sunday");
//            }
//        }












//    }
//}
