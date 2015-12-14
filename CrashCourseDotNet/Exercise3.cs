namespace CrashCourseDotNet
{
    public class Exercise3
    {
        public string Execute()
        {
            return "Hello World";
        }
    }

    public class Program3
    {
        public static void Main(string[] args)
        {
            // Assign the value that Execute returns to a variable
            Exercise3 exercise = new Exercise3();
            exercise.Execute();
        }
    }
}