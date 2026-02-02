# jonash-minimal-ASP.NET-Core-Rest-example

## Run / build with Visual Studio
* Clone project with Visual Studio (if necessary download / add  "ASP.NET and web development"-extension)
* Try to execute ./Program.cs . If error message like "...'project.assets.json' not found. Run a NuGet package restore to generate this file...":
E.g. see https://stackoverflow.com/questions/48440223/assets-file-project-assets-json-not-found-run-a-nuget-package-restore)
=> Then do cmd "dotnet restore" in project directory)
* If application is started successfully, kestrel server will per default run at port 5000
* Open URL http://localhost:5000/myurl
* After successful build, executable .exe is e.g. in ./jonash-minimal-ASP.NET-Core-Rest-example/obj/Release/net8.0/jonash-minimal-ASP.NET-Core-Rest-example.exe

## Run / build with Visual Studio Code
* Clone project with git bash into folder and open this directory with Visual Studio Code
* Execute ./Program.cs and if necessary, install local test cert
* (If necessary run "dotnet restore" in project directory)
* If application is started successfully, kestrel server will per default run at port 5001
* Open URL https://localhost:5001/myurl
* After successful build, executable .exe is e.g. in ./jonash-minimal-ASP.NET-Core-Rest-example/bin/Debug/net8.0/jonash-minimal-ASP.NET-Core-Rest-example.exe
