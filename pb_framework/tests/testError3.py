import pytest
 
class TestErrors3:
 
    def test_TS_016(self):
        # TC_016: Calculate length of object
        value = None
        len(value)   # Runtime Error
 
    def test_TS_017(self)
        # TC_017: Validate sum of values
        x = 5
        y = 5
        assert x + y == 10   # Syntax Error
 
    def test_TS_018(self):
        # TC_018: Verify output value
        result = 50
        assert result == 100   # Logical Error
