package codingdojo;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class YatzyTest {
    @Test
    void chance_sums_all_dice() {
        assertEquals(18, Yatzy.chance(1,2,4,5,6));
    }

    @Test
    void yatzy_scores_50_when_all_dice_the_same() {
        assertEquals(0, Yatzy.yatzy(1,2,4,5,6));
        assertEquals(50, Yatzy.yatzy(5,5,5,5,5));
    }
}
