using Xunit;

namespace Yatzy_Prompts;

public class YatzyScorerTest
{
    [Fact]
    public void Chance_scores_sum_of_all_dice()
    {
        Assert.Equal(16, YatzyScorer.Chance(3, 3, 4, 5, 1));
    }
    
    [Fact]
    public void Yatzy_scores_50_when_all_dice_the_same()
    {
        Assert.Equal(0, YatzyScorer.Yatzy(1,2,4,5,6));
        Assert.Equal(50, YatzyScorer.Yatzy(5,5,5,5,5));
    }

    [Fact]
    public void DiceFrequencies_stores_how_many_of_each_dice_number_is_present()
    {
        Assert.Equal(new Dictionary<int, int>()
            {
                { 1, 0 }, { 2, 5 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }
            }, 
            YatzyScorer.DiceFrequencies(2,2,2,2,2));        
        
        Assert.Equal(new Dictionary<int, int>()
            {
                { 1, 1 }, { 2, 1 }, { 3, 1 }, { 4, 1 }, { 5, 1 }, { 6, 0 }
            }, 
            YatzyScorer.DiceFrequencies(1,2,3,4,5));
        
    }
    
    [Fact]
    public void Ones_sums_all_ones()
    {
        Assert.Equal(2, YatzyScorer.Ones(1,2,4,1,6));
        Assert.Equal(0, YatzyScorer.Ones(5,5,5,5,5));
    }
}