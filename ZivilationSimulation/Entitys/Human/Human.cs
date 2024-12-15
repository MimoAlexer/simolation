namespace ZivilationSimolation.Entitys.Human;
public class Human
{
    public int Age { get; set; }
    public int Id { get; set; }
    public int Happiness { get; set; }
    public Human? Mother { get; set; }
    public Human? Father { get; set; }
    public bool IsDead { get; set; }
    public int Health { get; set; }
    public Gender Gender { get; set; }
    
    //Creating human method
    public Human NewHuman(Human? mother, Human? father, int age, int? happiness)
    {
        //Needed var return
        Health = 100;
        Age = age;
        IsDead = false;
        Id = HumanList.Humans.Count;
        
        //Return parents
        if(mother != null)
            Mother = mother;
        
        if(father != null)
            Father = father;
        
        //Return Happiness
        if (happiness == null)
        {
            Happiness = 50;
        }
        else
        {
            Happiness = (int)happiness;
        }

        //Add human to list
        HumanList.Humans.Add(this);
        
        //Return human
        return this;
    }
    
    //Human dies method
    public void Die()
    {
        //Changing Variables
        IsDead = true;
        Health = 0;
        
        //Remove/Add Human to List
        HumanList.Humans.Remove(this);
        HumanList.DeadHumans.Add(this);
    }
    
    public static void Marry(Human male, Human female)
    {
        
    }
}