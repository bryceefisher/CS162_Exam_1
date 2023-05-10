using Professor;

namespace Professor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Professor test methods
            TestConstructors();
            Console.WriteLine("--------------------------------------------------------------------");
            TestToString();
            Console.WriteLine("--------------------------------------------------------------------");
            TestPropertyGetters();
            Console.WriteLine("--------------------------------------------------------------------");
            TestPropertySetters();
            

        }
        //test both constructors
        static void TestConstructors()
        {
            Professor p1 = new Professor();
            Professor p2 = new Professor(123456789, "John", "Doe", "Computer Science");

            Console.WriteLine("Expecting default values: " + p1.ToString());
            Console.WriteLine("Overloaded Constructor: " + p2.ToString());
        }
        //test ToString
        static void TestToString()
        {
            Professor p1 = new Professor(123456789, "John", "Doe", "Computer Science");

            Console.WriteLine("Expecting 123456789, John, Doe, Computer Science: " + p1.ToString());
        }
        //test getters
        static void TestPropertyGetters()
        {
            Professor p1 = new Professor(123456789, "John", "Doe", "Computer Science");

            Console.WriteLine("Expecting 123456789: " + p1.LNumber);
            Console.WriteLine("Expecting John: " + p1.FirstName);
            Console.WriteLine("Expecting Doe: " + p1.LastName);
            Console.WriteLine("Expecting Computer Science: " + p1.Department);
        }
        //test setters
        static void TestPropertySetters()
        {
            Professor p1 = new Professor(123456789, "John", "Doe", "Computer Science");

            p1.LNumber = 987654321;
            p1.FirstName = "Jane";
            p1.LastName = "Smith";
            p1.Department = "Math";

            Console.WriteLine("Expecting 987654321: " + p1.LNumber);
            Console.WriteLine("Expecting Jane: " + p1.FirstName);
            Console.WriteLine("Expecting Smith: " + p1.LastName);
            Console.WriteLine("Expecting Math: " + p1.Department);
            Console.WriteLine("--------------------------------------------------------------------");
            //test setter validation
            Console.WriteLine("Testing Setter Validation");
            Console.WriteLine("Expecting error: ");
            p1.LNumber = 12345678;
        }
        
    }
}