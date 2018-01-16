# Footies ASP.NET Core Application
**Author**: Luay Younus

## Overview
Web app that allows Football/Soccer lovers to Create teams, Add players and join existing teams.
[Click to Open Web App Deployed on Azure](http://footies.azurewebsites.net)

## Architecture
 - C# ASP.NET Core application.
 - MVC architectural design pattern.
 - Entity Framework (Object-Relational Mapper)
 - Azure (Deployment Service)

## Requirements to run the Application
- [Visual Studio 2017 Community with .NET Core 2.0 SDK](https://www.microsoft.com/net/core#windowscmd)
- [GitBash / Terminal](https://git-scm.com/downloads) or [GitHub Extension for Visual Studio](https://visualstudio.github.com)

## To open the project on local machine
1. Clone the repository to your local machine.
2. Cd into the application directory where the `AppName.sln` exist.
3. Open the application using `Open/Start AppName.sln`.
4. Change the database `constring` inside the `appsettings.json` file to:-
```C#
"DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=Football;Trusted_Connection=True;MultipleActiveResultSets=true"
```
5. Save the file then Run the application by clicking on the Play button <img src="https://github.com/luayyounus/Lab02-Unit-Testing/blob/Lab02-Luay/WarCardGame/play-button.jpg" width="16">.
6. The website will run on your default web browser routing to the main home page.

# What to expect the first you run the app?
- Navigation bar with Home Page to Create a Team and View All teams available.
- When Team is created or picked, New player can be ADDED, UPDATED, DELETED.

# Main components of the Application
 - DbContext for dependency injection used in controllers
 - Two Main controllers
 - Two models for Teams and Players
 - ASP Tag Helpers are used for view routing
 - Test Project with InMemoryDb context to test controllers.

# Dependencies and Packages
- AspNetCore.All
- EntityFrameworkCore.InMemory
- EntityFrameworkCore.Tools
- Xunit
- Xunit.Runner
