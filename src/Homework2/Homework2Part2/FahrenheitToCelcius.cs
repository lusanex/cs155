namespace Homework2.Homework2Part2
{
    
    public class FahrenheitToCelcius
    {
        public void Run(string[]? args = null)
        {
             Console.Write("Enter a temperature in degrees Fahrenheit: ");
            if (double.TryParse(Console.ReadLine(), out double degreesF))
            {

                double degreesC = FahToCelsius(degreesF);
                Console.WriteLine($"{degreesF} degrees Fahrenheit = {degreesC} degrees Celsius");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }


        }

        double FahToCelsius(double degreesF)
        {
            double degreesC = 5 * (degreesF - 32) / 9;
            return Math.Round(degreesC, 1);

        }
    }
}
