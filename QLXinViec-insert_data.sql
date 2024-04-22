USE QLXinViec;
GO

-- INSERT statements for location TABLE
INSERT INTO [location]([name])
VALUES
('All location'),
('Ha Noi'),
('Ho Chi Minh'),
('Binh Duong'),
('Bac Ninh'),
('Dong Nai'),
('Hung Yen'),
('Hai Duong'),
('Da Nang'),
('Hai Phong'),
('An Giang'),
('Ba Ria-Vung Tau'),
('Bac Giang'),
('Bac Kan'),
('Bac Lieu'),
('Ben Tre'),
('Binh Dinh'),
('Binh Phuoc'),
('Binh Thuan'),
('Ca Mau'),
('Can Tho'),
('Cao Bang'),
('Cuu Long'),
('Dak Lak'),
('Dac Nong'),
('Dien Bien'),
('Dong Thap'),
('Gia Lai'),
('Ha Giang'),
('Ha Nam'),
('Ha Tinh'),
('Hau Giang'),
('Hoa Binh'),
('Khanh Hoa'),
('Kien Giang'),
('Kon Tum'),
('Lai Chau'),
('Lam Dong'),
('Lang Son'),
('Lao Cai'),
('Long An'),
('Nam Dinh'),
('Nghe An'),
('Ninh Binh'),
('Ninh Thuan'),
('Phu Tho'),
('Phu Yen'),
('Quang Binh'),
('Quang Nam'),
('Quang Ngai'),
('Quang Ninh'),
('Quang Tri'),
('Soc Trang'),
('Son La'),
('Tay Ninh'),
('Thai Binh'),
('Thai Nguyen'),
('Thanh Hoa'),
('Thua Thien Hue'),
('Tien Giang'),
('Tra Vinh'),
('Tuyen Quang'),
('Vinh Long'),
('Vinh Phuc'),
('Yen Bai');
GO

--INSERT statements for skill TABLE
INSERT INTO skill([name])
VALUES
('Agile'),
('Android'),
('AngularJS'),
('Angular'),
('ASP.NET'),
('Assembly'),
('Automation Test'),
('AWS'),
('Azure'),
('Blockchain'),
('Bridge Engineer'),
('Business Analyst'),
('C language'),
('Cloud'),
('COBOL'),
('Cocos'),
('CSS'),
('C#'),
('C++'),
('Dart'),
('Data Analyst'),
('Database'),
('Designer'),
('DevOps'),
('Django'),
('Drupal'),
('Embedded'),
('English'),
('ERP'),
('Flutter'),
('Games'),
('Golang'),
('Groovy'),
('HTML5'),
('iOS'),
('IT Support'),
('J2EE'),
('Japanese'),
('JavaScript'),
('Java'),
('JQuery'),
('Kotlin'),
('Laravel'),
('Linux'),
('Magento'),
('Manager'),
('MVC'),
('MySQL'),
('Networking'),
('NodeJS'),
('NoSQL'),
('Objective C'),
('OOP'),
('OpenStack'),
('Oracle'),
('PHP'),
('PostgreSql'),
('Product Manager'),
('Project Manager'),
('Python'),
('QA QC'),
('React Native'),
('ReactJS'),
('Ruby on Rails'),
('Ruby'),
('Salesforce'),
('SAP'),
('Scala'),
('Scrum'),
('SharepoINT'),
('Software Architect'),
('Solidity'),
('Spring'),
('SQL'),
('Swift'),
('System Admin'),
('System Engineer'),
('Team Leader'),
('Tester'),
('TypeScript'),
('UI-UX'),
('Unity'),
('VueJS'),
('Wordpress'),
('.NET');
GO

-- INSERT statements for year_experience TABLE
INSERT INTO year_experience([name])
VALUES
('All experience'),
('0-1 years'),
('1-3 years'),
('3-5 years'),
('5+ years');
GO

-- Inserting 10 rows INTO the account TABLE
DECLARE @counter INT = 1;
WHILE @counter <= 10
BEGIN
    DECLARE @email VARCHAR(255) = CONCAT('email', @counter, '@example.com');
    DECLARE @password VARCHAR(255) = CONCAT('password', @counter);
    DECLARE @role VARCHAR(20) = CASE WHEN @counter <= 5 THEN 'company' ELSE 'user' END;
	DECLARE @name VARCHAR(255) = CONCAT('Account ', @counter);

    INSERT INTO account (email, password, [role], [name]) 
    VALUES (@email, @password, @role, @name);

    SET @counter = @counter + 1;
END;
GO

-- Inserting 5 rows INTO the user_profile TABLE
DECLARE @user_counter INT = 6;
WHILE @user_counter <= 10
BEGIN
    DECLARE @user_name VARCHAR(255) = CONCAT('User ', @user_counter);
	DECLARE @email VARCHAR(255) = CONCAT('email', @user_counter, '@example.com')

    INSERT INTO user_profile (account_id, [name], email) 
    VALUES (@user_counter, @user_name, @email);

    SET @user_counter = @user_counter + 1;
END;
GO

-- Inserting 5 rows INTO the company_profile TABLE
DECLARE @company_counter INT = 1;
WHILE @company_counter <= 5
BEGIN
    DECLARE @company_name VARCHAR(255) = CONCAT('Company ', @company_counter);
	DECLARE @email VARCHAR(255) = CONCAT('email', @company_counter, '@example.com')

    INSERT INTO company_profile (account_id, [name], email)
    VALUES (@company_counter, @company_name, @email);

    SET @company_counter = @company_counter + 1;
END;
GO

-- Insert statements for job_post TABLE
INSERT INTO job_post (title, recruitment_number, salary, [description], requirement, prioritize, benefit, post_date, expire_date, [address], year_experience_id, location_id, company_account_id)
VALUES 
('Software Engineer', 3, 80000, 'Seeking experienced software engineers proficient in Java and Python.', 'Bachelor''s degree in Computer Science or related field.', 'Experience with Agile methodologies preferred.', 'Competitive salary and benefits package.', '2024-03-20', '2024-04-20', '123 Main St, City, Country', 1, 1, 1),
('Data Analyst', 2, 60000, 'Looking for data analysts with experience in SQL and data visualization tools.', 'Bachelor''s degree in Statistics or related field.', 'Strong analytical skills and attention to detail.', 'Flexible work schedule and remote work options.', '2024-03-20', '2024-04-20', '456 Oak Ave, City, Country', 2, 2, 2),
('Marketing Manager', 1, 70000, 'Hiring a marketing manager to lead our marketing campaigns and initiatives.', 'Bachelor''s degree in Marketing or related field.', 'Experience with digital marketing and social media platforms.', 'Opportunity for career growth and advancement.', '2024-03-20', '2024-04-20', '789 Elm St, City, Country', 3, 3, 3),
('Accountant', 2, 55000, 'Seeking skilled accountants with experience in financial analysis and reporting.', 'Bachelor''s degree in Accounting or Finance.', 'CPA certification preferred.', 'Health insurance and retirement benefits.', '2024-03-20', '2024-04-20', '101 Pine St, City, Country', 4, 4, 4),
('Project Manager', 1, 75000, 'Looking for experienced project managers to oversee project timelines and budgets.', 'Bachelor''s degree in Business Administration or related field.', 'PMP certification preferred.', 'Opportunity to work with cross-functional teams.', '2024-03-20', '2024-04-20', '202 Oak St, City, Country', 5, 5, 5),
('HR Coordinator', 1, 60000, 'Hiring an HR coordinator to manage employee relations and recruitment activities.', 'Bachelor''s degree in Human Resources or related field.', 'Experience with HRIS systems and talent acquisition.', 'Generous vacation and leave policies.', '2024-03-20', '2024-04-20', '303 Maple St, City, Country', 1, 6, 1),
('Graphic Designer', 2, 65000, 'Seeking creative graphic designers with experience in Adobe Creative Suite.', 'Bachelor''s degree in Graphic Design or related field.', 'Portfolio showcasing design projects.', 'Flexible work environment and creative projects.', '2024-03-20', '2024-04-20', '404 Elm St, City, Country', 2, 7, 2),
('Sales Representative', 3, 60000, 'Looking for energetic sales representatives to drive revenue growth.', 'Bachelor''s degree in Business or related field.', 'Proven track record of meeting sales targets.', 'Commission-based compensation and sales incentives.', '2024-03-20', '2024-04-20', '505 Cedar St, City, Country', 3, 8, 3),
('Customer Service Specialist', 2, 50000, 'Hiring customer service specialists to assist customers with inquiries and issues.', 'High school diploma or equivalent.', 'Strong communication and problem-solving skills.', 'Training and career development opportunities.', '2024-03-20', '2024-04-20', '606 Birch St, City, Country', 4, 9, 4),
('Legal Counsel', 1, 85000, 'Seeking experienced legal counsel to provide legal advice and support.', 'Juris Doctor (JD) degree and active bar membership.', 'Experience in corporate law and contract negotiation.', 'Competitive compensation and comprehensive benefits.', '2024-03-20', '2024-04-20', '707 Oak St, City, Country', 5, 10, 5);
GO

--Insert skills for the job
INSERT INTO job_skill(job_post_id, skill_id)
VALUES
(1, 38),
(1, 6),
(1, 43),
(2, 14),
(2, 69),
(2, 30),
(3, 2),
(3, 76),
(3, 85),
(4, 52),
(4, 10),
(4, 25),
(5, 25),
(5, 2),
(5, 49),
(6, 21),
(6, 14),
(6, 63),
(7, 39),
(7, 10),
(7, 78),
(8, 13),
(8, 68),
(8, 16),
(9, 58),
(9, 19),
(9, 64),
(10, 68),
(10, 43),
(10, 4);
GO

--Insert statements into user_apply_job
INSERT INTO user_apply_job (account_id, job_post_id, [status], applied_at)
VALUES
(6, 1, 'Rejected', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(7, 1, 'Pending', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(8, 1, 'Interview', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(9, 1, 'Approved', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(10, 1, 'Rejected', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(6, 2, 'Pending', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(7, 2, 'Interview', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(8, 2, 'Approved', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(9, 2, 'Rejected', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(10, 2, 'Pending', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(6, 3, 'Interview', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(7, 3, 'Approved', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(8, 3, 'Rejected', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(9, 3, 'Pending', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(10, 3, 'Interview', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(6, 4, 'Approved', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(7, 4, 'Rejected', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(8, 4, 'Pending', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(9, 4, 'Interview', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22')),
(10, 4, 'Approved', DATEADD(day, -1 * ABS(CHECKSUM(NEWID())) % 20, '2024-04-22'));
GO