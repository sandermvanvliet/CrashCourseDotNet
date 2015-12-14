namespace CrashCourseDotNet
{
    public class Exercise4
    {
        public string Execute()
        {
            return "Hello World";
        }
    }

    public class Program4
    {
        public static void Main(string[] args)
        {
            // Add a string parameter to the Execute method
            // and change the method to append it to the returned string
            // String concatenation is done with a + sign:
            // "a" + "b" == "ab"
            Exercise4 exercise = new Exercise4();
            string theValue = exercise.Execute();

            System.Console.WriteLine(theValue);
        }
    }
}