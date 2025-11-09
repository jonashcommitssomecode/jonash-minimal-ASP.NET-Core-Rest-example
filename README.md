# jonash-minimal-ASP.NET-Core-Rest-example

* 1. Download Visual Studio (e.g. VS 2022), incl. "ASP.NET and web development"-extensions
* 2. Clone this project into VS
* 3. Try to execute ./Program.cs
     If error message like "...'project.assets.json' not found. Run a NuGet package restore to generate this file...":
     E.g. see https://stackoverflow.com/questions/48440223/assets-file-project-assets-json-not-found-run-a-nuget-package-restore
     => Then do cmd "dotnet restore" in project folder
* 4. If application is started successfully, kestrel server will per default run at port 5000
     => And then try http://localhost:5000/myurl
