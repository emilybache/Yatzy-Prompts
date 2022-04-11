package codingdojo;

import java.util.Arrays;

public class Yatzy {

    public static int chance(int... dice) {
        return Arrays.stream(dice).sum();
    }

    public static int yatzy(int... dice) {
        return Arrays.stream(dice).distinct().count() == 1 ? 50 : 0;
    }
}