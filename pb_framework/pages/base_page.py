class BasePage:

    def __init__(self, driver):
        self.driver = driver

    def click(self, locator):
        #  Logical issue: no wait before click
        self.driver.find_element(locator).click()

    def type_text(self, locator, text):
        #  Runtime error: wrong find_element usage
        self.driver.find_element_by_id(locator).send_keys(text)
