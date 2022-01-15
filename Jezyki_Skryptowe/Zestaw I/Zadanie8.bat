@echo off
echo 1. Uruchom
echo 2. Backup
echo 3. Informacje
echo 4. Koniec

set /p o="Wybierz opcje: "

if %o% equ 1 (
    start Imie.bat
)
if %o% equ 2 (
    xcopy .\ .\Kopia /i
)
if %o% equ 3 (
    echo Autor: Mateusz Sikora
)
if %o% equ 4 (
    exit
)
@echo on