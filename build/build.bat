@echo off
echo Applying paths..
call paths.bat

cd ..
rem echo Building project
rem %MDROOT%\bin\mdtool -v build "--configuration:Release|x86"

echo Copying EXE from Release to build directory..
copy screenjournal\bin\Release\screenjournal.exe build

cd build

echo Generating WIX Object..
candle installer.wxs

echo Generating MSI file..
light installer.wixobj

del screenjournal.exe
del installer.wixobj
del installer.wixpdb

copy installer.msi screenjournal-installer.msi

del installer.msi

echo All done.

pause > nul