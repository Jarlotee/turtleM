@echo off
cls

ECHO.
ECHO Building Primary Nuget Package turtleM
ECHO =======================================

nuget pack src\turtleM\turtleM.csproj -build -Prop Configuration=Release -IncludeReferencedProjects -OutputDirectory artifacts

ECHO.
ECHO Building turtleM IoC Package for Unity 
ECHO =======================================

nuget pack src\turtleM.Unity\turtleM.Unity.csproj -build -Prop Configuration=Release -IncludeReferencedProjects -OutputDirectory artifacts

ECHO.
ECHO Building turtleM IoC Package for Ninject 
ECHO =======================================

nuget pack src\turtleM.Ninject\turtleM.Ninject.csproj -build -Prop Configuration=Release -IncludeReferencedProjects -OutputDirectory artifacts

ECHO.
ECHO All done
