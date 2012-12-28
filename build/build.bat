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
candle -ext WiXNetFxExtension installer.wxs

echo Generating MSI file..
light -ext WixUIExtension -ext WiXNetFxExtension installer.wixobj

del screenjournal.exe
del installer.wixobj
del installer.wixpdb

copy installer.msi screenjournal-installer.msi

del installer.msi

echo.
echo All done.

pause > nul