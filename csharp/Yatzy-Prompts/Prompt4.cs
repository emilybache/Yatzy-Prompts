using System.Linq;

namespace Yatzy_Prompts;

// no need to create this prompt class in your solution
public class Prompt4
{
    // this method should be added to the YatzyScorer class
    public static int Yatzy(params int[] dice)
    {
        return dice.Distinct().Count() == 1 ? 50 : 0;
    }
}