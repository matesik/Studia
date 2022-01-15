@echo off
SETLOCAL EnableDelayedExpansion
set x=%1
For /f "delims=" %%a In (file.txt) Do (
    set b=%%a
    echo !b:%x%=! > file.txt
)
@echo on