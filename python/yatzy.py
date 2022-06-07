def chance(dice):
    return sum(dice)


def yatzy(dice):
    distinct = set(dice)
    return 50 if len(distinct) == 1 else 0
