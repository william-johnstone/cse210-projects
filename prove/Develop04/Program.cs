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
        
        static void Menu(int activityLength)
        {
            int i = 0;
            string[] menuActivity = Activities();
            Console.WriteLine("Menu Options: ");
            while (i < activityLength)
            {
                Console.WriteLine($"   {i+1} - {menuActivity[i]}");
                i++;
            }

        }
        
        while (_menuOption != 4)
        {
            string[] activity = Activities();
            int _activityLength;
            _activityLength = activity.Count();
            Console.Clear();
            Menu(_activityLength);
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
                int ut = act1.CommonStart(_menuOption);
                Listing list1 = new Listing();
                list1.ReflectingStart(ut);
            }
            else if (_menuOption == 4)
            {
                Console.Clear();
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