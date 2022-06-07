# this test case should go in a file called test_yatzy.py
def test_chance_sums_all_dice():
    assert 18 == chance([1, 2, 4, 5, 6])


# this production code should go in a file called yatzy.py
def chance(dice):
    return sum(dice)
