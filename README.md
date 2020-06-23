Quiz App
========
Welcome to the QuizApp.

The project has two roles
1. Admin
2. Player

Quiz is based on two catagories.
1. Cricket
2. Football

Questions appeared in quiz are either cricket related or football related. MYSQL is used as a database.

#### Note
> Quiz app for my university ...and it's my semester project. This project is meant to be used for learning and researching purpose only and it is **not** meant to be used for production.

Gettind Started
===============
Follow these instructions to build and run the project. 

Note that there will be no questions you need to add questions after login as an admin then signup as player and play the game. 
1. Download and Install **Visual Studio 2019** or **equivalent** from [Microsoft](https://visualstudio.microsoft.com/downloads/).
2. Download and install **MYSQL 8.0.20 server** or **equivalent** from [MYSQL](https://dev.mysql.com/downloads/mysql/).
3. Download and install **MYSQL Workbench 8.0.20** or **equivalent** from [MYSQL](https://dev.mysql.com/downloads/workbench/).
4. Download and install **MySQL for Visual Studio 1.2.9** or **equivalent** from [MYSQL](https://dev.mysql.com/downloads/windows/visualstudio/).
5. Download and install **MYSQL Connector/NET 8.0.20** or **equivalent** from [MYSQL](https://dev.mysql.com/downloads/connector/net/).
6. Download **Guna.UI-Framework-Lib** from [GunaUI](https://github.com/sobatdata/Guna.UI-Framework-Lib) and add in visual studio. [Youtube Video Link](https://www.youtube.com/watch?v=0lFI3vfY5dg/).
7. Clone the QuizApp repository
```sh
$ git clone https://github.com/MyCodeWheel/Quiz-App.git
```
8. Navigate to MySQl Workbench Folder
```sh
$ cd Quiz-App/Quiz-App/MySQl_WorkBenchFile/
```
9. Open `mysql.sql` file in `MYSQL Workbench` and execute all the commands to create database and tables.
10. Now, Navigate to project Folder
```sh
$ cd ../
```
11. Open the Project in visual studio
```sh
$ explorer Quiz-App.sln
```
12. Varify the MYSQL username or password in `Quiz-App/MySQL_Data_Base/MySqlDB.cs` file. change the username or password if required.
<img src="https://github.com/MyCodeWheel/Quiz-App/blob/master/Quiz-App/Documentation/Screenshots/connectDBFun.PNG" alt="Varify MYSQL username or password and change if required">

13. For admin use **username=** `admin` and **password=** `admin`.
14. For player create new username or password after signup or use **username=** `user` and **password=** `user`.
15. Enjoy

***
Roles
=====
##  1. Admin
The admin could do the followiing operation
- Admin could add new questions for the quiz. Each question is saved in Database.
- Admin could drop questions from the database.
- Admin could update the existing questions and changes will saved in the database.
- Admin could view the list of questions saved in database.

### Admin window Forms
<hr>

#### Form: mainAdminForm
The is the home form of admin. From this form admin could open subforms for `adding`, `removing`, `updating` and `viewing` questions.

**Screenshot**

<img src="https://github.com/MyCodeWheel/Quiz-App/blob/master/Quiz-App/Documentation/Screenshots/admnHomeScreen.png"  alt="Admin Home Screen" width="400" height="500">.

#### Form: AdminForm_AddQuestion
At this form admin could add new questions for quiz. Each and every question will stored in database.
- Each question required specific id. In case of existing id error will rise and id should be in int.
- Each question should be unique. Project will not allow you to add same question again.

**Screenshot**

<img src="https://github.com/MyCodeWheel/Quiz-App/blob/master/Quiz-App/Documentation/Screenshots/adminAddQuestionScreen.png" alt="Admin Add Question Screen" width="400" height="500">

#### Form: AdminForm_DeleteQuestion
At this form admin could drop questions from database.
- To get the question from database id will used.
- If id is not present in databse error will rise and id should be in int.

**Screenshot**

<img src="https://github.com/MyCodeWheel/Quiz-App/blob/master/Quiz-App/Documentation/Screenshots/adminRemoveQuestionScreen.png" alt="Admin Delete Question Screen" width="400" height="500">

#### Form: AdminForm_UpdateQuestion
At this form admin could update the existing questions and changes will saved in the database.
- To get the question from database id will used.
- If id is not present in databse error will rise and id should be in int.
- Each question should be unique. Project will not allow you to add same question again.


**Screenshot**

<img src="https://github.com/MyCodeWheel/Quiz-App/blob/master/Quiz-App/Documentation/Screenshots/adminUpdateQuestionScreen.png" alt="Admin Update Question Screen" width="400" height="500">

#### Form: AdminForm_ViewQuestion
At this form admin could view the list of questions saved in database.

**Screenshot**

<img src="https://github.com/MyCodeWheel/Quiz-App/blob/master/Quiz-App/Documentation/Screenshots/adminViewQuestionScreen.png" alt="Admin View Question Screen" height="500">

##  2. Player
The player could do the followiing operation
- Player could play the game. There are total 10 questions. and each question is appeared for 15 seconds
- Player could set the catagory of question that will appeared in quiz.
- Admin could view the previous played games result with respect to specific date and time.

### Player window Forms
<hr>

#### Form: mainGameForm
The is the home form of player. From this form player could open subforms for `playing game`, `options` and `view previous results`.

**Screenshot**

<img src="https://github.com/MyCodeWheel/Quiz-App/blob/master/Quiz-App/Documentation/Screenshots/playerHomeScreen.png" alt="Player Home Screen" width="400" height="500">

#### Form: GameForm_PlayGame
At this form player could play the game. 
- There are total 10 questions.
- Each question is appeared for 15 seconds.
- There are total 50 points and each question is for 5 points and 0 points for not attempting question.
- You can quit game anytime.

**Screenshot**

<img src="https://github.com/MyCodeWheel/Quiz-App/blob/master/Quiz-App/Documentation/Screenshots/playerPlayGameScreen.png" alt="Player Play Game Screen" width="400" height="500">

#### Form: GameForm_OptionGamForm
At this form player could set the catagory of questions appeared in quiz.
- There are 2 catagories for questions. `cricket` or `football`.
- By default `cricket` based questions will appeared.
- You can change catagory anytime. Change will not saved in database.

**Screenshot**

<img src="https://github.com/MyCodeWheel/Quiz-App/blob/master/Quiz-App/Documentation/Screenshots/playerOptionsScreen.png" alt="Player Option Screen" width="400" height="500">

#### Form: GameForm_ResultGame
At this form player could view the result of all previous played games with respect to date and time.

**Screenshot**

<img src="https://github.com/MyCodeWheel/Quiz-App/blob/master/Quiz-App/Documentation/Screenshots/playerViewResultScreen.png" alt="Player View Result Screen" width="400" height="500">

***
Login and Signup Screen
=======================

**Login Screen**

<img src="https://github.com/MyCodeWheel/Quiz-App/blob/master/Quiz-App/Documentation/Screenshots/loginScreen.png" alt="Login Form" width="400" height="500">.

**Signup Screen**

<img src="https://github.com/MyCodeWheel/Quiz-App/blob/master/Quiz-App/Documentation/Screenshots/signupScreen.png" alt="Signup Form" width="400" height="500">.

***
 Contributing
=============
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change. 
***
License
=======
The source code is released under the [MIT Licence](https://choosealicense.com/licenses/mit/)
