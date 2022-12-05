namespace Yatzy_Prompts;

// no need to create this prompt class in your solution
public class Prompt6
{
    // this method should be added to the YatzyScorer class
    public static int DiceFrequency(int number, params int[] dice)
    {
        return dice.Count(d => d == number);
    }
}