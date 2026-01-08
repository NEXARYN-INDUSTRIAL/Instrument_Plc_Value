using Instrument_Plc_Calc.Interfaces;

namespace Instrument_Plc_Calc.Services;

public class CalculationServices : IScalingMath
{

    public double SignalToEngineering(double mA, double engmin, double engmax)
    {
        double engineeringUnit = ((mA - 4) * (engmax - engmin)) / 16 + engmin;

        return engineeringUnit;

    }
}