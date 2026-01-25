**
Lap bài tập tự làm Java:**
Tạo mới cơ sở dữ liệu :
CREATE TABLE ORGANIZATION (
    OrgID INT AUTO_INCREMENT PRIMARY KEY,
    OrgName VARCHAR(255) NOT NULL,
    Address VARCHAR(255),
    Phone VARCHAR(20),
    Email VARCHAR(100),
    CreatedDate DATETIME NOT NULL,
    UNIQUE KEY uk_orgname (OrgName)
);`organization`

Thay đổi file DBConnection cho phù hợp :
  return DriverManager.getConnection(
            "jdbc:mysql://localhost:3306/org_management",----> tên database
            "spring",----->username
            "spring"---->password
        );
