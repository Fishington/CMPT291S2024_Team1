# CMPT291S2024_Team1
CMPT 291 Spring 2024 Team 1 Final Project

## Car Rental Database

## Team Members
- Mitchel Nelson 
- Trevor Farquhar
- Aidan Fisher
- Bob Blinde
- Ryan Vieira

## Project Description
A car rental system will allow customers and employees to process rental reservations. Applying different SQL queries to check for available cars on specific dates. 

# Database Design
## Connection and schema

The SQL database was connected via MSSQL Server. Within our application, we have a DBConnection.cs file, which includes methods to open and close connections to the database and execute SQL queries. The class has three main functionalities: query, insert, and delete.

In terms of schema, our application uses a creation script that performs a database creation if it does not exist and then proceeds to create tables.

In terms of insertions, our application also uses an insertion script that adds fake data that can be manipulated and changed within the application.

## Tables and referential integrity
###### Branches
A table that contains branches from which cars can be rented.
###### Employees
A table that contains employee information data. It references the branches table through the ***Branch\_ID*** foreign key, ensuring that every employee is associated with an existing branch.
###### Cars
A table that contains car information data, such as VIN, license plate, make, model, and others. It references the Branch_ID as a foreign key for the branch to which the car belongs. Also, the CarType table is referenced through the Type field for the style/function of the car.
###### CarType
A table that contains price information and type information for the style or function of a car.
###### Reservations
A table that contains information about car rental bookings, such as dates and prices. It references customers, employees, branches, and cars through foreign keys.

# Functionality Demos
### Inventory Page
Add, modify or delete the car inventory currently available.
This page also allows you to search for specific cars by Make, Model, Transmission, Type, Branch
![image](https://github.com/Fishington/CMPT291S2024_Team1/assets/76424114/c473ba08-53ca-4115-b67d-a2dafa7b9046)
Main Inventory Page

![image](https://github.com/Fishington/CMPT291S2024_Team1/assets/76424114/4b6459aa-6aee-4d4d-a6b9-4cc193b278c2)
Add Car Page

### Rental Transaction Screen
Allows the user to book a car based off of Pick Up Date, Drop Off Date, Pickup Location and Dropoff location. The data table auto-populates based on the above criteria. The user can then select the Employee and Customer who are doing the transaction. (This assumes that the employee and customer are already in the database. More Info Below)
![image](https://github.com/Fishington/CMPT291S2024_Team1/assets/76424114/f81dbbf3-0ea5-404b-9434-8f6fb10fbaf7)

### Pricing Page
This page shows a quote of how much the customer would have to pay for the car. It is broken down based on the type of vehicle and which pricing brackets they are in.
![image](https://github.com/Fishington/CMPT291S2024_Team1/assets/76424114/99a1071f-7de3-40ef-8657-fa41fc2f8f75)

### Reports Page
Users can select 5 various reports on the tabs from the top of the page, each with more reports on each tab.
###### Car Usage:
A report that displays which car makes, models, and transmissions are rented the most
###### Frequent Flyers
A report displaying a list of the most frequent renters 
###### Daily Revenue
A report showing the top revenue earning branch in daily order
###### Busy Branch Times
A report that shows the total amount of reservations per branch for each month
###### Under-performing Employees
A report displaying a list of all employees along with a sum of their revenue, counts of their bookings, and the average revenue generated per booking
![image](https://github.com/Fishington/CMPT291S2024_Team1/assets/76424114/2c49705c-5a4e-4a20-a7b4-a57cdd3567a1)

# Future Endevors
- Adding a page to add employees/customers
- UI Overhaul
- Security
- Login Page
- Manager Page (Allows for direct database access)

## Cites:

“W3schools.Com.” W3Schools Online Web Tutorials, www.w3schools.com/sql/default.asp. 


Gemini was used to create this readme.Md file:
  Prompts used:
    "Give me a template for my readme.Md file, for a database project"
