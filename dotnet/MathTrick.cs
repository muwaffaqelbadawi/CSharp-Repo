namespace dotnet // Note: actual namespace depends on the project name.
{
    class MathTrick
    {
        int[] numbers = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };  // the actual number, with fixed length
        int[] squares = new int[9] { 1, 4, 9, 16, 25, 36, 49, 64, 81 };  // the perfect square of the number, with fixed length
        int[] lastDigit = new int[9] { 1, 4, 9, 6, 5, 6, 9, 4, 1 };  // [lastDigit] number of the perfect square, with fixed length

        // array of all digits of the num given in the sequence, length not specified
        int[] numCollection = new int[] { }; // the user can enter perfect number of any length (now 3 and 4)

        int tensOrderNum = 0; // initial value of 10s num provided in the sequence
        int thousandsOrderNum = 0; // initial value of 1000s num provided in the sequence

        int[] tensNumsArray = new int[2]; // probability of the nums that could be 10s order in the result, with fixed length

        int tensNum = 0;
        int thousansNum = 0;



        





        // This function will check whether the num entered is perfect square or not
        public void perfectSqrtCheck(string sequence)
        {
            int tensNum = perfectSquare(sequence)[0];
            int thousandNum = perfectSquare(sequence)[1];

            double result = double.Parse(String.Concat(tensNum.ToString() + thousandNum.ToString()));
            // I miss python (result**2)
            double perfectSqrt = Math.Pow(result, 2);
            string perfectSqrtStr = perfectSqrt.ToString();



            Console.WriteLine("The result is: " + perfectSqrtStr);


            if (perfectSqrtStr == sequence)
                Console.WriteLine("Perfecto This a perfect square :)");

            else
                Console.WriteLine("not perfecto this number isn't a perfect square ;(");
        }






        /*

            Now we have to check if the number is three consist of digits or bigger

        */

        // function checks the length of the entered sequence
        // and according to that decide the parsing process
        public void lengthCheck(string sequence)
        {
            int seqLength = sequence.Length;

            // if entered num is exactly three digits
            if (seqLength == 3)
                // if the length of the sequence is exactly three start from index 0
                parsNumSequence(sequence, 0); // parsNumSequence(sequennce, startingIndex)

            // if the entered num more than three digits (4 digits)
            else if (seqLength > 3)
                // start from the 3rd index
                parsNumSequence(sequence, 2); // parsNumSequence(sequennce, startingIndex)
        }




        /*
        
            CLEAN CODE

            EVERY FUNCTION HAS TO HAVE ONLY ONE PURPOSE TO BE EFFICIENT!!
            a function should do one thing, and only one thing

            “Functions should do something, or answer something, but not both.”

       */


        // function convert each digit of the sequence from char to integer
        // then appending it to numCollection
        public void parsNumSequence(string sequence, int startingIndex)
        {

            /*

                THIS IS A REUSABLE FUNCTION
            
            */


            if (startingIndex > 0)
            {
                int digit = int.Parse(String.Concat(sequence[0].ToString() + sequence[1].ToString()));
                numCollection = numCollection.Append(digit).ToArray();
            }

            for (int chrIndex = startingIndex; chrIndex < sequence.Length; chrIndex++)
            {

                // parsing string to integer (48 is the ASCII code for "0")
                int digit = sequence[chrIndex] - 48;

                // appending the digits to numCollection
                numCollection = numCollection.Append(digit).ToArray();
            }
        }





        /*
            numbers       squares       lastDigit
               1             1              1
               2             4              4
               3             9              9
               4             16             6
               5             25             5
               6             36             6
               7             49             9
               8             64             4
               9             81             1
        */




        /*
            Step One:
               We have to look at the first num in the sequence (the num in the very right) in [lastdigit]
               and then locate the corresponding nums in [numbers] to [tensNumsArray]
        */




        // order is the No. oif zeros in 10s
        public void calculateTensOrder(int order)
        {
            // locate the 10s Digit (the first num on the right)
            tensOrderNum = numCollection[numCollection.Length - order];


            int index = 0; // local index to track tensNumsArray indices
            int tensDigit = 0; // initial value of tensDigit

            // loop through the [lastDigit] for 10s digit match (first num on the right)
            for (int i = 0; i < lastDigit.Length; i++)
            {
                // if found in [lastDigit]
                if (lastDigit[i] == tensOrderNum)
                {
                    // append its corresponding value in [numbers] to [tensNumsArray]
                    tensDigit = numbers[i];
                    tensNumsArray[index] = tensDigit;

                    // increase index of [tensNumsArray]
                    index += 1;
                }
            }
        }






        /*
           Step Two:
               We have to look at the [squares] and locate the third num of the sequence
               to match exact num in [squares] or if not found the num just bellow it 
        */




        // This function is look at the 1000s num in [squares] and locates the corresponding of the exact value
        //  in [numbers] if found or otherwise the num just bellow (order is the No. of zeros in 1000s) of te result
        public void calculateThousandsOrder(int order)
        {
            if (order == 3)
            {
                // locate the 1000s digit in the given sequence
                thousandsOrderNum = numCollection[numCollection.Length - order];

                for (int i = 0; i < squares.Length; i++)
                {
                    // if the 1000s num found in [square]
                    if (squares[i] == thousandsOrderNum)

                        // append it to thousandsNumIndices array
                        thousansNum = numbers[i];

                    // else if not found the exact num
                    else if (squares[i] > thousandsOrderNum && squares[i - 1] < thousandsOrderNum)

                        // assign the num just bellow it to thousansNum
                        thousansNum = numbers[i - 1];
                }
            }
        }





        //  I LOVE STRAIGHT FORWORDNESS IN PROGRAMMING DO NOT EVER OVER COMPLICATE THINGS


        /*
           Step Three:
               Multiply thousansNum by its next num
        */

        public void CalculateTensNum()
        {
            // multiply rootOfTheCorrespondingSqrt by its next num
            // local variable for the sake of calculation
            int productResult = thousansNum * (thousansNum + 1);

            // if the result of the product is greater than thousandsOrderNum then
            if (productResult > thousandsOrderNum)

                // the Min num of the the perfect square is the minimum of [tensNumsArray]
                tensNum = tensNumsArray.Min();

            // if the result of the product is less than thousandsOrderNum
            else

                // the Max sum of the the perfect square is the minimum of [tensNumsArray]
                tensNum = tensNumsArray.Max();
        }








        // Here is where all the functions come together
        public int[] perfectSquare(string sequence)
        {
            
            lengthCheck(sequence); // check the length of the sequence
            calculateTensOrder(1); // nums of zeros in 10's order
            calculateThousandsOrder(3); // nums of zeros in 10's order
            CalculateTensNum();


            int[] result = new int[2] {thousansNum, tensNum};
            return result;
        }
    }
}