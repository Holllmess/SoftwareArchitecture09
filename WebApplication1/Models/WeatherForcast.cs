namespace WebApplication1.Models
{
    public class WeatherForecast
    {

        /*private DateTime _date;
        public DateTime GetDate()
        {
            return _date;
        }

        public void SetDate(DateTime date)
        {
           _date = date;
        }
        */

        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF
        {
            get { return 32 + (int)(TemperatureC / 0.5556); }
        }

        public WeatherForecast(DateTime date, int temperatureC)
        {
            Date = date;
            TemperatureC = temperatureC;   
        }


    }
}
