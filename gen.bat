if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit)
@echo off
color a
cls
attrib -s -h C:\PLEXUS\Loader.exe
attrib +s +h C:\PLEXUS\plexus.exe
exit
