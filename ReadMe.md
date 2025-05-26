**GitHub User Search – ASP.NET MVC (.NET Framework)**

This is a simple ASP.NET MVC 5 application built on the .NET Framework 4.7.2. It allows users to enter a GitHub username, retrieves the user's profile information and their top 5 repositories (by stargazer count).



**How to Set Up and Run the Application**


Step-by-Step Setup

1. The Repository can be found at

https://github.com/masmith1889/github-user-search-mvc.git


2. Open GitHubSearchTest.sln.

3. Restore NuGet Packages if required - Visual Studio should automatically restore any packages on first build.

4. Build the Solution

5. Set the Correct Start Page - Right-click the GitHubSearchTest project → Properties

Go to the Web tab
Under Start Action, choose:
Specific Page: Home/Index

6. Run the Application


**Use the App**

You’ll see a simple form with a text box to enter a GitHub username

1. Enter a valid GitHub username (e.g. robconery)

2. Click Search

The results page will show profile details and top repositories


**Running Unit Tests**

1. Open Test Explorer in Visual Studio
Test → Test Explorer

2. Build the solution

3. Click Run All

Tests Included:
Valid username returns user data and repos

Invalid username returns null

User with no repositories handled

All tests use live GitHub API calls (no mocking).

Example User (for Testing)
The application and test project use this public GitHub account by default:

Username: masmith1889

Initially, the test user (masmith1889) had no repositories to demonstrate “empty repo” handling. After project submission, this repo will appear in the results.




