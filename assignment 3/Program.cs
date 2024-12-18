namespace assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1 Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());


            for (int i = 1; i <= number; i++)
            {
                Console.Write(i);
                if (i < number)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            #endregion


            #region Q2 Write a program that allows the user to insert an integer then print a multiplication table up to 12.



            for (int i = 1; i <= 12; i++)
            {
                Console.Write(number * i);
                if (i < 12)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();


            #endregion


            #region Q3 Write a program that allows to user to insert number then print all even numbers between 1 to this number


            for (int i = 2; i <= number; i += 2)
            {
                Console.Write(i);
                if (i + 2 <= number)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();


            #endregion


            #region Q4  Write a program that takes two integers then prints the power.


            Console.Write("Enter the base number: ");
            int baseNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            // Calculate the power
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            // Print the result
            Console.WriteLine($"The result of {baseNumber}^{exponent} is: {result}");


            #endregion


            #region Q5 Write a program to enter marks of five subjects and calculate total, average and percentage.

            int[] marks = new int[5];

            Console.WriteLine("Enter marks of five subjects:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            // Calculate total marks
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }

            // Calculate average and percentage
            double average = total / 5.0;
            double percentage = (total / 500.0) * 100;

            // Display results
            Console.WriteLine($"\nTotal Marks = {total}");
            Console.WriteLine($"Average Marks = {average:F0}");
            Console.WriteLine($"Percentage = {percentage:F0}%");


            #endregion

            #region Q6 Write a program to allow the user to enter a string and print the REVERSE of it.


            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Reverse the string
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            // Print the reversed string
            Console.WriteLine($"Reversed string: {reversed}");


            #endregion


            #region Q7 Write a program to allow the user to enter int and print the REVERSED of it.


            Console.Write("Enter an integer: ");

            int reverse = 0;
            while (number != 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number /= 10;
            }

            // Print the reversed integer
            Console.WriteLine($"Reversed integer: {reverse}");



            #endregion


            #region Q8 Write a program in C# Sharp to find prime numbers within a range of numbers.

            Console.Write("Input starting number of range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Input ending number of range: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nThe prime numbers between {start} and {end} are:");

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        

        // Function to check if a number is prime
        static bool IsPrime(int number)
        {
            if (number <= 1) return false; // 1 and numbers below are not prime
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

            #endregion


            #region Q9 Write a program in C# Sharp to convert a decimal number into binary without using an array.

            Console.Write("Enter a number to convert: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            // Convert decimal to binary
            string binary = "";
            int numbers = decimalNumber;

            while (numbers > 0)
            {
                int remainder = numbers % 2;
                binary = remainder + binary; 
                numbers /= 2;
            }

           
            if (binary == "")
            {
                binary = "0";
            }

            // Display the result
            Console.WriteLine($"The Binary of {decimalNumber} is {binary}.");



            #endregion


            #region Q10  Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.


            Console.WriteLine("Enter the coordinates of three points:");

            Console.Write("Enter x1: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.Write("Enter y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Enter x2: ");
            int x2 = int.Parse(Console.ReadLine());

            Console.Write("Enter y2: ");
            int y2 = int.Parse(Console.ReadLine());

            Console.Write("Enter x3: ");
            int x3 = int.Parse(Console.ReadLine());

            Console.Write("Enter y3: ");
            int y3 = int.Parse(Console.ReadLine());

            // Check if the points are collinear
            if (IsCollinear(x1, y1, x2, y2, x3, y3))
            {
                Console.WriteLine("The points lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("The points do not lie on a single straight line.");
            }
        

        // Function to check if the points are collinear
        static bool IsCollinear(int x1, int y1, int x2, int y2, int x3, int y3)
            {
                // Using the area method to check if the area of the triangle formed by the points is zero
                int area = (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

                // If the area is zero, the points are collinear
                return area == 0;
            }


            #endregion


            #region Q11 Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.


            Console.Write("Enter the size of the matrix (n): ");
            int n = int.Parse(Console.ReadLine());

            // Print the identity matrix
            Console.WriteLine("\nIdentity Matrix of size " + n + "x" + n + ":");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Print 1 at the diagonal positions, otherwise 0
                    if (i == j)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();  // Move to the next line after each row

            }
            #endregion


            #region Q12 Write a program in C# Sharp to find the sum of all elements of the array.


            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            // Declare an array of the given size
            int[] num = new int[size];

            // Ask the user to enter the elements of the array
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            // Calculate the sum of the array elements
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += num[i];
            }

            // Print the result
            Console.WriteLine($"The sum of all elements in the array is: {sum}");


            #endregion

            #region Q13 Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            Console.Write("Enter the size of the arrays: ");
            int s = int.Parse(Console.ReadLine());

           
            int[] array1 = new int[size];
            int[] array2 = new int[size];

          
            Console.WriteLine("Enter the elements of the first array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

          
            Console.WriteLine("Enter the elements of the second array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

         
            int[] mergedArray = new int[size * 2];
            for (int i = 0; i < size; i++)
            {
                mergedArray[i] = array1[i];
                mergedArray[i + size] = array2[i];
            }

            Array.Sort(mergedArray);

           
            Console.WriteLine("\nMerged and Sorted Array:");
            foreach (var item in mergedArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            #endregion

            #region Q14 Write a program in C# Sharp to count the frequency of each element of an array.

            Console.Write("Enter the size of the array: ");
            int size2 = int.Parse(Console.ReadLine());

            
            int[] number2 = new int[size2];

            
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size2; i++)
            {
                Console.Write($"Element {i + 1}: ");
                number2[i] = int.Parse(Console.ReadLine());
            }

            
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int numb1 in number2)
            {
                if (frequencyMap.ContainsKey(numb1))
                {
                    frequencyMap[numb1]++;
                }
                else
                {
                    frequencyMap[numb1] = 1;
                }
            }

            
            Console.WriteLine("\nFrequency of each element:");
            foreach (var pair in frequencyMap)
            {
                Console.WriteLine($"Element {pair.Key} appears {pair.Value} time(s).");

            }
            #endregion


            #region Q15 Write a program in C# Sharp to find maximum and minimum element in an array

            Console.Write("Enter the size of the array: ");
            int sizes = int.Parse(Console.ReadLine());

          
            int[] numb = new int[sizes];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < sizes; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numb[i] = int.Parse(Console.ReadLine());
            }

           
            int max = numb[0];
            int min = numb[0];

           
            for (int i = 1; i < sizes; i++)
            {
                if (numb[i] > max)
                {
                    max = numb[i];
                }
                if (numb[i] < min)
                {
                    min = numb[i];
                }
            }

            
            Console.WriteLine($"\nThe maximum element in the array is: {max}");
            Console.WriteLine($"The minimum element in the array is: {min}");


            #endregion

            #region Q16 Write a program in C# Sharp to find the second largest element in an array.


            Console.Write("Enter the size of the array: ");
            int size1 = int.Parse(Console.ReadLine());

            // Declare an array of the given size
            int[] numbers1 = new int[size1];

            // Ask the user to enter the elements of the array
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size1; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers1[i] = int.Parse(Console.ReadLine());
            }

            // Ensure there are at least two elements
            if (size1 < 2)
            {
                Console.WriteLine("Array must have at least two elements to find the second largest.");
                return;
            }

            // Initialize two variables for largest and second largest
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            
            foreach (int num1 in numbers1)
            {
                if (num1 > largest)
                {
                    secondLargest = largest; // Update second largest
                    largest = num1;           // Update largest
                }
                else if (num1 > secondLargest && num1 < largest)
                {
                    secondLargest = num1;    // Update second largest
                }
            }

            // Check if a second largest element exists
            if (secondLargest == int.MinValue)
            {
                Console.WriteLine("There is no second largest element.");
            }
            else
            {
                Console.WriteLine($"The second largest element in the array is: {secondLargest}");
            }


            #endregion

            #region Q17 Consider an Array of Integer values with size N, having values as in this Example




            Console.Write("Enter the size of the array: ");
            int size4 = int.Parse(Console.ReadLine());

            
            int[] numbers2 = new int[size4];

            
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size4; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers2[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();

            int longestDistance = -1;

            for (int i = 0; i < size2; i++)
            {
                if (firstOccurrence.ContainsKey(numbers2[i]))
                {
                   
                    int distance = i - firstOccurrence[numbers2[i]] - 1;

                   
                    if (distance > longestDistance)
                    {
                        longestDistance = distance;
                    }
                }
                else
                {
                    
                    firstOccurrence[numbers2[i]] = i;
                }
            }

            
            if (longestDistance == -1)
            {
                Console.WriteLine("No equal cells found.");
            }
            else
            {
                Console.WriteLine($"The longest distance between two equal cells is: {longestDistance}");
            }


            #endregion


            #region Q18 Given a list of space separated words, reverse the order of the words.


            Console.Write("Enter a sentence: ");
            string input1 = Console.ReadLine();

            string[] words = input.Split(' ');

            Array.Reverse(words);

            string reversedSentence = string.Join(" ", words);
            Console.WriteLine(reversedSentence);


            #endregion


            #region Q19  Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.



            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            
            int[,] arr1 = new int[rows, cols];
            int[,] arr2 = new int[rows, cols];
 
            Console.WriteLine("Enter the elements of the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element at ({i},{j}): ");
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr2[i, j] = arr1[i, j];
                }
            }

            Console.WriteLine("\nThe second array (copied from the first array) is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();

            }
            #endregion


            #region Q20  Write a Program to Print One Dimensional Array in Reverse Order


            Console.Write("Enter the size of the array: ");
            int size3 = int.Parse(Console.ReadLine());

            int[] number1 = new int[size3];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size3; i++)
            {
                Console.Write($"Element {i + 1}: ");
                number1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe array in reverse order is:");
            for (int i = size3 - 1; i >= 0; i--)
            {
                Console.Write(number1[i] + " ");

            }
                #endregion






        }






    }

    }
    

