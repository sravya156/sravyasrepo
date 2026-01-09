import pytest
 
class TestErrors10:
 
    def test_TS_001(self):
        # TC_001: Launch the application
        a = 10 / 0   # Runtime Error
 
    def test_TS_002(self):
        # TC_002: Validate addition logic
        result = 2 + 2
        assert result == 5   # Logical Error
 
    def test_TS_003(self):
        # TC_003: Read data from list
        data = [1, 2, 3]
        print(data[5])   # Runtime Error
 
    def test_TS_004(self)
        # TC_004: Verify test execution
        assert True      # Syntax Error (missing colon)
 
    def test_TS_005(self):
        # TC_005: Check login status
        is_logged_in = False
        assert is_logged_in is True   # Logical Error
 
    def test_TS_006(self):
        # TC_006: Convert string to integer
        value = int("abc")   # Runtime Error
 
    def test_TS_007(self):
        # TC_007: Append item to object
        obj = None
        obj.append(1)   # Runtime Error
 
    def test_TS_008(self):
        # TC_008: Calculate final price
        total = 100
        discount = 10
        assert total - discount == 95   # Logical Error
 
    def test_TS_009(self):
        # TC_009: Open configuration file
        open("config.txt")   # Runtime Error
 
    def test_TS_010(self)
        # TC_010: Validate application close
