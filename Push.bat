@echo off
dir /b
echo .....
echo What file(s) would you like to push?
set /p files=
echo Pushing %files%, are you sure (y/n)
set /p yn=
if %yn% == y goto y
if %yn% == Y goto y
if %yn% == n exit
if %yn% == N exit
:y
git add %files%
git commit -m "Push via app"
git push origin master
timeout 3 >NUL