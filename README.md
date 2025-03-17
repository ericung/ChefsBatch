# ChefsBatch

ChefsBatch is a unique company in the food industry that connects professional chefs, cooks, and temporary home cooks with clients seeking high-quality, ready-to-eat meals and hot dishes. Unlike DoorDash and HelloFresh, ChefsBatch emphasizes cooking as a hobby, allowing culinary enthusiasts to share their passion and creativity. The platform offers chefs and cooks the freedom to sell their unique dishes and recipes, build their fandom, and take a break from their 9 to 5 job or line cook roles, transforming their passion for cooking into a rewarding experience.

## How to Use ChefsBatch Platform: A Rough Draft Guide for Developers

### Overview

ChefsBatch is a platform that connects professional chefs, cooks, and temporary home cooks with clients seeking high-quality, ready-to-eat meals and hot dishes. This guide provides an overview of the architecture and key components of the ChefsBatch software to help developers understand how to use and contribute to the platform.

### Architecture

The ChefsBatch platform consists of several key components:

1. **Frontend**: The user interface where customers, chefs, and cooks interact with the platform. Built using modern web technologies such as React.js.
2. **Backend**: The server-side logic that handles requests, business logic, and data management. Implemented using .NET Core.
3. **Database**: Stores user data, recipes, orders, and other relevant information. Utilizes PostgreSQL with the PostGIS extension for spatial data support.
4. **Authentication**: Manages user registration, login, and authentication. Uses JWT (JSON Web Tokens) for secure authentication.
5. **Payment Gateway**: Integrates with third-party payment services (e.g., Stripe) to handle transactions securely.
6. **Notifications**: Sends real-time notifications to users about order status, promotions, and other updates. Utilizes services such as SignalR for real-time communication.

### Getting Started

#### Prerequisites

- .NET Core SDK installed on your machine.
- PostgreSQL instance running locally or in the cloud.
- Stripe account for payment processing.

#### Setting Up the Development Environment

1. **Clone the Repository**
   ```sh
   git clone https://github.com/ericung/ChefsBatch.git
   cd ChefsBatch
   ```

2. **Install Dependencies**
   ```sh
   dotnet restore
   ```

3. **Configure Environment Variables**
   Create a `appsettings.json` file in the root directory and
