![cf](http://i.imgur.com/7v5ASc8.png) Lab 14 : Deployment
=====================================

## To Submit this Assignment
- fork this repository
- write all of your code in a branch named `lab-#`; + `<your name>` **e.g.** `lab12-amanda`
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas

## Directions
Continuing Building out your Student Enrollment Site with the following additions:
1. In the "View All Students" page, each student links to their own details page
	- The details page shows all the information related to that student **with the ability to edit the information**. 
	- The user should be able to save the changes once completed, and be redirected back to the "View All students" results.
2. In the "View All Students" page, there should be a "delete" option to remove that student from the database

3. Deploy both your database and website to Azure. 

## Stretch (up to 5pts)
If You didn't do so in Lab 13, include the following:
1. Include functionality on the "View All Students" page to search for specific students by Name, or class choice.
2. Include functionality on the "View All Students" page to sort students by ASC or DESC order or First Name or Last Name. 

**If you already implemented the above...
1. Add an additional Database table for the Classes. Allow the option to edit the details of what each class consists of
	- Class Name (this should match what the studetns are signing up for. You can make this field non-editable if you wish)
	- Maximun number of students
	- Class times
	- etc....
2. Include a page to view and edit the class details as well
3. Can you show all the students that are in that class on the Class details page?

## Requirements
Your MVC website should contain the following at minimum once completed:
1. Proper Documentation (Comments, Readme etc...)
2. *Two* Controllers (Home, and Enrollment) (Dont forget to use Dependency Injection on these Controllers)
3. *One* Model for `Student.cs`
4. View pages for each of the Controller Actions
5. Data Folder with *One* DbContext file
6. style.css file located in the `wwwroot` folder
7. _ViewImports file to enable TagHelpers 
8. `Startup.cs` should allow the following:
	1. Routing Template 
	2. Static Files, and MVC Middleware
	3. Configured to use the DBContext service
	4. Setup for Dependency Injection
9. appsettings.json file for Database Connection string
10. A Database.
11. Tests. Research. Start Here: [Testing a Controller](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing). 


## ReadMe
A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context)
2. show them what it looks like in action
3. show them how they use it
4. tell them any other relevant details
5 **Include the link to your deployed application on Azure**
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> <br /> Refer to the sample-README in the class repo for an example. 
- [Reference](https://github.com/noffle/art-of-readme)

## Rubric
- 7pts: Program meets all requirements described in Lab directions
- 3pts: Code meets industry standards

- **Readme.md required for submission. Missing readme document and tests will result in a best score of 2/10**