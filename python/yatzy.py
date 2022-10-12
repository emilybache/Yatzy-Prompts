def chance(dice):
    return sum(dice)


def yatzy(dice):
    distinct = set(dice)
    return 50 if len(distinct) == 1 else 0


def dice_frequency(number, dice):
    return len([d for d in dice if d == number])


def all_dice_frequencies(dice):
    return {n: dice_frequency(n, dice)
            for n in (1, 2, 3, 4, 5, 6)}
