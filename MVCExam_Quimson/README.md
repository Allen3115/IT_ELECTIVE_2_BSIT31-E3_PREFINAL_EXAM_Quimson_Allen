Quimson, Allen Dwayn T. - BSIT31E3
# Prefinal Exam – IT Elective 2
## Exam Answers
| # | Question (Summary) | Answer | Explanation |
|---|--------------------|--------|-------------|
| 1 | Problem solved by database vs in-memory | C | In-memory collections disappear when the app stops; a database keeps the data around after that. |
| 2 | Approach using existing DB to generate EF Core classes | B | Database-First reverse-engineers an existing schema into C# entity classes. |
| 3 | Primary purpose of EF Core | C | EF Core is an ORM: it maps C# objects to rows in a relational database. |
| 4 | EF Core component communicating with DB | A | DbContext manages the connection and change-tracking between entities and the database. |
| 5 | Command `dotnet ef dbcontext scaffold` | C | Reverse-engineers an existing database into EF Core model classes. |
| 6 | Where connection string is stored | B | Connection strings live in configuration (appsettings.json). |
| 7 | Student–Section relationship type | B | One Section has many Students, each Student has one Section → One-to-Many. |
| 8 | Meaning of SectionId property | B | SectionId is a foreign key referencing Section. |
| 9 | Purpose of navigation property | B | Represents a relationship to another entity. |
| 10 | Purpose of `.Include()` | B | Eagerly loads related navigation property in the same query. |
| 11 | Why use a ViewModel | B | Combines/shapes data specifically needed by the view. |
| 12 | Benefit of `Include(s => s.Section)` | A | Loads the related Section navigation property. |
| 13 | Validation in browser before request | B | Client-side validation runs in the browser. |
| 14 | Why server-side validation is needed | A | Client-side validation can be bypassed. |
| 15 | Rule for Student Number | B | Student Number should be unique. |
| 16 | Reason for DB-level unique constraint | A | Protects data integrity even if app validation is bypassed. |
| 17 | Purpose of try...catch in controller | B | To catch and handle exceptions gracefully. |
| 18 | Middleware for exception handling | B | UseExceptionHandler() routes unhandled exceptions to error pipeline. |
| 19 | Response if Student 999 not found | B | Display a Not Found (404) response/page. |
| 20 | Concern with duplicate Section assignment | A | Risks inconsistent/duplicate records → data integrity issue. |