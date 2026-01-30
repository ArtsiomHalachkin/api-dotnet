# ASP.NET Core Customer & Product API

RESTful Web API built with **ASP.NET Core 8.0**. 
This project implements a architecture using the **Model-View-Controller (MVC)** pattern, focusing on data security through **DTOs** and persistent storage with **Entity Framework Core**.

## Features

* **Full CRUD**: Implementation of Create, Read, Update, and Delete endpoints for Customers and Products.
* **Data Transfer Objects (DTOs)**: Used to decouple the internal database schema from the public API.
* **Automatic Validation**: Uses C# Data Annotations for server-side validation.
* **EF Core Migrations**: Version-controlled database schema management.

## Project Structure
  
* **`Controllers/`**: Handles incoming HTTP requests and routing.
* **`Models/`**: Contains database entities representing SQL tables.
* **`DTOs/`**: Classes used for sending and receiving data through the API.
* **`Data/`**: Contains the `ApplicationDbContext` and database configurations.
