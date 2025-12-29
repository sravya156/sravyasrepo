from pages.base_page import BasePage

class LoginPage(BasePage):

    USERNAME_FIELD = "username_input"
    PASSWORD_FIELD = "password_input"
    LOGIN_BUTTON = "//login"

    def enter_username(self):
        #  Logical bug: no argument passed
        self.type_text(self.USERNAME_FIELD)

    def enter_password(self, password):
        #  Locator strategy missing
        self.type_text(self.PASSWORD_FIELD, password)

    def click_login(self):
        #  XPath is invalid
        self.click(self.LOGIN_BUTTON)
