namespace DDF.Core.Ports;

public class Port
{
    public IEnumerable<string>? Concepts { get;}
    public Dictionary<string, object>? Parameters;

    public Port(Dictionary<string, object>? parameters = null, IEnumerable<string>? concepts = null)
    {
        Parameters = parameters;
        Concepts = concepts;
    }
}