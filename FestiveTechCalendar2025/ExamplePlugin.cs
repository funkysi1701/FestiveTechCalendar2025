using Microsoft.SemanticKernel;

namespace FestiveTechCalendar2025;

public class ExamplePlugin
{
    [KernelFunction]
    public int GenerateHash(string input)
    {
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input));
        }
        var hash = input.GetHashCode();

        return hash > 0 ? 0 : 1;
    }
}
