namespace dotnet // Note: actual namespace depends on the project name.
{



    class InputDialog // The name of the file
    {
        public void PersonalDetails()
        {
            Console.WriteLine("Enter your first name");
            var FirstName = Console.ReadLine();

            Console.WriteLine("Enter your first name");
            var LaststName = Console.ReadLine();

            Console.WriteLine();


            Console.WriteLine("Your name is: " + FirstName + " " + LaststName);
        }
    }
}