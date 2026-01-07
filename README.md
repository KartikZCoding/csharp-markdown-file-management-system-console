# 📘 Markdown File Management System

*C# Console Application*

------------------------------------------------------------------------

## 📌 Project Overview

The **Markdown File Management System** is a **console-based C#
application** designed to manage and display learning topics in a
**menu-driven format**.

This project was developed as part of an **internship task**, with the
goal of organizing C# concepts in a structured way, similar to how
Markdown documents are logically organized --- but rendered through a
console application.

------------------------------------------------------------------------

## 🎯 Core Concept of This System (IMPORTANT)

The **main idea** behind this system is:

> **Separate content from navigation and presentation.**

Instead of writing all logic in one file: - Menus handle
**navigation** - Topics handle **content** - Helpers handle
**formatting**

This is a **real-world design principle** used in professional software
development.

------------------------------------------------------------------------

## 🧠 Key Concepts Demonstrated

### 1️⃣ Menu-Driven Architecture

-   The application uses a **central main menu**
-   Each topic has its own dedicated menu
-   User navigates step-by-step through options

👉 This improves **usability and clarity**.

------------------------------------------------------------------------

### 2️⃣ Separation of Concerns (Very Important)

The project is divided into logical layers:

  Layer     Responsibility
  --------- -------------------------------
  Program   Application entry point
  Menus     User interaction & navigation
  Topics    Learning content
  Helpers   Reusable formatting logic

👉 This makes the code **clean, readable, and maintainable**.

------------------------------------------------------------------------

### 3️⃣ Content Management via Code

-   Each topic is represented by a **class**
-   Each concept is represented by a **method**
-   Topics can be extended without touching menu logic

👉 This mimics how **documentation systems** are structured.

------------------------------------------------------------------------

### 4️⃣ Reusability

-   `TopicHelper` is reused across all topics
-   Avoids repeated formatting code
-   Ensures consistent output

👉 This follows the **DRY principle (Don't Repeat Yourself)**.

------------------------------------------------------------------------

## 📋 Main Menu Options

    1. Basics
    2. Conditions & Loops
    3. Strings
    4. Arrays & Collections
    5. Functions
    6. Exception Handling
    7. Object-Oriented Programming
    0. Exit

Each option leads to a **topic-specific menu**.

------------------------------------------------------------------------

## 🧱 Project Structure

    Markdown file management System
    │
    ├── Program.cs
    │
    ├── Helpers
    │   └── TopicHelper.cs
    │
    ├── Menus
    │   ├── MainMenu.cs
    │   ├── BasicsMenu.cs
    │   ├── ConditionsLoopsMenu.cs
    │   ├── StringsMenu.cs
    │   ├── ArraysCollectionsMenu.cs
    │   ├── FunctionsMenu.cs
    │   ├── ExceptionHandlingMenu.cs
    │   └── OOPMenu.cs
    │
    ├── Topics
    │   ├── Basics.cs
    │   ├── ConditionsLoops.cs
    │   ├── Strings.cs
    │   ├── ArraysCollections.cs
    │   ├── Functions.cs
    │   ├── ExceptionHandling.cs
    │   └── OOP.cs

------------------------------------------------------------------------

## 🔄 System Flow (Step-by-Step)

1.  Application starts from `Program.cs`
2.  `MainMenu.Display()` is executed
3.  User selects a topic
4.  Corresponding menu class is called
5.  Menu calls topic methods
6.  Content is printed in console
7.  User navigates back or exits

### 🔁 Logical Flow

    Program.cs
       ↓
    MainMenu
       ↓
    Topic Menu
       ↓
    Topic Class
       ↓
    Console Output

------------------------------------------------------------------------

## 🧠 Technologies & Concepts Used

-   C# Console Application\
-   Static Classes & Methods\
-   Menu-driven programming\
-   Separation of Concerns\
-   Code Reusability\
-   Clean Project Architecture

------------------------------------------------------------------------

## 📚 Learning Outcome

This project helped me:

-   Design a **structured console application**
-   Understand **real-world code organization**
-   Apply separation of concerns practically
-   Build a system similar to documentation navigation
-   Complete an **internship task professionally**

------------------------------------------------------------------------

⭐ Part of my **C# to .NET Developer Journey**
