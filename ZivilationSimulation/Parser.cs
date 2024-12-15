using ZivilationSimolation.Simolations;

namespace ZivilationSimolation;

public class Parser
{
    public static void RunWithArgs(String?[] args)
    {
        switch (args[0])
        {
            case null:
                Console.WriteLine("1. Normal(Default) selected");
                SimolationDefault.Run();
                break;
            case "1":
                Console.WriteLine("1. Normal(Default) selected");
                SimolationDefault.Run();
                break;
            case "2":
                Console.WriteLine("2. Debug mode selected");
                break;
            default:
                Console.WriteLine("Wrong argument selected, program terminated.");
                break;
        }
    }
}