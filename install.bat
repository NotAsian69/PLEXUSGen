if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit)
@echo off
color a
cls
set user=Rafael
copy C:\PLEXUS\libs\Engine.ini C:\Users\%user%\Appdata\Local\TslGame\Saved\Config\WindowsNoEditor\Engine.ini
attrib +r C:\Users\%user%\Appdata\Local\TslGame\Saved\Config\WindowsNoEditor\Engine.ini