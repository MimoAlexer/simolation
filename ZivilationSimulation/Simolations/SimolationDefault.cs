using ZivilationSimolation.Date;

namespace ZivilationSimolation.Simolations;

public class SimolationDefault
{
    //Run method
    public static void Run()
    {
        Program.IsRunning = true;
        DateSystem.StartDateSystem();
    }
}