from yatzy import chance, yatzy, dice_frequency, all_dice_frequencies


def test_chance_sums_all_dice():
    assert chance([1, 2, 4, 5, 6]) == 18


def test_yatzy_scores_50_when_all_dice_the_same():
    assert yatzy([1, 2, 4, 5, 6]) == 0
    assert yatzy([5, 5, 5, 5, 5]) == 50


def test_dice_frequency():
    assert dice_frequency(3, [1, 2, 3, 3, 5]) == 2


def test_all_dice_frequencies():
    assert all_dice_frequencies([1, 2, 3, 3, 5]) == \
           {1: 1, 2: 1, 3: 2, 4: 0, 5: 1, 6: 0}