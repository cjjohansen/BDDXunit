
cd ..\xBehave.Tests\
dotnet xunit -framework netcoreapp2.0 -fxversion 2.0.6 -xml "..\xunit-results-xbehave.xml"
cd ..\tools

msxsl.exe ..\xunit-results-xbehave.xml "generate-gherkin.xsl" -o ..\shifts.feature
