using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        
        Running running = new Running(30, 3);
        

        Biking biking = new Biking(15, 30);
        

        Swimming swimming = new Swimming(5, 10);
        
        activities.Add(running);
        activities.Add(biking);
        activities.Add(swimming);


        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }


}