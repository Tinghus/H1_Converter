namespace H1_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit Converter \n");

            Console.WriteLine("Which unit type do you want to convert? \n" +
                " 1) Kilometer to Mile \n" +
                " 2) Mile to Kilometer \n" +
                " 3) Celsius to Fahrenheit \n" +
                " 4) Fahrenheit to Celsius \n" +
                " 5) Meters to Yards \n" +
                " 6) Yards to Meters \n"
                );

            string conversionType = "unset";

            do
            {
                Console.Write("Option : ");
                char optionSelected = Console.ReadKey().KeyChar;
                conversionType = GetConversionType(optionSelected);

            } while (conversionType == "unset");

            double valueToConvert = 0;
            bool inputValid = false;

            do
            {
                Console.Write($"\n{conversionType}(s): ");
                inputValid = double.TryParse(Console.ReadLine(), out valueToConvert);

                if (!inputValid)
                {
                    Console.WriteLine("Error in input. Try again!.");
                }

            } while (!inputValid);

            string result = ConvertValue(valueToConvert, conversionType);

            Console.WriteLine($"Converted {Convert.ToString(valueToConvert)} {conversionType} to {result}");
            Console.ReadKey();
            Console.CursorVisible = false;
        }

        static string GetConversionType(char optionSelected)
        {

            switch (optionSelected)
            {
                case '1':
                    return "kilometer";

                case '2':
                    return "mile";

                case '3':
                    return "celcius";

                case '4':
                    return "fahrenheit";

                case '5':
                    return "meter";

                case '6':
                    return "yard";

                default:
                    Console.WriteLine("\nThe selected option is not valid. try again \n");
                    return "unset";
            }
        }
        static string ConvertValue(double valueToConvert, string conversionType)
        {

            switch (conversionType)
            {
                case "kilometer":
                    return ConvertFromKilometerToMile(valueToConvert);

                case "mile":
                    return ConvertFromMileToKilometer(valueToConvert);

                case "celsius":
                    return ConvertFromCelciusToFahrenheit(valueToConvert);

                case "fahrenheit":
                    return ConvertFromFahrenheitToCelcius(valueToConvert);

                case "meter":
                    return ConvertFromMeterToYard(valueToConvert);

                case "yard":
                    return ConvertFromYardToMeter(valueToConvert);
            }

            return "";
        }

        static string ConvertFromKilometerToMile(double valueToConvert)
        {
            return (valueToConvert / 1.609).ToString("#.##") + " mile";
        }

        static string ConvertFromMileToKilometer(double valueToConvert)
        {
            return (valueToConvert * 1.609).ToString("#.##") + " kilometers";
        }

        static string ConvertFromCelciusToFahrenheit(double valueToConvert)
        {
            return ((valueToConvert * 9) / 5 + 32).ToString("#.##") + " fahrenheit";
        }

        static string ConvertFromFahrenheitToCelcius(double valueToConvert)
        {
            return ((valueToConvert - 32) * 5 / 9).ToString("#.##") + " celcius";
        }

        static string ConvertFromMeterToYard(double valueToConvert)
        {
            return (valueToConvert * 1.0936).ToString("#.##") + " yard";
        }

        static string ConvertFromYardToMeter(double valueToConvert)
        {
            return (valueToConvert / 1.0936).ToString("#.##") + " meter";
        }
    }
}