namespace dotnet // Note: actual namespace depends on the (project name).
{
    class Test // File name
    {

        /*

        public void testNewConcept()
        {
            IEnumerable<A> list = new List<B>() { new B() };
            IList<AbandonedMutexException> readOnlyList = new List<B>();

        class A { }

        class B : A { }

        */


        public int[] args()
        {

            int[] args = new int[2] { 1, 2 };


            return args;
        }




        public int retu()
        {
            int test = 0;


            return test;

        }




        public void Display()
        {

            int x = args()[0];
            int y = args()[1];



            Console.WriteLine(x);
            Console.WriteLine(retu());
        }
    }
}