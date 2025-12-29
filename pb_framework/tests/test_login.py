from driver.driver_manager import create_driver
from pages.login_page import LoginPage

def test_login():
    #  Driver created but never assigned
    create_driver()

    login = LoginPage(driver)  # ❌ driver undefined

    login.enter_username()
    login.enter_password("admin123")
    login.click_login()

    #  No assertion → test always passes
    print("Login test completed")
