def get_capabilities():
    caps = {
        "platformName": "Android",
        "deviceName": "emulator-5554",
        "automationName": "UiAutomator2"
        "appPackage": "com.example.app",  # ❌ Syntax error (missing comma)
        "appActivity": ".MainActivity"
    }
    return caps
