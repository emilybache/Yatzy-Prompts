using Xunit;

namespace Yatzy_Prompts;

// no need to create this prompt class in your solution
public class Prompt1
{
    // this test case should go in a class called YatzyScorerTest
    [Fact]
    public void Chance_scores_sum_of_all_dice()
    {
        Assert.Equal(16, YatzyScorer.Chance(3, 3, 4, 5, 1));
    }
    
}