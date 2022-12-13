using NUnit.Framework;

namespace Yatzy_Prompts;

// no need to create this prompt class in your solution
public class Prompt7
{
    // this test case should be added to YatzyScorerTest
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
}