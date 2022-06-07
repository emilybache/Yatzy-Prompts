# this test case should go in a file called test_yatzy.py
def test_yatzy_scores_50_when_all_dice_the_same():
    assert 0 == yatzy([1, 2, 4, 5, 6])
    assert 50 == yatzy([5, 5, 5, 5, 5])


# this production code should go in a file called yatzy.py
def yatzy(dice):
    distinct = set(dice)
    return 50 if len(distinct) == 1 else 0
