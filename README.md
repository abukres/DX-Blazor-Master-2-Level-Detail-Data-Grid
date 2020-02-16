# DXDataGridDemo
A demo for the DevExpress server side Blazor side data grid

* [Live Demo](http://siteauditor.net/dxdatagriddemo/MasterDetail). (ctrl-shift to sort by multiple columns)

* This is a self contained demo (No database setup. SQLite is being used) and it's ready to run except for getting DevExpress' Blazor package. To get it, open an account at DevExpress and go to [nuget.devexpress.com](https://nuget.devexpress.com), log in as a registered DevExpress customer and click **Obtain Feed URL**. Add the feed URL as a nuget source in Visual Studio, under Tools -> Options -> Nuget Package Manager -> Packages Sources and make sure the checkbox is checked. 

Get the nuget command to run from [this link](https://nuget.devexpress.com/packages?q=blazor). Click on the link. Currently the install command is 'Install-Package DevExpress.Blazor -Version 19.1.7'. The version number changes as new versions come out. Copy the command and run it in the Package Manager Console. This installs a trial version of DevExpress' Blazor component. 

