namespace Instrument_Plc_Calc.Model;

public class Instrument
{
    public string? SignalType { get; set; }
    public double LowerRangeValue{ get; set; }
    public double UpperRangeValue{ get; set; }
    public double Span{ get; set; }
}