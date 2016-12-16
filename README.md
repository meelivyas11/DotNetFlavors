# What is it?
This repository consist of following sample projects:
- `EntityFramework_ClassLibrary` project is used to save and Get data from database using Entity Framework.
- `MVC-App` web application is a simple MVC application which saves and person data.
- `MVVC-App` is a simple MVVC application.
- `WebAPI-App` application contains code to build a simple Web API to add/see books and `WebAPI-App-Client` contains the "*.json" file which can be uploaded in Postman to call that WebAPIs.
- `Jquery_Ajax` contains code to show an alert on click of a button using Jquery. It also contains code to make a AJAX call to get information on click of the button.

<b> Detailed steps to create these projects from scratch can be found from [here] (https://meelivyas.blogspot.com/2016/06/c-net-leaning.html) </b>

# How to Set up?
## Software Requirements 
 - Git Bash: <https://git-scm.com/>
 - Visual Studio
 - SQL Server Management Studio
 - Postman (Only for WebAPI-App project)

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
 - Get EntityFramework_ClassLibrary project working.
 - Update *Data Source* value of the connectionString present in `Web.config` file of `MVC-App` project inline to the values in 'App.config' of EntityFramework_ClassLibrary project.
```xml
<connectionStrings>
	<add name="PersonContext"  providerName="System.Data.SqlClient" connectionString="Data Source=.\sqlexpress; Initial Catalog=PersonDB; Integrated Security=True; MultipleActiveResultSets=True"/>
</connectionStrings>
```
 - Set `MVC-App` as Startup Project
 - Clean, build and run the application
 
### MVVC Application
 - Get EntityFramework_ClassLibrary project working.
 - Update *Data Source* value of the connectionString present in `Web.config` file of `MVVC-App` project inline to the values in 'App.config' of EntityFramework_ClassLibrary project.
```xml
<connectionStrings>
	<add name="PersonContext"  providerName="System.Data.SqlClient" connectionString="Data Source=.\sqlexpress; Initial Catalog=PersonDB; Integrated Security=True; MultipleActiveResultSets=True"/>
</connectionStrings>
```
 - Set `MVVC-App` as Startup Project
 - Clean, build and run the application

### Web API and its Client
 - Set `WebAPI-App` as Startup Project
 - Clean, build and run the application
 
### Jquery and AJAX
 - Set `Jquery_Ajax` as Startup Project
 - Clean, build and run the application

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
 - <http://localhost:53240/WebAPIAppClient/AddBook?title=bT1&author=BA1> and <http://localhost:53240/WebAPIAppClient/SeeAllBooks> calls Post/Get Web API through a client code.
 - Import the Postman collection present in `WebAPI-App-Client` folder of the repository to see the results. [Here] (https://meelivyas.blogspot.com/p/download-and-install-postman-httpswww.html) are the steps to upload and test Web APIs

## Jquery and AJAX
 - Open <http://localhost:49553/User/UserDetails> in your browser
 - Enter any User id (e.g. 102) and hit `Show Alert` to see JQuery code working and hit `Call Ajax` button to see AJAX code working 