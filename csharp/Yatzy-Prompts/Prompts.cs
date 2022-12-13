using NUnit.Framework;
namespace Yatzy_Prompts;
public class Prompts
{
    
    // Prompt 1
    // this test case should go in a class called YatzyScorerTest
    [Test]
    public void Chance_scores_sum_of_all_dice()
    {
        Assert.AreEqual(16, YatzyScorer.Chance(3, 3, 4, 5, 1));
    }
    
    // Prompt 2
    // this code should go in a class called YatzyScorer
    public static int Chance(params int[] dice)
    {
        return dice.Sum();
    }
    
    
    // Prompt 3
    // this test case should be added to YatzyScorerTest
    [Test]
    public void Yatzy_scores_50_when_all_dice_the_same()
    {
        Assert.AreEqual(0, YatzyScorer.Yatzy(1,2,4,5,6));
        Assert.AreEqual(50, YatzyScorer.Yatzy(5,5,5,5,5));
    }
    
    
    // Prompt 4
    // this method should be added to the YatzyScorer class
    public static int Yatzy(params int[] dice)
    {
        return dice.Distinct().Count() == 1 ? 50 : 0;
    }

    
    // Prompt 5
    // this test case should be added to YatzyScorerTest
    [Test]
    public void DiceFrequency_gives_how_many_of_a_particular_dice_number_is_present()
    {
        Assert.AreEqual(2, YatzyScorer.DiceFrequency(3, 1, 2, 3, 3, 5));
    }
    
    // Prompt 6
    // this method should be added to the YatzyScorer class
    public static int DiceFrequency(int number, params int[] dice)
    {
        return dice.Count(d => d == number);
    }
    
    
    
    
    
    
    
    
    // Prompt 7
    [Test]
    public void DiceFrequencies_gives_how_many_of_each_dice_is_present()
    {
        CollectionAssert.AreEquivalent(new Dictionary<int, int>()
            {
                { 1, 0 }, { 2, 5 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }
            }, 
            YatzyScorer.DiceFrequencies(2,2,2,2,2));

        CollectionAssert.AreEquivalent(new Dictionary<int, int>()
            {
                { 1, 1 }, { 2, 1 }, { 3, 1 }, { 4, 1 }, { 5, 1 }, { 6, 0 }
            },
            YatzyScorer.DiceFrequencies(1, 2, 3, 4, 5));
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    // Prompt 8
    // these fields and this method should be added to the YatzyScorer class
    public static int MIN_DICE_VALUE = 1;
    public static int MAX_DICE_VALUE = 6;
    public static Dictionary<int, int> DiceFrequencies(params int[] dice)
    {
        var diceFrequencies = new Dictionary<int, int>();
        for (int i = MIN_DICE_VALUE; i <= MAX_DICE_VALUE; i++)
        {
            diceFrequencies.Add(i, YatzyScorer.DiceFrequency(i, dice));
        }

        return diceFrequencies;
    }
    
    
    
}