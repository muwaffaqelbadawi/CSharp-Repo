namespace dotnet // Note: actual namespace depends on the (project name).
{


    class TestLogic // File name
    {

        public void LeapYear(int Year)
        {
            if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
            {
                Console.WriteLine("It's a LEAP YEAR :)");
            }
            else
            {
                Console.WriteLine("It's NOT a LEAP YEAR ;(");
            }

        }
    }
}