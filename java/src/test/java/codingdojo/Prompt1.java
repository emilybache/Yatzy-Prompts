package codingdojo;

import org.junit.jupiter.api.Test;

import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.assertEquals;

// no need to create this prompt class in your solution, just the test case and corresponding production code
public class Prompt1 {

    // this test case should go in a class called YatziTest under src/test/java
    @Test
    void chance_sums_all_dice() {
        assertEquals(18, Yatzi.chance(1,2,4,5,6));
    }

    // this should be a top-level class under src/main/java
    static class Yatzi {
        public static int chance(int... dice) {
            return Arrays.stream(dice).sum();
        }
    }

}