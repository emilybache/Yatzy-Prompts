namespace Yatzy_Prompts;

public class YatzyScorer
{
    public static int MIN_DICE_VALUE = 1;
    public static int MAX_DICE_VALUE = 6;

    public static int Chance(params int[] dice)
    {
        return dice.Sum();
    }

    public static int Yatzy(params int[] dice)
    {
        return dice.Distinct().Count() == 1 ? 50 : 0;
    }

    public static int Ones(params int[] dice)
    {
        var diceFrequencies = DiceFrequencies(dice);
        return diceFrequencies[1];
    }

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