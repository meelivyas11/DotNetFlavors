# What is it?
This repository consist of following sample projects:
- `EntityFramework_ClassLibrary` project is used to save and Get data from database using Entity Framework.
- `MVC-App` web application is a simple MVC application which saves and person data.
- `MVVC-App` is a simple MVVC application.
- `WebAPI-App` application contains code to build a simple Web API and `WebAPI-App-Client` contains the "*.json" file which can be uploaded in Postman to call that WebAPIs.
- `Jquery_Ajax` contains code to show an alert on click of a button using Jquery. It also contains code to make a AJAX call to get information on click of the button.

<b> Detailed steps to create these projects from scratch can be found from [here] (https://meelivyas.blogspot.com/2016/06/c-net-leaning.html) </b>

# How to Set up?
## Software Requirements 
 - Git Bash: <https://git-scm.com/>
 - Visual Studio
 - SQL Server Management Studio

## Environment Setup
 - Clone the repository using `git clone https://github.com/meelivyas11/DotNetFlavors.git` from Git Bash
 - Open 'DotNetLearning.sln' using Visual Studio
 - Clean and build the solution to install al required Nuget packages
 
### Entity Framework
 - Update the value of "Data Source" related to the connectionString from `App.config` file present inside `EntityFramework_ClassLibrary` projects of the repository. 
```xml
<connectionStrings>
	<add name="PersonContext"  providerName="System.Data.SqlClient" connectionString="Data Source=.\sqlexpress; Initial Catalog=PersonDB; Integrated Security=True; MultipleActiveResultSets=True"/>
</connectionStrings>
```
 - Clean and build the application.
 - Migrations are already executed on this project, hence you will see `*_Initial_Load.cs` file at "\EntityFramework_ClassLibrary\Migrations" location. ([here] (https://meelivyas.blogspot.com/p/part1.html) are the steps to create migrations from scratch)
 - Run `Update-Database –Verbose` command from 'Package Manager Console' to create the database and tables.
 
### MVC Application
 - Update the value of "Data Source" related to the connectionString from `Web.config` file present inside `MVC-App` project of the repository. Make sure the connectionString present in 'App.config' of EntityFramework_ClassLibrary is same as that in 'Web.config' of `MVC-App` project.
```xml
<connectionStrings>
	<add name="PersonContext"  providerName="System.Data.SqlClient" connectionString="Data Source=.\sqlexpress; Initial Catalog=PersonDB; Integrated Security=True; MultipleActiveResultSets=True"/>
</connectionStrings>
```
 - Set `MVC-App` as Startup Project
 - Clean, build and run the application
 
### MVVC Application
 - Update the value of "Data Source" related to the connectionString from `Web.config` file present inside `MVVC-App` project of the repository. Make sure the connectionString present in 'App.config' of EntityFramework_ClassLibrary is same as that in 'Web.config' of `MVVC-App` project.
```xml
<connectionStrings>
	<add name="PersonContext"  providerName="System.Data.SqlClient" connectionString="Data Source=.\sqlexpress; Initial Catalog=PersonDB; Integrated Security=True; MultipleActiveResultSets=True"/>
</connectionStrings>
```
 - Set `MVVC-App` as Startup Project
 - Clean, build and run the application

### Web API and its Client

### Jquery and AJAX

# How Do I use it?
## Entity Framework
 - Connect with the Data Source (mentioned in connectionString) from 'SQL Server Management Studio' to see 'PersonDB' created through code first approach
 
## MVC Application
 - Open <http://localhost:49969/Person/EnterPersonDetails> in your web browser
 - Enter first name, last name, DOB  and State information and click 'Save Person Details'. This will save the person data in the database mentioned on the ConnectionString. 
 
## MVVC Application
 - Open <http://localhost:54353/Person/AddPerson> in your web browser
 - Enter first name, last name, DOB  and State information and click 'Add Person'. This will save person data and redirect to the page which shows all the person data from the database mentioned in the ConnectionString . 
 
## Web API and its Client

## Jquery and AJAX
