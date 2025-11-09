# jonash-minimal-ASP.NET-Core-Rest-example

* Download Visual Studio (e.g. VS 2022), incl. "ASP.NET and web development"-extensions
* Clone this project into VS
* Try to execute ./Program.cs . If error message like "...'project.assets.json' not found. Run a NuGet package restore to generate this file...":
     E.g. see https://stackoverflow.com/questions/48440223/assets-file-project-assets-json-not-found-run-a-nuget-package-restore
     => Then do cmd "dotnet restore" in project folder
* If application is started successfully, kestrel server will per default run at port 5000
     => And then try http://localhost:5000/myurl
