echo .
set productBaseName=%~1
echo %productBaseName%

set configuration=%~2
echo %configuration%

set platform=%~3
echo %platform%

echo.
echo "Cleaning previous files and directories..."
IF EXIST "..\..\..\Bin\HelloWorld\" rmdir /S /Q ""..\..\..\Bin\HelloWorld\"

echo.
echo "Copying output files..."
xcopy "..\..\..\HelloWorld\bin\%configuration%\net48\*.*" "..\..\..\Bin\HelloWorld\" /Q /F /Y
