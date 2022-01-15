@echo off
setlocal enabledelayedexpansion
set I=0
set /p line="Wpisz tekst: "

:LOOP
    call set tmpa=%%line:~%num%,1%%%
    set /a num+=1
    if not "%tmpa%" equ "" (
    set rline=%tmpa%%rline%
    goto LOOP
)
echo %rline% >> odwrocony.txt

@echo on