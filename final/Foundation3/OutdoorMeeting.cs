public class OutdoorMeeting : Event
{
    private string _weatherForecast;

    public string WeatherForecast
    {
        get { return _weatherForecast; }
        set { _weatherForecast = value; }
    }

    public override string GenerateFullDetails()
    {
        return $"{GenerateStandardDetails()}\nWeather Forecast: {_weatherForecast}";
    }
}
