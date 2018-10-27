
cd ..\xBehave.Tests\
dotnet xunit -framework netcoreapp2.0 -fxversion 2.0.6 -xml "..\xunit-results-xbehave.xml"
cd ..\tools

 C:\Users\ChristianJohansen\.nuget\packages\xBehaveMarkdownReport\0.14.0\tools\xBehaveMarkdownReport.exe -i ..\xunit-results-xbehave.xml -o ..\markdown-report.md
REM msxsl.exe ..\xunit-results-xbehave.xml "generate-gherkin.xsl" -o ..\shifts.feature
