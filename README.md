GOALS
This project aims to develop of a .NET Core(C#) Restful backend service for a shopping platform.It establishes a well-designed SQLServer database with six tables (User, Category, Product, Payment, Order, Orderdetail) and foreign key relationships to support the platform's data needs. The tables created and integrated into C# are as follows :

CREATE TABLE Users (
    UserId INT PRIMARY KEY,
    UserName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL
);

CREATE TABLE Products (
    ProductId INT PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    CategoryId INT,
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);

CREATE TABLE Categories (
    CategoryId INT PRIMARY KEY,
    CategoryName VARCHAR(50) NOT NULL
);

CREATE TABLE Orders (
    OrderId INT PRIMARY KEY,
    UserId INT,
    OrderDate DATETIME NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL,
    PaymentId INT,   //Added for the relationship with Payments table
    FOREIGN KEY (UserId) REFERENCES Users(UserId),
    FOREIGN KEY (PaymentId) REFERENCES Payments(PaymentId)
);

CREATE TABLE OrderDetails (
    OrderDetailId INT PRIMARY KEY,
    OrderId INT,
    ProductId INT,
    Quantity INT NOT NULL,
    Subtotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);

CREATE TABLE Payments (
    PaymentId INT PRIMARY KEY,
    OrderId INT,
    PaymentDate DATETIME NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    PaymentMethod VARCHAR(50) NOT NULL,
    TransactionId VARCHAR(100) NOT NULL,
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId)
);

User authentication is prioritized through the implementation of JWT token-based security and integration of Identity Framework for user management, roles, and access control. Additionally, the project enhances user experience by incorporating an email service for account verification. The development process is version-controlled using GitHub, and the final service is deployed on Microsoft Azure for accessibility and scalability.

FUNCTIONALITIES
The backend service provides RESTful APIs, offering essential CRUD operations for managing entities crucial to the shopping platform. Authentication is implemented using Identity Framework, ensuring secure access to the APIs through JWT tokens. Distinct user roles (Admin, Developer,Guest, Customer and Manager) with specific access permissions are configured, and the application integrates an email service to send confirmation emails upon user sign-up. Proper error handling and validation mechanisms are in place to ensure data integrity and security. The code is properly organized using Dependency Injection for better maintainability, and logging mechanisms track application events for improved visibility.

TECHNOLOGIES 

The project utilizes .NET Core (C#) as the primary development framework for building the RESTful backend service. The database is powered by SQLite Server, providing a well-structured schema with foreign key relationships. JWT tokens are employed for user authentication and authorization, and the Identity Framework manages user roles and access control. The email service enhances user engagement by sending confirmation emails. GitHub serves as the version control repository, maintaining a clear history of changes. The final deployment is hosted on Microsoft Azure, leveraging its services for efficient hosting and scaling.






