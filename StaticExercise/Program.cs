namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"51\u00B0 F converted to Celsius: {TempConverter.FahrenheitToCelcius(51)}\u00B0 C");

            Console.WriteLine($"14\u00B0 C converted to Fahrenheit: {TempConverter.CelciusToFahrenheit(14)}\u00B0 F");
        }
    }
}
