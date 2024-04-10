public class OutdoorMeeting : Event
{
    public string WeatherForecast { get; set; }

    public override string GenerateFullDetails()
    {
        return $"{GenerateStandardDetails()}\nWeather Forecast: {WeatherForecast}";
    }
}
