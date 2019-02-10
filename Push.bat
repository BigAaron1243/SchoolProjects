@echo off
dir /b
echo .....
echo What file(s) would you like to push?
set /p files=
echo Write a push message
set /p message=
echo Pushing %files%, are you sure (y/n)
set /p yn=
if %yn% == y goto y
if %yn% == Y goto y
if %yn% == n exit
if %yn% == N exit
exit
:y
git add %files%
git commit -m "%message%"
git push origin master
timeout 5 >NUL