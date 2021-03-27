# <div align="center"> **Pierre's Sweet and Savory Treats** </div>
### This is a web application in order to track treats and flavors using database setup through Entity Framework Core with Indentity for Authentication.

 ### _Contributor(s) and Contact Info_
> Tien Nguyen [GitHub](https://github.com/Tien96ng)

---

## _Technologies Used_ ⚙

* **C# 9.0**
* **.NET 5.0.102**
* **SDK 8.0.19**
* **Razor**
* **Bootstrap 4.5**
* **HTML 5 / CSS3**
* **My SQL 8.0.19 / WorkBench 8.0.19**
* **Entity Framework**
* **HTML Helper**

---

## _Description_ 📃
A MVC web application for "Pierre's Sweet and Savory Treats" that is used as a viewing platform for flavor and treat enthusiast. The platform stores both Flavors and Treats. It works as a Many-To-Many relationship in order to have multiple Treats having many flavors and vice versa. With the utilization of the Entity Framework, MySQL, and Identity, the app can store the create the database and tables via the Models and store them collectively. Currently without a user account, an anonymous viewer can only have READ access. When you sign up and log into your account, it allows full CRUD functionality.

---

## _Installation Guide_ 💻 

<details>
<summary>Open for full Guide</summary>

### _Cloning and Initial Setup_

> Repository: 
1. In your terminal of choice or [GitHub's Desktop Application](https://desktop.github.com/) , clone the above repository from Github. For further explanation on how to clone this repository, please visit [GitHub's Documentation](https://docs.github.com/en/github/using-git/which-remote-url-should-i-use).
2. Ensure you are running .NET Core SDK by using the command dotnet --version in your terminal. If a version number is not presented, please visit [this download page for .NET 5 and install the applicable software for your OS](https://dotnet.microsoft.com/download/dotnet/5.0). 
3. Once you verify you are running a .NET 5, navigate in your terminal to Treat Tracker directory within the treats-tracker directory you just cloned. Once there, run "dotnet build" in your terminal to build application within directory. 
4. In your terminal, while still in treat tracker directory, run "dotnet restore."
5. You will require a text or code editor to complete the following steps. [VS Code is recommended](https://code.visualstudio.com/)


### _Installation: Database Recreation_

1. Ensure you are running MySQL Server 8 and MySQL WorkBench 8. If you are running windows, use the [Windows Installer ](https://dev.mysql.com/downloads/installer/) for MySQL and follow the instructions provided by the installer. For Macs, visit [MySQL Commuinity Downloads](https://dev.mysql.com/downloads/mysql/) and select macOS from the Operation Systems. This will be a manual installation. If you need additonal assistance on this, please visit Epicodus's [Learn How to Program Article](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).
2. Once you verify you have SQL installed, create a file called "appsettings.json" in the root directory treat-tracker. Paste the following into this file.
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port={PORT OF SERVER};database=treat-tracker;uid=root;pwd={PASSWORD OF SERVER};"
  }
}
```
3. In your terminal, run "dotnet ef database update"
### _Installation: General Use_

1. Back in your terminal in the treat tracker production directory, type "dotnet run." The terminal will present local host routes for you to navigate to in your browser. An example would be "http://localhost:5000." Enter this into a web browser of choice to use this application. Keep the terminal running as it is being used to control the local server.
2. When finished, exit the terminal or use the command "CTRL C"(Windows) or "CMD C"(Mac) to shut down the local server.

</details>

---

## _Known Bugs_ 🩹
* No known bugs at this time (3/26/2021). Please contact a contributor to report any bugs found during use.

---

## _Future Updates_ 🛠
* Additional UI
* Have separate roles for admins and logged-in users. Only admins should be able to add, update and delete.
* Add an order form that only logged-in users can access. A logged-in user should be able to create, read, update and delete their own order.

---

## _License_ ⚖️

[![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2021 Tien Nguyen.

Please contact Contributor for further use information or if you would like to make a contribution.