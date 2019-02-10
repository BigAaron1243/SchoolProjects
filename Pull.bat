@echo off
echo Pulling, are you sure (y/n)
set /p yn=
if %yn% == y goto y
if %yn% == Y goto y
if %yn% == n exit
if %yn% == N exit
:y
git pull origin master
