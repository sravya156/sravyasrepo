import subprocess
import time
import json
import os
import pytest
from pywinauto import Desktop
from pywinauto.timings import TimeoutError as PywinautoTimeoutError


def detect_omen_aumid():
    """
    Auto-detect the correct AUMID from Windows using PowerShell.
    Supports all OMEN Command Center / OMEN Gaming Hub versions.
    """

    ps_script = r"""
        Get-StartApps |
        Where-Object {
            $_.AppID -like "*AD2F1837*" -or
            $_.Name  -like "*OMEN*"     -or
            $_.Name  -like "*Gaming*"
        } | 
        Select-Object Name, AppID |
        ConvertTo-Json
    """

    command = ["powershell", "-NoProfile", "-Command", ps_script]
    result = subprocess.check_output(command, universal_newlines=True)

    if not result.strip():
        return None

    try:
        apps = json.loads(result)
        if isinstance(apps, dict):
            apps = [apps]

        for app in apps:
            appid = app.get("AppID", "")
            if "AD2F1837" in appid:
                return appid

    except json.JSONDecodeError:
        return None

    return None


@pytest.fixture(scope="session")
def app():
    """
    Launch OMEN Gaming Hub / OMEN Command Center and return the UIA window.
    """

    # 1) Auto-detect correct AUMID
    aumid = detect_omen_aumid()

    if not aumid:
        raise RuntimeError(
            "Could not detect OMEN Gaming Hub AUMID. "
            "Run PowerShell: Get-StartApps | Where-Object { $_.Name -like '*OMEN*' }"
        )

    print(f"[INFO] Detected OMEN AUMID: {aumid}")

    # 2) Launch the UWP app
    launch_cmd = f'cmd.exe /c start "" shell:AppsFolder\\{aumid}'
    subprocess.Popen(launch_cmd, shell=True)

    # Allow ApplicationFrameHost to initialize
    time.sleep(3)

    omen_window = None
    deadline = time.time() + 60
    last_error = None

    # 3) Find OMEN window
    while time.time() < deadline and omen_window is None:
        try:
            windows = Desktop(backend="uia").windows()

            uwp_frames = [
                w for w in windows
                if w.element_info.class_name == "ApplicationFrameWindow"
            ]

            for frame in uwp_frames:
                title = frame.window_text() or ""

                if any(k in title for k in ["OMEN", "Omen", "Gaming", "Hub"]):

                    # Try CoreWindow first
                    try:
                        core = frame.child_window(
                            class_name="Windows.UI.Core.CoreWindow",
                            control_type="Window"
                        ).wait("exists enabled ready", timeout=10)

                        omen_window = core
                        break

                    except PywinautoTimeoutError:
                        omen_window = frame.wait("exists enabled ready", timeout=10)
                        break

            if omen_window:
                print("[INFO] OMEN Hub Window Found.")
                break

            time.sleep(1)

        except Exception as e:
            last_error = e
            time.sleep(1)

    if omen_window is None:
        raise RuntimeError(
            f"OMEN Gaming Hub window not found within timeout. Last error: {last_error}"
        )

    return omen_window
