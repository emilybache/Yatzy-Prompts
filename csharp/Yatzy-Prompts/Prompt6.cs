namespace Yatzy_Prompts;

// no need to create this prompt class in your solution
public class Prompt6
{
    // these fields and this method should be added to the YatzyScorer class
    public static int MIN_DICE_VALUE = 1;
    public static int MAX_DICE_VALUE = 6;
    public static Dictionary<int, int> DiceFrequencies(params int[] dice)
    {
        var diceFrequencies = new Dictionary<int, int>();
        for (int i = MIN_DICE_VALUE; i <= MAX_DICE_VALUE; i++)
        {
            diceFrequencies.Add(i, dice.Count(d => d == i));
        }

        return diceFrequencies;
    }
}