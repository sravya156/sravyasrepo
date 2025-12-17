
from pages.base_page import BasePage


class LightingPage(BasePage):
    """Represents OMEN Lighting Page"""

    SOME_LIGHTING_CONTROL = "LightingControl"  # symbolic placeholder

    @classmethod
    def from_application(cls, application):
        window = application.window(title_re=".*Lighting.*")
        window.wait("exists enabled visible ready", timeout=20)
        return cls(application, window)

    def is_loaded(self):
        return self.window.exists()