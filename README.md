# A Hellow World application in .NET

## Creating and running application
- `dotnet new  console --framework net7.0` *creates project template that display Hello World*
- `dotnet run` *to run*

## Publishing the application
- `dotnet publish --configuration Release` * **Debug** is the default config. **Release** has min. debug info and is optimized.
- In `bin/Release/net7.0` you'll find a publish folder after successfully running the command above.
- `cd` into `./bin/Release/net7.0/publish` then run the application by typing `./HelloWorld` into the terminal and pressing the Enter key.
