from appium import webdriver
from config.capabilities import get_capabilities

def create_driver():
    caps = get_capabilities()

    #Runtime error: missing Appium server URL
    driver = webdriver.Remote(caps)

    driver.implicitly_wait(2)
    return driver
