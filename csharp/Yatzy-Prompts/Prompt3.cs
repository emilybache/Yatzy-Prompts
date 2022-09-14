using NUnit.Framework;

namespace Yatzy_Prompts;

// no need to create this prompt class in your solution
public class Prompt3
{
    // this test case should be added to YatzyScorerTest
    [Test]
    public void Yatzy_scores_50_when_all_dice_the_same()
    {
        Assert.AreEqual(0, YatzyScorer.Yatzy(1,2,4,5,6));
        Assert.AreEqual(50, YatzyScorer.Yatzy(5,5,5,5,5));
    }
}