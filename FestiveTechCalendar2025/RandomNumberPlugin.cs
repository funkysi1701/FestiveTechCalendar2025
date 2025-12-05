using Microsoft.SemanticKernel;

namespace FestiveTechCalendar2025;

public class RandomNumberPlugin
{
    [KernelFunction]
    public int GenerateRandom()
    {
        return GetRnd().Next(0, 2);
    }

    private static Random GetRnd()
    {
        return new Random();
    }
}
