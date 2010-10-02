
: By:         Fallensn0w
: Purpose: Used for preparing for making a SFX Archive.

cd ..

set AppName=giRecovery
set PATHZ=%CD%\bin

copy readline5.dll %PATHZ%
copy irecovery.exe %PATHZ%
copy %AppName%.exe %PATHZ%
copy README %PATHZ%
copy TODO %PATHZ%

echo Files are ready to be archived into SFX.
echo ~ Fallensn0w