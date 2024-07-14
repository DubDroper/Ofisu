# ✨🖥️ **Ofisu** 🖥️✨
Ofisu | Your humble everyday assistant! 🖥️✨

Welcome to **Ofisu**! This application is designed to streamline your daily tasks, manage resources, and provide various utilities, all in one place.

![image](https://github.com/user-attachments/assets/be65617d-3d1d-4857-9113-d309128c37c5)

## ✨ **Features** ✨

### ✅ **Completed Features**
1. **Real-time Resource Monitoring**
   - CPU usage %, RAM usage %, Disk Volumes and usage %.

2. **ToDo List Management**
   - Create, update, and delete tasks with database integration.

3. **Configuration File Management**
   - Load MySQL DB parameters from a configuration file.

4. **MySQL DB Connection Check**
   - Check MySQL DB connection on Main load.

5. **Remote MySQL DB**
   - Store data in a remote MySQL database.

6. **Configuration Storage**
   - Config menu stored in a `.ini` file.

### 🚧 **Upcoming Features**
1. **Customizable Theme**
2. **Shortcuts**
3. **Memo**
4. **Reminders and Alarms**
5. **Website Status Checker**
6. **Command Console (Super User)**
7. **Update Capability**
8. **Folder Scanner**
9. **Dynamic Detection of Installed Steam Games**
10. **YouTube Music Player**
11. **Double Buffering**
12. **Detection of All Open Ports**
13. **Emergency 'AirPlane' Mode** Deactivate all network cards.

## 📦 **Installation**

To install and run **Ofisu**, follow these steps:

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/Ofisu.git
Navigate to the project directory:
bash
Copy code
cd Ofisu
Open the project in Visual Studio 2022.

🔧 Usage
Configure your MySQL database parameters in the Ofisu_Config.ini file.
Build and run the application using Visual Studio 2022.
Explore the features and customize your experience!

📂 Database Schema
Task Table
```sql
      Copy code
      CREATE TABLE Task (
          ID INT AUTO_INCREMENT PRIMARY KEY,
          TaskName VARCHAR(255),
          AddedDateTime DATETIME,
          isCompleted BOOLEAN,
          CompletedTime DATETIME
      );
      
      -- Populate with sample data
      INSERT INTO Task (TaskName, AddedDateTime, isCompleted, CompletedTime) VALUES
      ('Task 1', NOW(), FALSE, NULL),
      ('Task 2', NOW(), FALSE, NULL),
      ('Task 3', NOW(), FALSE, NULL),
      -- Add more tasks as needed
      Updates Table
      sql
      Copy code
      CREATE TABLE Updates (
          ID INT AUTO_INCREMENT PRIMARY KEY,
          Version VARCHAR(255),
          DateCreated DATETIME,
          UpdateLink VARCHAR(255)
      );
      
      -- Populate with sample data
      INSERT INTO Updates (Version, DateCreated, UpdateLink) VALUES
      ('1.0.0', NOW(), 'http://yourupdate.link/update1'),
      ('1.1.0', NOW(), 'http://yourupdate.link/update2');
```
📜 **License**
This project is not under a license.

📬 **Contact**
For any questions or suggestions, feel free to open an issue or contact me at idroperex@gmail.com.

**Ofisu - Simplify your digital workspace! 🖥️✨**
