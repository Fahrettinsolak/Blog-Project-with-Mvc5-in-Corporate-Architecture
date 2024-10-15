# Corporate-Architecture-with-Mvc5-Blog-Project

This project is a blog management system developed in accordance with the principles of **N-Layered Architecture**. The project offers different authorizations and functions for users, authors and admins. At the end of the project, you can learn **MVC5** structure, **Entity Framework** usage, **Layered Architecture** and many more topics.

## Project Summary

### User Section
- Users can view all existing blogs after logging in to the site.
- They can comment on blogs and list blogs belonging to an author or category.

### Author Section
- Authors can create new blog posts and edit their own posts.
- They can see comments on their own posts.
- They can send messages to other authors or admins.

### Admin Section
- Admin has authority over category, blog, communication and all other menus.
- They can delete comments and manage the system.

## Installation and Operation

### Requirements
- Visual Studio 2019 or later
- .NET Framework 4.7.2
- MSSQL Server

### Installation Steps
1. Download the project files to your computer.

2. Open the project with Visual Studio.

3. Upload the database file in the `App_Data` directory to MSSQL Server.

4. Open the `Web.config` file in the project and edit your database connection string.

5. Run the project and test it in your development environment.

### Moving to Live
When the project is complete, you can move the project to live by getting a real domain name and server. To do this:
1. Install IIS on the server.

2. Transfer your database to the server.

3. Upload the project files to the server and update your connection string in the `Web.config` file.

4. Publish your web application via IIS.

## Project Structure

The project consists of the following layers according to the **N-Tier Architecture** principles:
- **DataAccess**: This is the layer used for database operations.
- **Entity**: This is the layer where the model classes used in the project are located.
- **Business**: This is the layer where the business logic is written.
- **Presentation**: This is the user interface (UI) layer.

## Some Photos from the Project

![1](https://github.com/user-attachments/assets/93a00bdc-88ff-434d-b862-d2820b8618eb)

![2](https://github.com/user-attachments/assets/f284f819-0cde-4e21-adbf-86eebbe12510)

![3](https://github.com/user-attachments/assets/5b361ca6-b9db-4be2-a27f-8d9a9bd14a9c)

![4](https://github.com/user-attachments/assets/bcb3e29c-a17a-4268-a012-2dec7d011fcb)

## Topics to Learn

When you complete this project, you will have knowledge of the following topics:
- Layout Control
- Controller Structure
- N-Tier Architecture
- Repository Design Pattern
- Generic Repository
- Layered Architecture Principle
- Partial View
- Code First Approach
- Using Entity Framework
- Model and View Structure
- LINQ and Entity Framework Queries
- Working with Related Tables
- Diagrams and Database Schema
- Using Triggers
- Creating Procedures
- Installing and Editing Ready Templates
- CSS Controls and Bootstrap Structure
- Creating Dynamic Web Projects
- Dashboard and Chart Usage
- Widget Cards Usage

## Technologies Used
- ASP.NET MVC 5
- Entity Framework
- MSSQL
- Bootstrap
- LINQ
- C#

## Contributors
- **[Your Name]** - Project development and management.

## License
This project is licensed under the MIT License - see the `LICENSE` file for details.

## Contact
For any questions or feedback, please contact me at [email@ornek.com](mailto:email@ornek.com).

---

Good luck developing and bringing your project to life!


