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
        }
    }
}
