namespace A02
{
   /* 
     PROJECT: PROG1385 - Assignment 2: Collections and Generics
     PROGRAMMER: Rachit PAtel
     FIRST VERSION: 26/1/2025
     DESCRIPTION:This program generates random numbers and stores it in a List<>,
     and calculates the sum and average of the numbers. */
    internal class Program
    {
        // FUNCTION: CalculateSum
        // DESCRIPTION: Calculates the sum of all integers in a List<>.
        // PARAMETERS:List<int> Randomnumbers:The list of integers to process.
        // RETURNS : sum: The sum of all integers in the list.
        static int CalculateSum(List<int> Randomnumbers)
        {
            int sum = 0;
  
            foreach (int number in Randomnumbers)
            {
                // Add each number to the sum Integer
                sum = sum+ number;
            }
            //Return The value of sum
            return sum;
        }
        // FUNCTION: CalculateAverage
        // DESCRIPTION: Calculates the average of integers in a List<>.
        // PARAMETERS:1) List<int> Randomnumbers: The list of integers to process.
        //            2) int Count: The total number of integers in the list.
        // RETURNS: double: The average of the integers.
        static double CalculateAverage(List<int> Randomnumbers,int Count)
        {
            //Call the function CalcuateSum to get an value of sum
            int sum = CalculateSum(Randomnumbers);
            //Calculate the average of an item and store it a double result
            double result = sum / Count;
            //Return the result of average
            return result;
        }
        static void Main(string[] args)
        {
            // Declare a Number of random numbers to generate
            const int NumberofRandomNumber = 5;
            //Declare the Minimum random number of the range
            const int minNumber = 1;
            //Declare the Maximum random number of the range
            const int maxNumber = 100;
            //Created a list name RandomNumber to 
            List<int> RandomNumber = new List<int>();
            //Used Random class to generate randomnumber
            Random random = new Random();
            //Declare a for loop to genrate random number multiple time as defined in constant value
            for (int i = 0; i < NumberofRandomNumber; i++)
            {
                //The statement create an randomNumber and store them in the variable
                int RandomNumber_creator = random.Next(minNumber, maxNumber);
                //This store the Random number into the list
                RandomNumber.Add(RandomNumber_creator);
            }
            Console.WriteLine("Report");
            //Print the number of item in the list
            Console.WriteLine("Number of items in the List:"+NumberofRandomNumber);
            //Called the function calculatesum and store the value of sum in variable
            int SumofList = CalculateSum(RandomNumber);
            Console.WriteLine("Sum of items in the List:"+SumofList);
            //Called the function CalculateAverage and store them in the variable 
            double Average = CalculateAverage(RandomNumber,NumberofRandomNumber);
            Console.WriteLine("Average of items in the List:"+Average);

        }
    }
}
