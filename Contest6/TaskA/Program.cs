using System;

class Program
{
    static void Main(string[] args)
    {
        string[] temperatureParams = Console.ReadLine().Split(' ');
        string temperatureType = temperatureParams[0];
        double startTemperatureValue = double.Parse(temperatureParams[1]);
        try
        {
            switch (temperatureType)
            {
                case "C":
                    Console.WriteLine(TemperatureCalculator.FromCelsiusToFahrenheit(startTemperatureValue));
                    Console.WriteLine(TemperatureCalculator.FromCelsiusToKelvin(startTemperatureValue));
                    break;
                case "F":
                    Console.WriteLine(TemperatureCalculator.FromFahrenheitToCelsius(startTemperatureValue));
                    Console.WriteLine(TemperatureCalculator.FromFahrenheitToKelvin(startTemperatureValue));
                    break;
                case "K":
                    Console.WriteLine(TemperatureCalculator.FromKelvinToCelsius(startTemperatureValue));
                    Console.WriteLine(TemperatureCalculator.FromKelvinToFahrenheit(startTemperatureValue));
                    break;
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
