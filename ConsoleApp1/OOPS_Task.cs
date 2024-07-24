//using System;



//namespace ConsoleApp1
//{
//    class Person
//    {
//        public string fullName = "Chetan Gadhiya";
//        public int id = 12;
//        public void person1()
//        {
//            Console.WriteLine("This is Baseclass.");
            

//        }
//    }
//    class Program1 : Person
//    {
//        public string couseName = "Information Technology";
//        public void course1()
//        {
//            Console.WriteLine("Here is all course detail.");
//        }

       
//    }
    

//    class c : Program1
//    {
//        public void allData()
//        {
//            Console.WriteLine("Using this class we can access Person class and Program1 class. ");
//        }
//    }


//    class Hierarchical_A
//    {
//        public string CarBrand = "TOYOTA";
//        public string CarName = "Camry";
//        public string Model = "Y24Z";
//        public int Price = 45000;
        
//    }

//    class Hierarchical_B: Hierarchical_A
//    {
//        public void H_B()
//        {
//            Console.WriteLine("Here you can see brandName and carName");
//        }
//    }

//    class Hierarchical_C: Hierarchical_A
//    {
//        public void H_C()
//        {
//            Console.WriteLine("Here you can see carModel and Price");
//        }
//    }


//    interface Inter_A
//    {
//        void Display1();
//        void Print();
        
//    }

//    interface Inter_B
//    {
//        void Display1();
//        void Print();

//    }

//    public class ABC: Inter_A, Inter_B
//    {
//        public void Display1()
//        {
//            Console.WriteLine("My name is chetan");
//        }

//        void Inter_A.Print()
//        {
//            Console.WriteLine("This is explicit1");
//        }

//        void Inter_B.Print()
//        {
//            Console.WriteLine("This is explicit2");
//        }
//    }





//    class OOPS
//    {
//        static void Main(string[] args)
//        {   
//            // Single inheritance
//            Program1 pro1 = new Program1();

//            pro1.course1();

//            Console.WriteLine("Person name is :" +pro1.fullName + "\n" + "CourseName is : "+ pro1.couseName);

//            Console.WriteLine("================================================\n");

//            //Multilevel inheritance

//            c objC = new c();

//            Console.WriteLine("C class can access Person class and Program1 class data.\n");
//            int id = objC.id;
//            string name = objC.fullName;
//            string course = objC.couseName;
//            Console.WriteLine("Id: "+id + "\n" +"Name: " +name + "\n" +"Course: "+course);

//            Console.WriteLine("==================================================\n");

//            //Hierarchical inheritance

//            Hierarchical_B objB = new Hierarchical_B();
//            objB.H_B();
//            Console.WriteLine("CarBrand: " + objB.CarBrand + "\n" + "CarName: " + objB.CarName);
//            Console.WriteLine("===================================================\n");

//            Hierarchical_C HC = new Hierarchical_C();
//            HC.H_C();
//            Console.WriteLine("Model: " + HC.Model +"\n" + "Price: " + HC.Price);

//            Console.WriteLine("==============================================\n");


//            //#2 write a program of implicit implementation of interface

//            ABC abc = new ABC();

//            abc.Display1();

//            //#3 write a program of explicit implementation of interface

//            Inter_A obj11 = new ABC();

//            obj11.Print();


//            Inter_B obj12 = new ABC();

//            obj12.Print();
//        }


//    }


//}
