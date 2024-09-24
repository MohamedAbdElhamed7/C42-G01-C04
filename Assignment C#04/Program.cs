namespace Assignment_C_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //1- Write a program that allows the user to insert an integer
            //then print all numbers between 1 to that number.

            //int Number;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("Please enter an a number");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //    for (int i = 1; i <= Number; i++)
            //    {
            //        Console.Write($"{i}");
            //        if (i != Number)
            //            Console.Write(", ");

            //    }
            //} while (!Flag);  

            #endregion

            #region Question 2
            //2- Write a program that allows the user to insert an integer then 
            //print a multiplication table up to 12.
            //int Number;
            //bool flag;
            //do 
            //{
            //    Console.WriteLine("enter an a number ");
            //    flag = int.TryParse(Console.ReadLine(), out Number);
            //    for (int i = 1; i <= 12; i++)
            //        Console.Write($"{Number * i} ");
            //}while (!flag);


            #endregion

            #region Question 3
            //3- Write a program that allows to user to insert number then
            ////print all even numbers between 1 to this number

            //int number;
            //Console.WriteLine("Enter a number plz");
            //number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++) 
            //{
            //    if (i % 2 == 0)
            //        Console.Write($"{i} ");
            //}


            #endregion

            #region Question 4
            //Write a program that takes two integers then prints the power.

            //Console.Write("Enter The Number: ");
            //int Num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter The Second Number: ");
            //int Num2 = int.Parse(Console.ReadLine());

            //int ans = 1;
            //if (Num2 > 0)
            //    for (int i = 1; i <= Num2; i++)
            //        ans *= Num1;
            //Console.Write(ans);
            #endregion

            #region Question 5
            //5- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("Enter an string");
            //string word = Console.ReadLine();

            //////Console.WriteLine(word.Reverse());

            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(word[i]);
            //}



            #endregion

            #region Question 6
            //6 - Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.WriteLine("Enter starting number in range");
            //int start = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter ending number in range");
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i < end; i++) 
            //{
            //    if (i % 2 != 0)
            //        Console.Write($"{i} ");
            //}
            #endregion

            #region Quseyion 7
            //7.Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("Enter The Number: ");
            //int Number = int.Parse(Console.ReadLine());
            //string s = "";
            //while (Number > 0)
            //{
            //    s = (Number % 2) + s;
            //    Number /= 2;
            //}
            //Console.WriteLine(s);


            #endregion

            #region Question 8 
            // Write a program that prints an identity matrix using for loop, in other words takes a
            // value n from the user and shows the identity table of size n * n.
            // 1 0 0 0
            // 0 1 0 0
            // 0 0 1 0
            // 0 0 0 1

            //Console.Write("Enter The Number: ");
            //int Number = int.Parse(Console.ReadLine());

            //for(int i = 0; i < Number; i++)
            //{
            //    for(int j = 0; j < Number; j++)
            //    {
            //        if(i == j)
            //        {
            //            Console.Write(1);
            //            continue;
            //        }
            //        Console.Write(0);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

        }
    }
}
