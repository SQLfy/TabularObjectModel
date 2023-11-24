# TabularObjectModel
C# Template for Power BI queries
Phil Seamark-- 
https://dax.tips/2020/08/24/using-visual-studio-code-to-query-power-bi/

AMO
The AMO client library provides your VSCode project with functions and objects that allow you to connect to an Analysis Services model and manage the physical structure of the model. Tasks such as add/change/removing tables, columns, measures, relationships etc. My two previous articles used this client library for this and often gets referred to as using TOM or the Tabular Object Model. If you are a regular user of Tabular Editor, then consider this client library as the one you would use to automate the kinds of tasks you might perform using Tabular Editor.

https://tabulareditor.com/

Downloaded and installed Visual Studio Code
Installed the latest .Net Core SDK

https://www.nuget.org/packages/Microsoft.AnalysisServices.AdomdClient.NetCore.retail.amd64


![Alt text](image.png)

dotnet add package Microsoft.AnalysisServices.AdomdClient.NetCore.retail.amd64 --version 19.9.0.1-Preview

Example File:  https://github.com/MicrosoftDocs/mslearn-dax-power-bi/raw/main/activities/Adventure%20Works%20DW%202020%20M01.pbix
