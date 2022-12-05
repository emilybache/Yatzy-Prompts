using NUnit.Framework;

namespace Yatzy_Prompts;

// no need to create this prompt class in your solution
public class Prompt5
{
    // this test case should be added to YatzyScorerTest
    [Test]
    public void DiceFrequency_gives_how_many_of_a_particular_dice_number_is_present()
    {
        Assert.AreEqual(2, YatzyScorer.DiceFrequency(3, 1, 2, 3, 3, 5));
    }
}