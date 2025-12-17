# from pages.home_page import HomePage
# from pages.performance_page import PerformancePage
# from pages.lighting_page import LightingPage
# import time
#
# def test_navigation(app):
#     application, window = app
#
#     home = HomePage(application, window)
#
#     # Navigate to Performance page
#     home.go_to_performance()
#     time.sleep(3)  # wait for page to load
#
#     perf_window = application.window(title_re=".*Performance.*")
#     perf_window.wait("visible", timeout=10)
#     performance = PerformancePage(application, perf_window)
#
#     assert performance.exists(performance.BOOST_TOGGLE)
#
#     # Navigate to Lighting page
#     home.go_to_lighting()
#     time.sleep(3)  # wait for page to load
#
#     lighting_window = application.window(title_re=".*Lighting.*")
#     lighting_window.wait("visible", timeout=10)
#     lighting = LightingPage(application, lighting_window)
#
#     assert lighting.exists(lighting.SOME_LIGHTING_CONTROL)
"""
REFERENCE TEST FILE – DO NOT EXPAND MANUALLY

Used by AI agent to understand:
- Navigation flow
- Page Object usage
- Assertion style
"""

from pages.home_page import HomePage
from pages.performance_page import PerformancePage
from pages.lighting_page import LightingPage


def test_navigation_reference(app):
    application, window = app

    home = HomePage(application, window)
    assert home.is_loaded(), "Home page not loaded"

    home.go_to_performance()
    performance = PerformancePage.from_application(application)
    assert performance.is_loaded(), "Performance page not loaded"

    home.go_to_lighting()
    lighting = LightingPage.from_application(application)
    assert lighting.is_loaded(), "Lighting page not loaded"

