# class BasePage:
#     def __init__(self, app, window):
#         self.app = app
#         self.window = window
#
#     def click(self, locator):
#         """
#         locator: dict with 'auto_id' or 'title' and 'control_type'
#         """
#         ctrl = self.window.child_window(**locator)
#         ctrl.wait("enabled", timeout=10)
#         ctrl.click_input()
#
#     def exists(self, locator):
#         try:
#             ctrl = self.window.child_window(**locator)
#             ctrl.wait("exists visible", timeout=5)
#             return True
#         except:
#             return False
class BasePage:
    """
    Base class for all OMEN pages
    """

    def __init__(self, application, window):
        self.app = application
        self.window = window

    def exists(self, locator):
        try:
            return locator.exists()
        except Exception:
            return False

    def is_loaded(self):
        return self.window.exists()
