@echo off
IF (%2)==(Release) GOTO RELEASE
:DEBUG
echo DEBUG mode
GOTO END
:RELEASE
cd /D %1
echo Release mode, updating assembly info
SubWCRev.exe .. ".\Properties\AssemblyInfo.template.cs" ".\Properties\AssemblyInfo.cs" -f
:END