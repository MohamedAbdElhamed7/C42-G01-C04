namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 1 (Loop pt1)
            //// 10 steps [Better For Performance]
            //Console.WriteLine("1 T");
            //Console.WriteLine("2 T");
            //Console.WriteLine("3 T");
            //Console.WriteLine("4 T");
            //Console.WriteLine("5 T");
            //Console.WriteLine("6 T");
            //Console.WriteLine("7 T");
            //Console.WriteLine("8 T");
            //Console.WriteLine("9 T");
            //Console.WriteLine("10 T");

            ////32 Steps [Better For Maintenance ]
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i} T");    
            //}

            #endregion

            #region video2 (loop pt2)
            // for - for each

            // int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 , 10 };
            //For: -
            // for (int i = 0; i < Numbers.Length; i++)
            //   {
            //      if (int == 2)
            //      {
            //           break;
            //      }
            //       Numbers[i] += 10;
            //       Console.WriteLine(Numbers[i]);
            //    }

            //    For each :-
            //    Datatypes must be class Implemnt Interface Ienumerable

            //    foreach (int Number in Numbers)
            //    {
            //        Number += 10;  //invalid
            //        Console.WriteLine(Number);
            //    }
            #endregion

            #region Video3 (loop pt3)
            //Do While :-
            //int Number;
            //bool Flag;
            //do 
            //{
            //    Console.Write("Enter an Even Number : ");
            //    //Number = int.parse(Console.WriteLine());
            //    Flag = int.TryParse(Console.ReadLine() , out Number); 
            //}while (Number % 2 == 1 || !Flag);

            //Console.Write($"{Number} is Even Number  ");

            //  While :-
            //int x = 2;
            //bool Flag = true;
            //while (x % 2 == 0 || !Flag)
            //{
            //    Console.WriteLine("Sorry Ur Number is even , plz Enter an odd Nu "); 
            //    Flag = int.TryParse(Console.ReadLine(), out x);
            //}
            //Console.WriteLine($"{x} is an odd number "); 

            #endregion

            #region Video4 (String)
            //String :-
            //String is a reference datatype , work as value type 
            //String is immutable Datetype [value can't be changed ]
            //internally is an array of char 

            //String Name ;
            //Declare For Reference from type of string 
            //CLR will Allocate 4 Bytes at  stack for Reference "Name"
            //This Reference "Name" is Referening To Deafult value of refernce type = null

            // Name = new string ("Aliaa")
            //ClR will allocate require bytes at heap [10 bytes ]
            //Initialize allocate bytes with deafult value of char ''
            //call user defined constractor ("Aliaa") To iniztialize object
            //assign refence to allocate object

            // Name ="Aliaa " => Syntax Sugar 
            // Name = new string ("Aliaa") , Name ="Aliaa " both are same meaning 

            //string name01 = "Big Mido ";
            //string name02 = "Big Mido ";
            //Console.WriteLine($"name01 : {name01}"); //Big Mido
            //Console.WriteLine($"name01 Hc : {name01.GetHashCode()}"); //1754719144

            //Console.WriteLine($"name02 : {name02}"); //Big Mido
            //Console.WriteLine($"name02 Hc : {name02.GetHashCode()}"); //1754719144

            //Name01 , Name02 both of them Has same address[object] due to LdStr[Load String] 
            #endregion
        }
    }
}
