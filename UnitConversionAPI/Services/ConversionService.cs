using UnitConversionAPI.Models;

namespace UnitConversionAPI.Services;

public class ConversionService : IConversionService
{
    public ConversionResponse Convert(ConversionRequest request)
    {
        double result = 0;

        switch (request.Category.ToLower())
        {
            case "length":
                result = ConvertLength(
                    request.Value,
                    request.FromUnit.ToLower(),
                    request.ToUnit.ToLower());
                break;

            case "weight":
                result = ConvertWeight(
                    request.Value,
                    request.FromUnit.ToLower(),
                    request.ToUnit.ToLower());
                break;

            case "temperature":
                result = ConvertTemperature(
                    request.Value,
                    request.FromUnit.ToLower(),
                    request.ToUnit.ToLower());
                break;

            default:
                throw new Exception("Invalid Category");
        }

        return new ConversionResponse
        {
            OriginalValue = request.Value,
            FromUnit = request.FromUnit,
            ToUnit = request.ToUnit,
            ConvertedValue = result
        };
    }

    private double ConvertLength(double value, string from, string to)
    {
        if (from == "meter" && to == "foot")
            return value * 3.28084;

        if (from == "foot" && to == "meter")
            return value / 3.28084;

        return value;
    }

    private double ConvertWeight(double value, string from, string to)
    {
        if (from == "kilogram" && to == "pound")
        {
            return value * 2.20462;
        }

        if (from == "pound" && to == "kilogram")
            return value / 2.20462;

        return value;
    }

    private double ConvertTemperature(double value, string from, string to)
    {
        if (from == "celsius" && to == "fahrenheit")
            return (value * 9 / 5) + 32;

        if (from == "fahrenheit" && to == "celsius")
            return (value - 32) * 5 / 9;

        return value;
    }
}