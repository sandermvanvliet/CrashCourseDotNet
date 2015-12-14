namespace CrashCourseDotNet
{
    public class Exercise5
    {
        public string Execute()
        {
            return "Hello World";
        }
    }

    public class Program5
    {
        public static void Main(string[] args)
        {
            // Change the Execute method to only concatenate the string
            // if the parameter equals "I know C#"

            // Hint: the previous line should point you in the direction which language feature you should use

            Exercise5 exercise = new Exercise5();
            string theValue = exercise.Execute();

            System.Console.WriteLine(theValue);
        }
    }
}