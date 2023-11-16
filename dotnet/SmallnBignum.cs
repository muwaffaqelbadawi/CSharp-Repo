namespace dotnet // Note: actual namespace depends on the (project name).
{
    class SmallnBignum // File name
    {
        int[] numArr = { 7, 5, 2, 4, 3, 9 };

        public void FindSmallestNum()
        {
            int biggestNum = numArr[0];
            int smallestNum = numArr[0];

            foreach (int num in numArr)
            {
                if (num > biggestNum)
                    biggestNum = num;

                else if (num < smallestNum)
                    smallestNum = num;
            }


            Console.WriteLine("The biggest number is: {0}", biggestNum);
            Console.WriteLine("The smallest number is: {0}", smallestNum);
        }
    }
}