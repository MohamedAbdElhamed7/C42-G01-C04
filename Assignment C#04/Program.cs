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

            #region Qusetion 10
            //10- Write C# program that take two string variables and print them as one variable 

            //Console.Writeline("Enter The Frist String : ")
            //string s1 = Console.ReadLine();
            //Console.Write("Enter The secound String : ")
            //string s2 = Console.ReadLine();

            //Console.WriteLine(s1 + s2);

            //string s3 = s1 + s2;

            //Console.WriteLine(s3);

            #endregion

            #region Question 11
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

            #region Question 12
            //12- Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] Arr = { 10, 20, 30, 40 };

            //int sum=0;
            //for(int i=0; i<Arr.Length; i++ )
            //    sum += Arr[i];

            //Console.WriteLine(sum);

            #endregion

            #region Q13
            //13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] Arr1 = { 1, 4, 7 };
            //int[] Arr2 = { 2, 3, 5 };

            //int[] Result = new int[Arr1.Length * 2];

            //int n = Arr1.Length;

            //int l = 0;
            //int r = 0;s

            //int i = 0;

            //while (l < n && r < n)
            //{
            //    if (Arr1[l] <= Arr2[r])
            //    {
            //        Result[i] = Arr1[l];
            //        l++;
            //    }
            //    else
            //    {
            //        Result[i] = Arr2[r];
            //        r++;
            //    }
            //    i++;
            //}

            //while (l < n)
            //{
            //    Result[i] = Arr1[l];
            //    l++;
            //    i++;
            //}

            //while (r < n)
            //{
            //    Result[i] = Arr2[r];
            //    r++;
            //    i++;
            //}

            //for (int j = 0; j < Result.Length; j++)
            //{
            //    Console.Write($"{Result[j]} ");
            //}


            #endregion

            #region Q14
            //14- Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] arr = [0, 1, 2, 1, 3, 4, 3, 2,  0];

            //int size = 0;
            //for (int i = 0; i < arr.Length; i++)
            //    size = Math.Max(size, arr[i]);  

            //int[] freq = new int[size + 1];

            //for (int i = 0; i < arr.Length; i++)
            //    freq[arr[i]]++;

            //for (int i = 0; i <= size; i++)
            //{
            //    if (freq[i] > 0)
            //    {
            //        Console.WriteLine($"the Number {i} has freq = {freq[i]}";
            //    }

            //}
            //}
            #endregion

            #region Q15
            //15- Write a program in C# Sharp to find the maximum and minimum element in an array
            //int[] arr = [0, 1, 2, 1, 3, 4, 3, 2, 0];
            //int max = int.MaxValue;
            //int min= int.MinValue;  

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]> max)
            //        max = arr[i]; 

            //    if (arr[i]> min)
            //        min = arr[i];   
            //}

            //Console.WriteLine($"maximum nu = {max}");
            //Console.WriteLine($"maximum nu = {min}");
            #endregion

            #region Q16
            //15- Write a program in C# Sharp to find the maximum and minimum element in an array
            //int[] arr = [0, 1, 2, 1, 3, 4, 3, 2, 0];
            //int max = int.MaxValue;
            //int min= int.MinValue;  

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]> max)
            //        max = arr[i]; 

            //    if (arr[i]> min)
            //        min = arr[i];   
            //}

            //Console.WriteLine($"maximum nu = {max}");
            //Console.WriteLine($"maximum nu = {min}");
            #endregion

            #region Q17
            //write a program to to find the longest distance between Two equal cells.
            //. The distance is measured by the number Of cells- 
            //- Array values will be taken from the user


            //int[] arr = new int [10];    
            //for(int i=0; i<arr.Length; i++)
            //{
            //    Console.WriteLine($"plz enter element of array nu {i+1}");
            //    arr[i] = int.Parse( Console.ReadLine() );
            //}

            //int MaxDis = 0; 

            //for(int i=0; i<arr.Length; i++)
            //{
            //    for (int j = arr.Length - 1; j >= 0; j--)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            if (MaxDis < j - i - 1)
            //            {
            //                MaxDis = j - i - 1;
            //                break;
            //            }
            //        }
            //    }

            //}
            //    Console.WriteLine($"max dis is {MaxDis}");
            #endregion
        }
    }
}
