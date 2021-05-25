# Intro
This is Samuel Parker's submission for Vero Screening's technical test. The prototype features a .netcore 3.1 api with Entity Framework and a react front end.
If you have sql server installed and running then the database should be automatically created.
I also thought this would be a good project to get some more react practice in, i have attempted to use react "hooks" in replace of state

### Time taken - 4 1/2hrs

# Pre-reqs
1. Visual Studio 2019 with .netcore 3.1
2. SQL Server Developer Edition [https://www.microsoft.com/en-gb/sql-server/sql-server-downloads], if you have SQL Server Management Studio (SSMS) you will likely already have this
3. Yarn installed [https://yarnpkg.com/]

# Running the API
1. Open /API/API.sln in Visual Studio
2. You may need to adjust the Connection String found in /API/appsettings.json to point to your local server, it's currently pointing at the default one for sqlserver
2. Run the solution, it should open a swagger window at https://localhost:44306/swagger/index.html

# Running the React App
1. Navigate to 90s-app-fe in a terminal window
2. Run "yarn" to install packages
3. Run "yarn start" to start application

# ------Design Decisions------
## 1) DB - SQLSERVER
I used sql server as it has easy intergration into .netcore with entity framework
It can be used with SSMS to easily view and make changes to the server whilst having simple conneciton strings to connect to it.

## 2) Front-end framework - REACT
I used React as it's a modern front end framework that has many packages that can be installed to add extra functionality. You can see I have installed react-router to handle navigation around the sight.

React also gives you the ability to quickly get started with its framework making it good for prototyping and then with its reusable components it can scale very quickly to large sized applications.

## 2a Security and performance - React
Using curly braces {DATA HERE} react can automatically escape values to prevent against some forms of attacks
I have also used React Router to aid navigation but this can also be used to perform checks before redirecting to pages, this can be used to check if people are authorised in the session before proceeding.

One of react's selling points is its "Virtual Dom" which is supposed to increase the speed of rendering and using react components compared to vanilla js or angular, however with new versions of angular they may be about the same

## 2b Security - Backend 
To allow requests from the frontend to reach the backend I have enabled Cors only for the domain of http://localhost:3000, which is the default one for the react app to start in. This is to stop other resources gaining access to the API and its backend.

# 3 You're still logging the email
This is just to show that the email has been read, in an actual case we wouldnt log this to console and we would check its valid
# If there were more time...

## 1. Completing the remaining tasks
I was greatly disapointed to not be able to complete the given tasks in the required time, in order to get as much done as possible i prioritised what i believed were the key features:
- Having the API interact with the db
- Having the FE communicate with the API and show data stored in it
- Basic Site navigation
- Basic data interaction

## 2. Unit Tests
Unit tests would be added to the API to ensure it continues to work and will not break the front end when changes are made to it.
## 3. Adding Session data
Adding session data to store the viewed pages I would likely install a react library such as Redux React Session [https://www.npmjs.com/package/redux-react-session] in order to do this, this would also allow for authentication and user security down the line.

Every time you would render a react component I would check the session to ensure it hasnt already been added, then if not I would add its ID to an array in session in order to have it on the home page.

This session could also track the "bought songs" in order to not show these ones in the home page.

## 4. Completing the Home page
The app by default gets all songs from the API, you could get song ids from the session and then the song data from the api response to show the viewied ones on the home page

## 5. Purchasing songs
The email validation would need to be done. 
Store bought songs in the session to filter them out of the home page

# Extra features outside of the original scope
1. Improve the CSS so people will want to use it
2. Add tables to db to store users and there purchased songs, user management could be done in a tool such as Azure Active Directory (move out of the session for this)
3. Cache the query to get song listings, new 80s songs are not being made, if the list is complete then you will not need to refresh them.
4. Intergrate with a payment API such as worldpay to handle the purchasing of the songs, add features to api to allow for callback
5. Storing song covers, with the addition of a resource/image folder you could store images and have the addresses stored with the songs in the db to retrieve them in the FE