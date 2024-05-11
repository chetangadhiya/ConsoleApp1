//using System;

//namespace ConsoleApp1
//{
//    class StringMethods
//    {
//        static void Main(string[] args)
//        {
//            //substring
//            string abc = "My name is chetan.";

//            string abcSub = abc.Substring(0);

//            Console.WriteLine(abcSub);

//            //convert char to string
//            char[] xyz = { 'c', 'h', 'e', 't', 'a', 'n', ' ', 'g', 'a', 'd', 'h', 'i', 'y', 'a' };


//            string xyz1 = new string(xyz);

//            Console.WriteLine(xyz1);

//            //Reverse a string
//            char[] rev = abc.ToCharArray();

//            string revStr = string.Empty;

//            for (int i = rev.Length - 1; i > -1; i--)
//            {
//                revStr += rev[i];
//            }
//            Console.WriteLine(revStr);


//            //remove duplicate characters

//            Console.WriteLine("Enter word :");
//            string aa = Convert.ToString(Console.ReadLine());// hello world 



//            char[] aaSub = aa.ToCharArray();
//            int count = 0;
//            for (int i = 0; i < aaSub.Length; i++)
//            {
//                for (int j = 0; j <= i; j++)
//                {

//                    char c = aaSub[i];   // h 
//                    if (aaSub[i] == c)
//                    {
//                        count++;
//                    }
//                    else if (count > 0)
//                    {

//                        aaSub[i] = 'p';

//                    }


//                }
//                Console.Write(aaSub[i]);
//            }









//            //count word

//            int count = 0;

//            for (int i = 0; i < revStr.Length; i++)
//            {
//                count++;
//            }
//            Console.WriteLine("Number of words is : " + count);

//            // get highest and minimun occurred char



//            //Arrange a string which contain slash(\) keyword in C#
//            string[] aa = { "Chetan", "Gadhiya" };
//            string strJoin = string.Join("/", aa);
//            Console.WriteLine(strJoin);






//            Find Index Of Substring in C#

//            string strdata = "How are you";

//            int coun = strdata.IndexOf("r");

//            Console.WriteLine(coun);

//            //Remove non-alphanumeric characters from a string

//            string opq = "chetangadhiya@gmail.com";

//            string opq1 = opq?.Remove(13, 1);
//            Console.WriteLine(opq1);

//        }















//    }
//}
