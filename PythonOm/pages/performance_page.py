
from pages.base_page import BasePage


class PerformancePage(BasePage):
    """Represents OMEN Performance Page"""

    BOOST_TOGGLE = "PerformanceToggle"  # symbolic placeholder

    @classmethod
    def from_application(cls, application):
        window = application.window(title_re=".*Performance.*")
        window.wait("exists enabled visible ready", timeout=20)
        return cls(application, window)

    def is_loaded(self):
        return self.window.exists()
