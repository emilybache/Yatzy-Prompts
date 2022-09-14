using System.Linq;

namespace Yatzy_Prompts;

// no need to create this prompt class in your solution
public class Prompt2
{
    // this code should go in a class called YatzyScorer
    public static int Chance(params int[] dice)
    {
        return dice.Sum();
    }
    
}