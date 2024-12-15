namespace ZivilationSimolation;

class Program
{
    public static bool IsRunning = false;

    public static void Main(String[] args)
    {
        if (args.Length > 0)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Index [{i}] Argument: {args[i]} ");   
            }
        }
        else
        {
            Console.WriteLine("No arguments found.");
        }

        Parser.RunWithArgs(args);
    }
}
