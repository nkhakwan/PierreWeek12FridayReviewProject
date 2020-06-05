# _Pierre Sweet Shop_

#### _Epicodus Week12 Friday Review Project_

#### By _**Khan Sahab**_

## Description

_A website that allows visitors to see all the treats that are available in a sweet shop and they can see the flavors each sweet is available. However only the logged in users can add, update, delete both Treats and flavors. It has the ability to register and log in users _

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the commands dotnet restore, dotnet build, and dotnet run.
5. CREATE DATABASE `nauman_khakwani`
6. Run "dotnet ef migrations add <yourtag>
7. Run "dotnet ef database update"
Or Please see the detailed tables dump at the end of this README file for all the tables and database.

# Database is named Sweet as first_last of names were already occupied in workbench and i didn't feel like deleting it.

8. I am not incuding appsettings.json in git ignore. You should be able to see it.



## Known Bugs
 
None. Both Basic and additional requirements of Delete and Edit have been fulfilled.
 
## Support and contact details

_Have a bug or an issue with this application? Email post_khan@yahoo.com_

## Technologies Used

* C#
* .NET Core
* ASP.NET Core MVC
* MSBuild
* Razor
* Git and GitHub
* mysql database
* Entity

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User can add clients by clicking add new clients** | User Input:"add client” | Output: " Name of the client displayed with his/her stylists and with stylists skills" |
| **User can view a particular client** | User Input:”click on a particular client” | Output: "Name of that client is displayed. For now no other property like addresses etc were added" |
| **User can add stylists by clicking add new stylists** | User Input:"add a new stylist” | Output: " Name of the Stylist with skill included in the displayed list" |


### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Khan Sahab_**