package codingdojo;

import org.junit.jupiter.api.Test;

import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class Prompt2 {
    @Test
    void yatzy_scores_when_all_dice_the_same() {
        assertEquals(0, Yatzi.yatzy(1,2,4,5,6));
        assertEquals(50, Yatzi.yatzy(5,5,5,5,5));
    }

    static class Yatzi {

        public static int yatzy(int... dice) {
            return Arrays.stream(dice).distinct().count() == 1 ? 50 : 0;
        }
    }

}
