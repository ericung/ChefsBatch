# ChefsBatch

ChefsBatch is a unique platform in the food industry that connects professional chefs, passionate cooks, and even temporary home cooks with clients looking for high-quality, ready-to-eat meals and hot dishes. Unlike other food delivery or meal kit services, ChefsBatch celebrates cooking as a creative hobby—giving culinary enthusiasts the opportunity to share their distinctive recipes, build a fanbase, and even take a break from the conventional 9-to-5 routine. Whether you’re a professional chef or just someone who loves to experiment in the kitchen, ChefsBatch transforms your passion into a rewarding experience.

---

## Table of Contents

- [Overview](#overview)
- [Architecture](#architecture)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Setting Up the Development Environment](#setting-up-the-development-environment)
- [Key Features](#key-features)
- [Configuration](#configuration)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

---

## Overview

ChefsBatch is designed to seamlessly connect culinary creators with eager customers. Our platform emphasizes not just the exchange of services, but also the sharing and appreciation of the art of cooking. Through our easy-to-use interface, chefs and cooks can list their homemade creations while customers can discover, order, and enjoy a variety of meals, making every dining experience memorable.

---

## Architecture

ChefsBatch is built on a modern, robust, and scalable architecture:

- **Frontend:**  
  The frontend is built using **React.js**, offering a sleek and responsive user interface where customers, chefs, and cooks interact with the platform.
  
- **Backend:**  
  The service layer is implemented in **.NET Core** which handles business logic, processes requests, and communicates with the database.
  
- **Database:**  
  We use **PostgreSQL** as our primary database with the **PostGIS** extension enabled for spatial data support, allowing us to handle location-based queries and services effectively.
  
- **Authentication:**  
  User registration, login, and secure session management are handled using **JWT (JSON Web Tokens)**. This ensures that access to our services is both secure and efficient.
  
- **Payment Gateway:**  
  All transactions are processed via third-party payment services, notably **Stripe**, ensuring secure and reliable payment handling.
  
- **Notifications:**  
  To enhance user engagement, ChefsBatch integrates real-time notifications using services like **SignalR** for instant updates on order status, promotions, and other important events.

This architecture is designed to offer robust performance, easy scalability, and a seamless user experience across different roles on the platform.

---

## Getting Started

This guide will walk you through setting up your local development environment so you can contribute to ChefsBatch.

### Prerequisites

Before you begin, ensure you have the following installed:
- **.NET Core SDK** (compatible version as specified in the repository documentation)
- **Node.js** (for running React development server)
- **PostgreSQL** with **PostGIS** extension enabled (running locally or via a cloud service)
- **Stripe account** (for handling and testing payment processing)

### Setting Up the Development Environment

1. **Clone the Repository**

   Open your terminal and run:
   
   ```bash
   git clone https://github.com/ericung/ChefsBatch.git
   cd ChefsBatch
   ```

2. **Install Dependencies**

   For the backend:
   
   ```bash
   dotnet restore
   ```
   
   For the frontend (if needed):
   
   ```bash
   cd frontend
   npm install
   ```

3. **Configure Environment Variables**

   Create an `appsettings.json` file in the root directory of the backend and configure the necessary database connections, JWT secret keys, and Stripe API keys:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Host=your_host;Port=5432;Database=chefsbatch;Username=your_username;Password=your_password"
     },
     "JWT": {
       "SecretKey": "YOUR_SECRET_KEY_HERE",
       "Issuer": "ChefsBatch",
       "Audience": "ChefsBatchUsers",
       "ExpiryMinutes": 60
     },
     "Stripe": {
       "ApiKey": "YOUR_STRIPE_API_KEY"
     },
     "SignalR": {
       "HubUrl": "your_signalr_hub_url"
     }
   }
   ```

4. **Run the Application**

   - **Backend:**  
     From the root directory, run:
     
     ```bash
     dotnet run
     ```
     
   - **Frontend:**  
     In a separate terminal, navigate to the `frontend` folder and run:
     
     ```bash
     npm start
     ```
     
   The application should now be running, and you can access it in your browser.

---

## Key Features

- **Unified Platform:**  
  Connects chefs, home cooks, and professional cooks with diners who value creative, ready-to-eat meals.
  
- **Dynamic Menu Building:**  
  Chefs can list unique and seasonal dishes, manage orders, and build an online community around their cooking.
  
- **Secure Transactions:**  
  Integrated payment processing with Stripe ensures all financial transactions are smooth and secure.
  
- **Real-Time Updates:**  
  Real-time notifications keep users informed about order statuses and promotional events.
  
- **Location-Based Services:**  
  With PostGIS-enabled PostgreSQL, ChefsBatch supports location-based search to find nearby talent and delivery options.

---

## Configuration

For a streamlined setup, here are some common configurations you may need to adjust:

- **Database Migrations:**  
  Use EF Core commands to apply database migrations:
  
  ```bash
  dotnet ef migrations add InitialCreate
  dotnet ef database update
  ```

- **JWT Token Configuration:**  
  Update the `appsettings.json` with a strong `SecretKey` and adjust the token expiry values as required.

- **Third-party Integrations:**  
  Ensure your Stripe and SignalR credentials are correctly set up in the configuration files.

---

## Contributing

We welcome contributions from developers who are passionate about revolutionizing the culinary experience. If you’d like to contribute, please follow these steps:

1. **Fork** the repository.
2. **Create** a new branch for your feature or bug fix:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. **Commit** your changes with clear and descriptive commit messages.
4. **Push** your changes to your fork.
5. **Submit** a pull request detailing the changes and improvements.

For more detailed contribution guidelines, please refer to the `CONTRIBUTING.md` file in the repository.

---

## License

ChefsBatch is licensed under the [MIT License](LICENSE). Feel free to use, modify, and distribute the code as long as you comply with the license terms.

---

## Contact

For any queries or issues, please create an issue in the repository or contact the maintainers through the repository’s discussion forum. Stay connected for updates and follow our journey as we bring the art of cooking closer to those who crave it.

---

ChefsBatch is more than just a platform—it’s a community where food meets creativity. Whether you’re a seasoned chef or someone looking to transform their passion into a culinary career, ChefsBatch offers the freedom, tools, and community to help you grow. Dive into the code, explore the architecture, and be a part of our culinary revolution.

*Happy Cooking & Happy Coding!*

