# 🎓 CareerConnect – Job Fair Management System

**CareerConnect** is a comprehensive, database-driven desktop application designed to streamline the management of job fairs at FAST-NUCES Islamabad. Built using **C# Windows Forms** and **SQL Server**, the system provides tailored interfaces and workflows for students, recruiters, TPO (Training & Placement Office), and booth coordinators to manage the full lifecycle of job fair events.

> **Collaborators**:  
> 🧑‍💻 Uzair Majeed (23I-3063)  
> 🧑‍💻 Syed Muhammad Ijtaba Rizvi (23I-0112)

---

## 🔁 Project Iterations

### 🔹 Iteration 1: Database Design
- **Tools Used**: SQL Server Management Studio
- **Deliverables**:
  - Entity Relationship Diagram (ERD)
  - Normalized relational schema (up to 3NF)
  - Data insertion scripts
- **Key Tables**:
  - `USERS`, `STUDENT`, `RECRUITER`, `TPO`, `COORDINATOR`
  - `JOB_FAIR_EVENTS`, `BOOTH`, `COMPANY`, `INTERVIEWS`, `APPLICATION`
  - Associative tables for skills, reviews, job postings, and more
- **Sample Data Requirements**:
  - 80+ students, 20+ companies, 5+ job fairs
  - 200+ applications and interviews

### 🔹 Iteration 2: Interface Design
- **Platform**: Windows Forms in Visual Studio 2019+
- **Key User Interfaces**:
  - Student login, profile creation, job fair browsing, interview scheduling
  - Recruiter account, job posting, shortlisting, interview finalization
  - TPO dashboard for admin approval, job fair scheduling, reporting
  - Booth coordinator check-ins and booth traffic logging
- **Navigation Flow**:
  - Modular access based on role after login
  - Form-to-form transitions with context preservation (e.g., studentID passed through)

### 🔹 Iteration 3: Final Integration & Functionality
- **Backend**: SQL Server with stored procedures for all core operations
- **Frontend**: Fully implemented Windows Forms application
- **System Features**:
  - Authentication (Students via FAST email, Recruiters pending approval)
  - Profile management with GPA, semester, certifications, and skills
  - Advanced job search with filters (salary, type, skills, location)
  - Interview scheduling with time slots and post-interview reviews
  - Event management with booth assignments, check-ins, and monitoring
  - Admin tools for analytics reports and user management
- **Reports Generated**:
  - Student participation, recruiter hiring trends, placement stats
  - Booth traffic and peak job fair timings

---

## 🧩 Key Functional Modules

### 👨‍🎓 Student Interface
- Register and log in via FAST email
- Build complete academic and skill profiles
- Search and apply for jobs with advanced filters
- Schedule interviews, view calendar, submit ratings

### 🏢 Recruiter Interface
- Submit company/job postings (subject to TPO approval)
- View and filter student applications
- Allocate interview slots and mark hiring outcomes

### 🧑‍💼 TPO (Admin) Interface
- Approve/reject users (students and recruiters)
- Create and schedule job fair events
- Assign booths and coordinators
- Generate reports and oversee system operations

### 🧑‍🔧 Booth Coordinator Interface
- Manage student check-ins at booths
- Track visitor flow and monitor booth activity

---

## 🛠️ Tech Stack

- **Frontend**: Windows Forms (C#)
- **Backend**: SQL Server
- **Development Tool**: Visual Studio 2019
- **Data Access**: ADO.NET / Stored Procedures
- **Database Design**: Normalized to 3NF

---

## 📊 Sample Reports & Analytics

- **Student Participation**: GPA distribution, department-wise registration
- **Recruiter Activity**: Interview counts, offer-to-acceptance ratios
- **Placement Summary**: Hiring percentages, average salaries
- **Event Performance**: Booth traffic, peak hours, resource utilization

---

## 📌 Notes

- All user roles are implemented with clear separation of access and responsibility.
- Data validation is enforced both at UI and database levels.
- A walkthrough video demo accompanies this submission, showcasing:
  - Login and navigation
  - CRUD operations for each role
  - Report generation and sample analytics

---

## 🔐 Plagiarism Policy

This project strictly adheres to academic honesty policies. All submitted work is original and built from scratch by the collaborators. No code or schema has been copied from external sources.

---

## 📄 Documentation Includes

- 📈 ER Diagram & Relational Schema  
- 🧠 Design Decisions Explained  
- 📸 User Manual with Screenshots  
- 🎥 Video Demo of System Functionality

---

> Made with 💼 and 💻 by Uzair Majeed & Ijtiba Rizvi – FAST-NUCES SE-B (DB Lab Final Project, Spring 2025)
