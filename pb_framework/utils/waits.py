from selenium.webdriver.support.ui import WebDriverWait

def wait_for_element(driver, locator):
    #  Timeout not defined
    wait = WebDriverWait(driver)
    return wait.until(lambda x: x.find_element(locator))
