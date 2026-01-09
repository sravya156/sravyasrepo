import pytest
 
class TestErrors5:
 
    def test_TS_011(self):
        # TC_011: Access first element in list
        data = []
        data[0]   # Runtime Error
 
    def test_TS_012(self):
        # TC_012: Compare two numbers
        a = 10
        b = 20
        assert a > b   # Logical Error
 
    def test_TS_013(self)
        # TC_013: Print welcome message
        print("Welcome")   # Syntax Error
 
    def test_TS_014(self):
        # TC_014: Calculate square root
        import math
        math.sqrt(-4)   # Runtime Error
 
    def test_TS_015(self):
        # TC_015: Verify admin access
        is_admin = True
        assert is_admin is False   # Logical Error
