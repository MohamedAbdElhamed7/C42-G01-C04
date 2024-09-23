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

            #region Video5 (StringBuilder)
            // String Builder :-
            //is reference type
            //is Mutable Data Type [Value Can be changed ]
            //internally linked list of chars

            //StringBuilder Message;
            //Decalre For reference from type of string 
            // ClR will allocate 4 Bytes At stack  For reference "Message"
            //Zero bytes allocates at heap 
            // this deafault value of reference type => Null

            //Messsage = new string builder ("Hello")
            //ClR will allocate require bytes at heap [10 bytes ]
            //Initialize allocate bytes with deafult value of char ''
            //call user defined constractor ("Hello") To iniztialize object
            //assign refence to allocate object

            //Message = "Hello" // invalid bec. it syntax sugar for string 

            //Ex. stringBuilder
            //StringBuilder Message;
            //Message = new StringBuilder ("Hello");

            //Console.WriteLine($"Message = {Message}");
            //Console.WriteLine($"Message HC = {Message.GetHashCode()}");

            //Message += "Route" //Invalid

            //Message.Append("Route");
            //Console.WriteLine($"Message = {Message}");
            //Console.WriteLine($"Message HC = {Message.GetHashCode()}");

            // It will have same HashCode Bec. it stringbuilder is mutable value can be changed 

            //Methods
            //StringBuilder Message = new StringBuilder("Hello");

            //Message.Append(" To");  
            //Console.WriteLine(Message); // Hello To

            //Message.AppendLine(" Route");
            //Console.WriteLine(Message);  //Hello To Route

            //Message.Append("Welcome To Aliaa");
            //Console.WriteLine(Message);
            ////Hello To Route
            ////Wlecome Aliaa

            //Message.Remove(0, 6);
            //Console.WriteLine(Message);
            //// To Route
            ////Wlecome Aliaa

            //Message.Insert(0, "Hi ");
            //Console.WriteLine(Message);
            ////Hi To Route
            ////Wlecome Aliaa

            //Console.WriteLine("");

            ////Hi Amr , your Age is 30
            //String Name = "Amr";
            //int Age = 30;
            //Message.AppendFormat(" Hi {0} , your Age is {1}" , Name , Age);
            //Console.WriteLine(Message);
            ////Hi To Route
            ////Wlecome Aliaa
            ////Hi Amr , your Age is 30

            //Console.WriteLine("\n");

            //Message.AppendJoin('/', " Aliaa", "samy", "amr", "mohab", 2);
            //Console.WriteLine(Message);

            #endregion

            #region Video6 (one D Array)
            ////ways of creation array 
            //int[] Number02 = new int[3] { 1, 2, 3 };
            //int[] Number03 = new int[] { 1, 2, 3 };
            //int[] Number04 =  {1, 2, 3 };

            //int[] Number05;
            //Number05 =  { 1,2,3,4}; //invalid
            //Number05 = new int[] { 1, 2, 3, 4 }; // Valid 

            //Console.WriteLine($"Size of array = {Numbers.Length}");//3
            //Console.WriteLine($"Deminsions of array = {Numbers.Rank}");//1

            //Print Elements in "Array" :-
            //--------------------------
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////Console.WriteLine(Numbers); //System.Int32[] // Invalid

            //for (int i = 0; i < Numbers.Length; i++) 
            //{
            //    Console.Write($"{Numbers[i]} ");
            //} 

            //Numbers[9] = 100;
            //Console.WriteLine(Numbers[9]);

            ////Numbers[10] = 1000; // Invalid //System.IndexOutOfRangeException // array is Fixed
            ///

            //TaKE VALUES of array from user :-
            //int[] Numbers = new int[10];
            //for (int i = 0; i < Numbers.Length; i++) 
            //{
            //    Console.WriteLine($"Enter Number of Index = {i}");
            //    Numbers[i] = int.Parse( Console.ReadLine() );  
            //}
            #endregion
        }
    }
}
