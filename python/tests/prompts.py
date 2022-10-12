# this test case should go in a file called test_yatzy.py
def test_chance_sums_all_dice():
    assert chance([1, 2, 4, 5, 6]) == 18


# this production code should go in a file called yatzy.py
def chance(dice):
    return sum(dice)


# this test case should go in a file called test_yatzy.py
def test_yatzy_scores_50_when_all_dice_the_same():
    assert yatzy([1, 2, 4, 5, 6]) == 0
    assert yatzy([5, 5, 5, 5, 5]) == 50


# this production code should go in a file called yatzy.py
def yatzy(dice):
    distinct = set(dice)
    return 50 if len(distinct) == 1 else 0


# this test case should go in a file called test_yatzy.py
def test_dice_frequency():
    assert dice_frequency(3, [1, 2, 3, 3, 5]) == 2


# this production code should go in a file called yatzy.py
def dice_frequency(number, dice):
    return len([d for d in dice if d == number])


# this test case should go in a file called test_yatzy.py
def test_all_dice_frequencies():
    assert all_dice_frequencies([1, 2, 3, 3, 5]) == \
           {1: 1, 2: 1, 3: 2, 4: 0, 5: 1, 6: 0}


# this production code should go in a file called yatzy.py
def all_dice_frequencies(dice):
    return {n: dice_frequency(n, dice)
            for n in (1, 2, 3, 4, 5, 6)}
