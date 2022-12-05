using NUnit.Framework;

namespace Yatzy_Prompts;

public class YatzyScorerTest
{
    [Test]
    public void Chance_scores_sum_of_all_dice()
    {
        Assert.AreEqual(16, YatzyScorer.Chance(3, 3, 4, 5, 1));
    }
    
    [Test]
    public void Yatzy_scores_50_when_all_dice_the_same()
    {
        Assert.AreEqual(0, YatzyScorer.Yatzy(1,2,4,5,6));
        Assert.AreEqual(50, YatzyScorer.Yatzy(5,5,5,5,5));
    }
    
    [Test]
    public void DiceFrequencies_stores_how_many_of_each_dice_number_is_present()
    {
        Assert.AreEqual(new Dictionary<int, int>()
            {
                { 1, 0 }, { 2, 5 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }
            }, 
            YatzyScorer.DiceFrequencies(2,2,2,2,2));        
        
        Assert.AreEqual(new Dictionary<int, int>()
            {
                { 1, 1 }, { 2, 1 }, { 3, 1 }, { 4, 1 }, { 5, 1 }, { 6, 0 }
            }, 
            YatzyScorer.DiceFrequencies(1,2,3,4,5));
        
    }
    
    [Test]
    public void DiceFrequency_gives_how_many_of_a_particular_dice_number_is_present()
    {
        Assert.AreEqual(2, YatzyScorer.DiceFrequency(3, 1, 2, 3, 3, 5));
    }

    [Test]
    public void DiceFrequencies_gives_how_many_of_each_dice_number_is_present()
    {
        Assert.AreEqual(new Dictionary<int, int>()
            {
                { 1, 0 }, { 2, 5 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }
            }, 
            YatzyScorer.DiceFrequencies(2,2,2,2,2));        
        
        Assert.AreEqual(new Dictionary<int, int>()
            {
                { 1, 1 }, { 2, 1 }, { 3, 1 }, { 4, 1 }, { 5, 1 }, { 6, 0 }
            }, 
            YatzyScorer.DiceFrequencies(1,2,3,4,5));
        
    }
    
    [Test]
    public void Ones_sums_all_ones()
    {
        Assert.AreEqual(2, YatzyScorer.Ones(1,2,4,1,6));
        Assert.AreEqual(0, YatzyScorer.Ones(5,5,5,5,5));
    }
}