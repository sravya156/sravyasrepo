
from pages.base_page import BasePage


class HomePage(BasePage):
    """Represents OMEN Home Page"""

    def go_to_performance(self):
        self.window.child_window(title_re=".*Performance.*").click_input()

    def go_to_lighting(self):
        self.window.child_window(title_re=".*Lighting.*").click_input()
