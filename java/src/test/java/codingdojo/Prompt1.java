package codingdojo;

import org.junit.jupiter.api.Test;

import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class Prompt1 {

    @Test
    void chance_sums_all_dice() {
        assertEquals(18, Yatzi.chance(1,2,4,5,6));
    }

    static class Yatzi {
        public static int chance(int... dice) {
            return Arrays.stream(dice).sum();
        }
    }

}