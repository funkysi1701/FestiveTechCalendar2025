using Microsoft.SemanticKernel;

namespace FestiveTechCalendar2025;

public class ExamplePlugin
{
    [KernelFunction]
    public int GenerateHash(string input)
    {
        var hash = input.GetHashCode();

        return hash > 0 ? 0 : 1;
    }
}
