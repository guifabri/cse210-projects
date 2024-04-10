using System;

class Program
{
    static void Main()
    {
        Conference conferenceEvent = new Conference
        {
            Title = "Tech Conference",
            Description = "Annual tech conference",
            Date = "2023-09-15",
            Time = "10:00 AM",
            Address = "123 Main St",
            Speaker = "John Doe",
            Capacity = 100
        };

        Reception receptionEvent = new Reception
        {
            Title = "Networking Reception",
            Description = "Casual networking event",
            Date = "2023-10-20",
            Time = "6:00 PM",
            Address = "456 Elm St",
            ConfirmationEmail = "confirm@example.com"
        };

        OutdoorMeeting outdoorMeetingEvent = new OutdoorMeeting
        {
            Title = "Team Building Outdoor Meeting",
            Description = "Team building session",
            Date = "2023-11-05",
            Time = "2:00 PM",
            Address = "789 Oak St",
            WeatherForecast = "Sunny skies"
        };

        Console.WriteLine(conferenceEvent.GenerateFullDetails());
        Console.WriteLine(receptionEvent.GenerateFullDetails());
        Console.WriteLine(outdoorMeetingEvent.GenerateFullDetails());
    }
}
