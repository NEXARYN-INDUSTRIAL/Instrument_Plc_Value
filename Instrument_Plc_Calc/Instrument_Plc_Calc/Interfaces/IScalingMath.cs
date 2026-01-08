namespace Instrument_Plc_Calc.Interfaces;

public interface IScalingMath
{
    // double EngineeringToSignal();
    double SignalToEngineering(double mA, double engmin, double engmax);
//     double EngineeringToRaw();
//     double RawToEngineering();
//     double SignalToRaw();
//     double RawToSignal();
//     double Span();
}