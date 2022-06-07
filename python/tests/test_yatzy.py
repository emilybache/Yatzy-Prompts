from yatzy import chance, yatzy


def test_chance_sums_all_dice():
    assert 18 == chance([1, 2, 4, 5, 6])


def test_yatzy_scores_50_when_all_dice_the_same():
    assert 0 == yatzy([1, 2, 4, 5, 6])
    assert 50 == yatzy([5, 5, 5, 5, 5])
