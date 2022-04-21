package codingdojo;

import org.junit.jupiter.api.Test;

import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.assertEquals;

// no need to create this prompt class in your solution, just the test case and corresponding production code
public class Prompt2 {
    // this test case should be added to YatziTest
    @Test
    void yatzy_scores_when_all_dice_the_same() {
        assertEquals(0, Yatzi.yatzy(1,2,4,5,6));
        assertEquals(50, Yatzi.yatzy(5,5,5,5,5));
    }

    static class Yatzi {

        // this method should be added to the Yatzi class
        public static int yatzy(int... dice) {
            return Arrays.stream(dice).distinct().count() == 1 ? 50 : 0;
        }
    }

}
