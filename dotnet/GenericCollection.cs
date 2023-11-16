


namespace dotnet // Note: actual namespace depends on the project name.
{

    class GenericCollection // This is the name of the file
    {
        public void example()
        {

            // Simple_Collection

            
            // Create a list of strings.
            var salmons = new List<string>();

            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");

            }
            // Output: chinook coho pink sockeye

        }
    }

}