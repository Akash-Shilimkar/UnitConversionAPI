using UnitConversionAPI.Models;

namespace UnitConversionAPI.Services;

public interface IConversionService
{
    ConversionResponse Convert(ConversionRequest request);
}