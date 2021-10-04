using System;

namespace chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10. Write a program, which finds the most frequently occurring element in an array.
            // Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times).
            /*
            Console.Write("Enter array length: ");
            int userInputArrayLength = Int32.Parse(Console.ReadLine());
            int[] myArray = new int[userInputArrayLength];

            
            for (int i = 0; i < userInputArrayLength; i++)
            {
                Console.Write("Enter {0} element: ", i);
                myArray[i] = Int32.Parse(Console.ReadLine());
            }
            

            Array.Sort(myArray);

            int mostfrequent = 1, timesSeen = 1;
            int result = myArray[0];

            for (int i = 1; i < userInputArrayLength; i++)
            {
                if (myArray[i] == myArray[i - 1])
                    timesSeen++;
                else
                {
                    if (timesSeen > mostfrequent)
                    {
                        mostfrequent = timesSeen;
                        result = myArray[i - 1];
                    }
                    timesSeen = 1;
                }
            }
            Console.WriteLine("Most frequent in array: " + result);
            */
            // 10. <end>

            // 14. Write a program, which finds the longest sequence of equal string elements in a matrix.
            // A sequence in a matrix we define as a set of neighbor elements on the same row, column or diagonal.
            
            int totalRows = 3;
            int totalColumns = 4;
            int longestFoundLength = 0;
            int count = 1;
            string previousString = "";
            string longestStringSequence = "";
            
            string[,] stringArray =
            {
                {"ha","fifi","ho","hi" },
                {"fo", "ha", "fifi", "xx"},
                {"xxx", "ho","heh","fifi" }
            };
            /*
            string[,] stringArray =
            {
                {"s","qq","s" },
                {"pp","pp","s" },
                {"pp","qq","s" }
            };
            */
            //Display Array
            for (int row = 0; row < totalRows; row++)
            {
                for (int column = 0; column < totalColumns; column++)
                {
                    Console.Write(stringArray[row,column] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
            
            //Check for Sequence in Row - Counts Correctly
            for (int row = 0; row < totalRows; row++)
            {
                previousString = "";
                for (int column = 0; column < totalColumns; column++)
                {
                    if (stringArray[row,column] == previousString)
                    {
                        count++;
                        if (count > longestFoundLength)
                        {
                            longestFoundLength = count;
                            longestStringSequence = stringArray[row, column];
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                    previousString = stringArray[row, column];
                }
            }

            //Check for Sequence vertically - Counts correctly
            for (int column = 0; column < totalColumns; column++)
            {
                previousString = "";
                for (int row = 0; row < totalRows; row++)
                {
                    if (stringArray[row, column] == previousString)
                    {
                        count++;
                        if (count > longestFoundLength)
                        {
                            longestFoundLength = count;
                            longestStringSequence = stringArray[row, column];
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                    previousString = stringArray[row, column];
                    
                }
            }

            //Check for Sequence Diagonally
            for (int row = 0; row < totalRows-1; row++)
            {
                for (int column = 0; column < totalColumns-1; column++)
                {
                    if (stringArray[row, column] == stringArray[row+1, column+1])
                    {
                        count++;
                        if (count > longestFoundLength)
                        {
                            longestFoundLength = count;
                            longestStringSequence = stringArray[row, column];
                        }
                    }
                    else
                    {
                        count = 1;
                    }                    
                }
            }

            /*
            for (int row = 0; row < totalRows -1; row++)
            {
                for (int column = 0; column < totalColumns-1; column++)
                {
                    for (int dRow = row, dColumn = column; dRow < totalRows-1 && dColumn < totalColumns-1; dRow++, dColumn++)
                    {
                        if (stringArray[row, column] == stringArray[row + 1, column + 1])
                        {
                            count++;
                            if (count > longestFoundLength)
                            {
                                longestFoundLength = count;
                                longestStringSequence = stringArray[row, column];
                            }
                        }
                        else
                        {
                            count = 1;
                        }

                    }
                }
            }
            */
            Console.WriteLine();
            Console.WriteLine("Previous string = "+previousString);
            Console.WriteLine("Count:"+count);
            Console.WriteLine("The longest string is: " + longestStringSequence);
            Console.WriteLine("It occured " + longestFoundLength + " times");
            
        }
    }
}
