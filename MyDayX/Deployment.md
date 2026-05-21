\# DEPLOYMENT GUIDE – MyDayX



\## 1. System Requirements



| Component        | Requirement                        |

|------------------|------------------------------------|

| Operating System | Windows 10 / Windows 11            |

| .NET Version     | .NET 8.0 (Windows)                 |

| IDE (optional)   | Visual Studio 2022 or later        |

| Database         | SQLite (included – no install needed) |

| RAM              | Minimum 4 GB                       |

| Disk Space       | Minimum 200 MB                     |



\---



\## 2. Prerequisites – Install Before Running



\### Step 1: Install .NET 8 Runtime

Download and install from official Microsoft website:

👉 https://dotnet.microsoft.com/en-us/download/dotnet/8.0



Select: \*\*.NET Desktop Runtime 8.0 (Windows x64)\*\*



\### Step 2: Install Visual Studio 2022 (if running from source)

Download from:

👉 https://visualstudio.microsoft.com/



During installation, select:

\- ✅ .NET Desktop Development workload



\---



\## 3. How to Run the Application



\### Option A – Run from Source Code (Visual Studio)



1\. Clone or download the repository:

&#x20;  ```

&#x20;  git clone https://github.com/arslaayesha123-svg/MYDAYX.git

&#x20;  ```



2\. Open the solution file:

&#x20;  ```

&#x20;  MyDayX.sln

&#x20;  ```



3\. Wait for NuGet packages to restore automatically



4\. Press \*\*F5\*\* or click \*\*Start\*\* to run the application



\---



\### Option B – Run Without Visual Studio



1\. Open Command Prompt in the project folder



2\. Run the following command:

&#x20;  ```

&#x20;  dotnet run

&#x20;  ```



\---



\## 4. Database Setup



\- Database used: \*\*SQLite\*\*

\- Database file: `Database/mydatabase.Designer.db`

\- \*\*No setup required\*\* – the database file is already included in the project

\- The application will automatically connect to it on startup



\---



\## 5. NuGet Packages (Auto-restored)



| Package                    | Version  | Purpose                  |

|----------------------------|----------|--------------------------|

| BCrypt.Net-Next            | 4.1.0    | Password hashing         |

| System.Data.SQLite.Core    | 1.0.119  | SQLite database access   |

| WinForms.DataVisualization | 1.10.0   | Charts and graphs        |



These will be automatically downloaded when you build the project in Visual Studio.



\---



\## 6. Default Login Credentials



| Field    | Value      |

|----------|------------|

| Username | \*(Register a new account on first run)\* |

| Password | \*(Set during registration)\* |



\---



\## 7. Troubleshooting



| Problem | Solution |

|---|---|

| App does not start | Make sure .NET 8 Desktop Runtime is installed |

| NuGet packages missing | Right-click solution → Restore NuGet Packages |

| Database error | Make sure `mydatabase.Designer.db` file exists in Database folder |

| Build errors | Ensure Visual Studio 2022 with .NET Desktop workload is installed |



\---



\## 8. Notes



\- This application runs on \*\*Windows only\*\* (uses WinForms)

\- No internet connection required after NuGet packages are restored

\- SQLite database is portable – no separate database server needed

