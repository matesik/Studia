@echo off
echo Pliki starsze niz 30 dni >> rozwiazanieZad10.txt

Forfiles /D -30 /M * /C "cmd /c echo @file, rozmiar(@fsize kb) utworzony(@fdate, @ftime)" >> rozwiazanieZad10.txt

@echo on 