Build a Real-World Web App with .NET Core and Razor Pages
===========

This project demonstrates the power of object-oriented programming (OOP) concepts like abstract classes, polymorphism, and dynamic updates using Razor Pages in C# .NET Core. Follow along to learn how to build a dynamic web application that allows you to manage employees with features like adding, editing, and deleting records - without refreshing the page.

## Features

- **Dynamic Employee Management**: Add, edit, and delete employees dynamically using AJAX.
- **Object-Oriented Design**: Explore the use of an abstract `Employee` class and its concrete subclasses.
- **Razor Pages**: Build a clean and modular web application using Razor Pages.
- **AJAX Integration**: Update the UI dynamically without full-page reloads.
- **Polymorphism in Action**: See how different employee types (e.g., full-time, contractor) are handled seamlessly.

## Technologies Used

- **.NET Core**: Backend framework for building the web application.
- **Razor Pages**: Simplified page-based architecture for building web UIs.
- **C#**: Programming language used for backend logic.
- **AJAX**: For dynamic updates to the UI.
- **HTML/CSS**: For structuring and styling the web pages.

## Project Structure

```
c:\Users\kory\Desktop\Employees
│
├── Employees
│   ├── Pages
│   │   ├── Index.cshtml          # Main Razor Page for the app
│   │   ├── Index.cshtml.cs       # Backend logic for Index Razor Page
│   │   ├── Shared
│   │   │   ├── _EmployeeTable.cshtml # Partial view for the employee table
│   ├── Controllers (Optional)    # For future Web API integration
│   ├── Types
│   │   ├── Employee.cs           # Abstract base class for employees
│   │   ├── Concrete
│   │   │   ├── FullTimeEmployee.cs # Concrete subclass for full-time employees
│   │   │   ├── Contractor.cs     # Concrete subclass for contractors
│   ├── Managers
│   │   ├── EmployeeManager.cs    # Utility for generating employee data
│
└── readme.md                     # Project documentation
```

## Key Concepts

### 1. **Abstract Classes**
The `Employee` class is an abstract base class that defines common properties and methods for all employee types. Concrete subclasses like `FullTimeEmployee` and `Contractor` inherit from this base class.

### 2. **Polymorphism**
The application demonstrates polymorphism by treating all employee types uniformly while allowing specific behavior for each subclass.

### 3. **Dynamic Updates with AJAX**
AJAX is used to handle form submissions (e.g., Save, Delete) without reloading the page. This improves user experience and performance.

### 4. **Razor Pages**
The project uses Razor Pages for a clean and modular architecture. The `_EmployeeTable` partial view is dynamically updated using AJAX.

## How to Run the Project

1. **Clone the Repository**:
   ```bash
   git clone <repository-url>
   cd Employees
   ```

2. **Build the Project**:
   Open the project in Visual Studio or use the .NET CLI:
   ```bash
   dotnet build
   ```

3. **Run the Application**:
   ```bash
   dotnet run
   ```

4. **Access the App**:
   Open your browser and navigate to `http://localhost:5000`.

## How It Works

1. **Employee Management**:
   - The `Index.cshtml` page displays a table of employees.
   - The `_EmployeeTable.cshtml` partial view is used to render the table dynamically.

2. **AJAX Integration**:
   - JavaScript intercepts form submissions (e.g., Save, Delete) and sends AJAX requests to Razor Page handlers.
   - The table is updated dynamically without a full-page reload.

3. **Object-Oriented Design**:
   - The `Employee` base class defines shared properties like `Name`, `Department`, and `GetRate()`.
   - Subclasses like `Contractor` and `FullTimeEmployee` extend the base class with specific behavior.

## Future Enhancements

- **Web API Integration**: Add RESTful endpoints for better scalability and integration with front-end frameworks like React or Angular.
- **Authentication**: Secure the application with user authentication and role-based access control.
- **Pagination**: Add pagination for managing large datasets.

## Conclusion

This project is a hands-on demonstration of building a real-world web application using Razor Pages in .NET Core. It showcases the power of OOP concepts like abstract classes and polymorphism while integrating modern web development techniques like AJAX for a seamless user experience.

---

Happy coding! 🚀