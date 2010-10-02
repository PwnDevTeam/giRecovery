
: By:        Fallensn0w
: Usage:  Clean up before pushing to gitHub.

cd ..

set AppName=giRecovery
set PATHZ=%CD%\bin

: del %PATHZ%\%AppName%.exe
del %PATHZ%\%AppName%.bat

del %PATHZ%\%AppName%.pdb
del %PATHZ%\%AppName%.xml
del %PATHZ%\%AppName%.bat

del %PATHZ%\%AppName%.vshost.exe
del %PATHZ%\%AppName%.vshost.exe.manifest


del %PATHZ%\%AppName%\bin\Debug\%AppName%.exe
del %PATHZ%\%AppName%\bin\Debug\%AppName%.pdb
del %PATHZ%\%AppName%\bin\Debug\%AppName%.xml


del %PATHZ%\%AppName%\obj\Release\%AppName%.exe
del %PATHZ%\%AppName%\obj\Release\%AppName%.pdb
del %PATHZ%\%AppName%\obj\Release\%AppName%.xml


del %PATHZ%\%AppName%\obj\Debug\%AppName%.exe
del %PATHZ%\%AppName%\obj\Debug\%AppName%.pdb
del %PATHZ%\%AppName%\obj\Debug\%AppName%.xml

del /Q %PATHZ%BUILD\*.*
rmdir BUILD