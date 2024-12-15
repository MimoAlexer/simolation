namespace ZivilationSimolation.Entitys.Human;

public class HumanFramework
{
    public static void StartHumanFramework()
    {
        while (Program.IsRunning)
        {
            foreach (Human human in HumanList.Humans)
            {
                //human have over 60 a 50% chance of 
                if (human.Age >= 60)
                {
                    Random random = new Random();
                    if (random.Next(0, 1) == 1)
                    {
                        human.Die();
                    }
                }
                //TODO: Implement childbirth and marry
            }
        }
    }
}