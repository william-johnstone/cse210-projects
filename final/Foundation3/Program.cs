class Program
{
    static void Main()
    {
        // Creating addresses
        Address lectureAddress = new Address("123 University St", "College Town", "CA", "USA");
        Address receptionAddress = new Address("456 Celebration Ave", "Party City", "NY", "USA");
        Address outdoorGatheringAddress = new Address("789 Park Blvd", "Open Space", "FL", "USA");

        // Creating events
        Lecture lectureEvent = new Lecture("Tech Talk", "Exciting tech discussion", DateTime.Now.AddDays(10), new TimeSpan(15, 30, 0), lectureAddress, "John Doe", 50);
        Reception receptionEvent = new Reception("Networking Mixer", "Casual networking event", DateTime.Now.AddDays(20), new TimeSpan(18, 0, 0), receptionAddress, "rsvp@example.com");
        OutdoorGathering outdoorGatheringEvent = new OutdoorGathering("Summer Picnic", "Enjoy outdoor activities", DateTime.Now.AddDays(30), new TimeSpan(12, 0, 0), outdoorGatheringAddress, "Sunny with a slight breeze");

        // Displaying marketing messages for each event
        Console.WriteLine(lectureEvent.GenerateStandardDetails());
        Console.WriteLine(lectureEvent.GenerateFullDetailsForLecture());
        Console.WriteLine(lectureEvent.GenerateShortDescription());

        Console.WriteLine(receptionEvent.GenerateStandardDetails());
        Console.WriteLine(receptionEvent.GenerateFullDetailsForReception());
        Console.WriteLine(receptionEvent.GenerateShortDescription());

        Console.WriteLine(outdoorGatheringEvent.GenerateStandardDetails());
        Console.WriteLine(outdoorGatheringEvent.GenerateFullDetailsForOutdoorGathering());
        Console.WriteLine(outdoorGatheringEvent.GenerateShortDescription());
    }
}