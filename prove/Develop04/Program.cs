using System;

class Program
{
    //This is a string array of the activities
    public static string[] Activities()
    {
        string[] activity = {"Breathing", "Reflecting", "Listing", "Quit"};
        return activity;
    }
    static void Main(string[] args)
    {
        short _menuOption = 0;
        string invalid;
        
        while (_menuOption != 4)
        {
            string[] activity = Activities();
            Console.Clear();
            Console.WriteLine($"1 - {activity[0]}");
            Console.WriteLine($"2 - {activity[1]}");
            Console.WriteLine($"3 - {activity[2]}");
            Console.WriteLine($"4 - {activity[3]}");
            while(!Int16.TryParse(invalid=Console.ReadLine(), out _menuOption))
            {
                Console.WriteLine($"{invalid} is not valid...");
            }
            _menuOption = Convert.ToInt16(_menuOption);

            if (_menuOption == 1)
            {
                Activity act1 = new Activity();
                int ut = act1.CommonStart(_menuOption);
                Breathing breathing = new Breathing();
                breathing.BreathingStart(ut);
            }
            else if (_menuOption == 2)
            {
                Activity act1 = new Activity();
                int ut = act1.CommonStart(_menuOption);
                Reflecting refl1 = new Reflecting();
                refl1.ReflectingStart(ut);
            }
            else if (_menuOption == 3)
            {
                Activity act1 = new Activity();
                act1.CommonStart(_menuOption);
            }
            else if (_menuOption == 4)
            {
                Console.WriteLine("Goodbye.");
                break;
            }
            else
            {
                Console.WriteLine("Pick a number 1 through 4.");
            }
        }        
    }

}