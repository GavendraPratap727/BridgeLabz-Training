# 🚀 Backend Refresher Training — BridgeLabz

A complete 20-day intensive journey covering everything from relational database fundamentals to building a fully decoupled, enterprise-grade Microservices architecture in ASP.NET Core.

---

## 🗄️ Phase 1: Database & Data Access Mastery

<details open>
<summary><b>Day 1 | DB Programming</b></summary>

> **Status:** ✅ Done | **Focus:** MS SQL Server & Schema Design

**💡 Topics Covered**
* **DBMS vs. RDBMS:** Relational vs. Non-Relational databases and when to use each.
* **Tools:** MS SQL Server & T-SQL introduction.
* **RDBMS Fundamentals:** Core concepts of database structure and management.

**🛠️ Tasks Completed**
* **Setup:** Configured MS SQL Server environment.
* **Design:** Sketched ER Diagram for Health Clinic App (*Patients, Doctors, Appointments*).
* **Code:** Wrote and pushed schema creation SQL scripts.
</details>

<details>
<summary><b>Day 2 | DB Programming & Indexing</b></summary>

> **Status:** ✅ Done | **Focus:** Advanced RDBMS & Query Optimization

**💡 Topics Covered**
* **Database Concepts:** Entities, Attributes, Relationships, Cardinality, and Keys.
* **Indexes:** Clustered, Non-Clustered, Unique, and Composite Indexes.
* **Database Normalization:** 1NF, 2NF, 3NF, and BCNF principles.

**🛠️ Tasks Completed**
* Added a `rooms` table and created a `doctor_room` relationship.
* Executed on 3 `appointments` queries (No Index, Single-Column Index, Composite Index) and analyzed `type` and `rows` metrics.
* Verified `patient_phones` against 1NF, 2NF, and 3NF with written justifications.
* Created a covering index for `doctor_id`, `appointment_date`, and `status`, verifying index usage via `EXPLAIN`.
</details>

<details>
<summary><b>Day 3 | DB Programming – Joins, Stored Procedures & Triggers</b></summary>

> **Status:** ✅ Done | **Focus:** SQL Automations & Loggings

**💡 Topics Covered**
* **SQL Joins:** Inner, Left, Right, and Full Outer Joins.
* **Stored Procedures:** Parameterized execution for DB operations.
* **Database Triggers:** DML triggers (`INSERT`, `UPDATE`, `DELETE`) for automation.
* **Audit Logging:** Tracking data modifications.

**🛠️ Tasks Completed**
* Implemented Joins queries on the Health Clinic database.
* Created stored procedures for `Patients`, `Doctors`, `Appointments`, `Billing`, and `VisitHistory`.
* Designed an `AuditLog` table and implemented triggers to automatically log changes from critical tables.
</details>

<details>
<summary><b>Day 4 | ADO.NET & Health Clinic App Completion</b></summary>

> **Status:** ✅ Done | **Focus:** Disconnected Architecture & C# Integration

**💡 Topics Covered**
* **ADO.NET Basics:** Connected and Disconnected Architecture.
* **SQL Server Connectivity:** Connecting a .NET application with MS SQL Server using ADO.NET.
* **CRUD Operations:** Using `SqlConnection`, `SqlCommand`, `SqlDataReader`, and `SqlDataAdapter`.

**🛠️ Tasks Completed**
* Connected the Health Clinic console application to MS SQL Server.
* Implemented CRUD operations for all entities.
* Mapped the finalized database schema with the application.
</details>

---

## 🌐 Phase 2: Web API & ASP.NET Core Fundamentals

<details>
<summary><b>Day 5 | Backend Basics – ASP.NET Core, WebAPI & RESTful Services</b></summary>

> **Status:** ✅ Done | **Focus:** REST Architecture

**💡 Topics Covered**
* **ASP.NET Core:** Framework architecture.
* **Web API:** Server-client communication.
* **RESTful Services:** REST principles, HTTP methods, status codes, and API design.
* **Project Structure:** Controllers, routing, and middleware.

**🛠️ Tasks Completed**
* Scaffolded a basic ASP.NET Core Web API project.
* Created sample API controllers with RESTful endpoints.
* Implemented basic CRUD operations using in-memory data.
</details>

<details>
<summary><b>Day 6 | MVC Pattern & REST Request Handling</b></summary>

> **Status:** ✅ Done | **Focus:** Model View Controller

**💡 Topics Covered**
* MVC architecture: Model, View, and Controller.
* HTTP requests, responses, controllers, and routing.

**🛠️ Tasks Completed**
* Created a **Greeting App** using ASP.NET Core MVC.
* Implemented basic controllers, views, and routing.
</details>

<details>
<summary><b>Day 7 | Minimal APIs</b></summary>

> **Status:** ✅ Done | **Focus:** Lightweight API Endpoints

**💡 Topics Covered**
* Minimal APIs in ASP.NET Core.
* Request and response handling without heavy controllers.

**🛠️ Tasks Completed**
* Created a **Contacts App backend** using Minimal APIs.
* Implemented basic CRUD endpoints.
</details>

<details>
<summary><b>Day 8 | Swagger & API Testing</b></summary>

> **Status:** ✅ Done | **Focus:** API Documentation

**💡 Topics Covered**
* Swagger / OpenAPI documentation.
* Introduction to distributed architecture.

**🛠️ Tasks Completed**
* Integrated **Swagger** into the Contacts App.
* Tested and documented API endpoints using Swagger UI.
</details>

---

## 🏗️ Phase 3: Entity Framework Core & Architecture

<details>
<summary><b>Day 9 | Entity Framework Core</b></summary>

> **Status:** ✅ Done | **Focus:** ORMs & DbContext

**💡 Topics Covered**
* ORM and Entity Framework Core.
* Entities, `DbContext`, and Dependency Injection.

**🛠️ Tasks Completed**
* Converted the **Contacts App** to use Entity Framework Core.
* Implemented database-based CRUD operations.
</details>

<details>
<summary><b>Day 10 | Entity Framework & N-Tier Architecture</b></summary>

> **Status:** ✅ Done | **Focus:** Layered Architecture

**💡 Topics Covered**
* LINQ to Entities.
* N-Tier / layered architecture separation of concerns.

**🛠️ Tasks Completed**
* Created **AddressBookWebApp** using EF Core.
* Implemented the application using **N-Tier Architecture**.
* Used LINQ for database querying.
</details>

<details>
<summary><b>Day 11 | Entity Framework – Migrations & DbContext</b></summary>

> **Status:** ✅ Done | **Focus:** Schema Evolution

**💡 Topics Covered**
* EF Core Migrations.
* Database-first vs Code-first workflows.

**🛠️ Tasks Completed**
* Used **EF Core Migrations** for database schema management.
* Configured `DbContext` for the Address Book applications.
</details>

---

## 📒 Phase 4: Advanced Backend (Fundoo Notes App)

<details>
<summary><b>Day 12 | WebAPI REST Verbs & HttpClient</b></summary>

> **Status:** ✅ Done | **Focus:** Fundoo Notes Initialization

**💡 Topics Covered**
* Advanced REST verbs: GET, POST, PUT, PATCH, and DELETE.
* Action methods in ASP.NET Core Controllers.

**🛠️ Tasks Completed**
* Started the **Fundoo Notes App** backend.
* Implemented the **User Management Module** (registration and login).
</details>

<details>
<summary><b>Day 13 | DI, Routing, Reverse Proxy & CORS</b></summary>

> **Status:** ✅ Done | **Focus:** Gateway & Injection

**💡 Topics Covered**
* Dependency Injection in ASP.NET Core.
* Routing configuration and Reverse Proxy concepts.
* CORS (Cross-Origin Resource Sharing).

**🛠️ Tasks Completed**
* Implemented the foundation of **Authentication & Authorization**.
* Configured dependency injection, routing, and CORS for API access.
</details>

<details>
<summary><b>Day 14 | JWT Authentication & Authorization</b></summary>

> **Status:** ✅ Done | **Focus:** Secure Tokens

**💡 Topics Covered**
* JWT-based authentication.
* Authentication vs. Authorization.

**🛠️ Tasks Completed**
* Completed **Authentication & Authorization** for the Fundoo Notes App.
* Added the **Notes Management Module** (create, update, get, delete).
</details>

<details>
<summary><b>Day 15 | EF Core, CQRS & LINQ</b></summary>

> **Status:** ✅ Done | **Focus:** Advanced Data Fetching

**💡 Topics Covered**
* Advanced EF Core patterns.
* Advanced LINQ queries.

**🛠️ Tasks Completed**
* Implemented **Pin, Archive, and Trash** functionality.
* Added **Search and Filter** functionality using LINQ.
</details>

<details>
<summary><b>Day 16 | Pub/Sub, Testing, Logging & API Docs</b></summary>

> **Status:** ✅ Done | **Focus:** Testing & Logging

**💡 Topics Covered**
* Publish-Subscribe pattern for event-driven communication.
* Unit testing (MSTest) & Logging (NLog).

**🛠️ Tasks Completed**
* Added **Tags / Labels Management** to Fundoo Notes.
* Created unit tests using **MSTest**.
* Implemented backend operation logging.
</details>

<details>
<summary><b>Day 17 | Identity, Filters & Session Management</b></summary>

> **Status:** ✅ Done | **Focus:** RabbitMQ & Background Tasks

**💡 Topics Covered**
* Web API filters.
* Asynchronous processing using RabbitMQ.

**🛠️ Tasks Completed**
* Implemented the **Reminder & Notification Module**.
* Used **RabbitMQ** for asynchronous background queue processing.
</details>

<details>
<summary><b>Day 18 | REST API Security & Caching</b></summary>

> **Status:** ✅ Done | **Focus:** Redis Optimization

**💡 Topics Covered**
* Encryption, decryption, and hashing.
* Redis caching and performance optimization.

**🛠️ Tasks Completed**
* Implemented **caching using Redis**.
* Improved API performance.
* Consolidated the **Fundoo Notes App backend**.
</details>

---

## 🚀 Phase 5: Microservices Transition

<details>
<summary><b>Day 19 | Microservices Architecture & YARP</b></summary>

> **Status:** ✅ Done | **Focus:** Architectural Refactoring

**💡 Topics Covered**
* Monolithic vs. Microservices Architecture.
* API Gateways and YARP (Yet Another Reverse Proxy).
* Database-per-service isolation patterns.

**🛠️ Tasks Completed**
* Split the Fundoo Notes Monolith into independent services (`IdentityService`, `NotesService`, `LabelService`).
* Implemented **YARP API Gateway** to route traffic transparently.
* Isolated SQL Server databases to remove foreign key dependencies between domains.
</details>

<details>
<summary><b>Day 20 | Inter-Service Communication & Integration</b></summary>

> **Status:** ✅ Done | **Focus:** Network Independence & Delivery

**💡 Topics Covered**
* Secure internal HTTP communication between decoupled services.
* Handling JWT Authorization across distributed APIs.
* End-to-end microservice testing.

**🛠️ Tasks Completed**
* Integrated `ReminderSchedulerService` in the Notes Service to securely fetch user emails from the `IdentityService` via HTTP endpoints.
* Ran automated Integration Tests verifying the entire pipeline (Register ➔ Login ➔ Gateway Routing ➔ Note Creation) across all running daemons.
</details>
