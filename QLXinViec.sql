create database QLXinViec;

use QLXinViec;

create table user_role (
	id int primary key identity(1, 1),
	role_name varchar(255)
);

create table account (
	id int primary key identity(1, 1),
	email varchar(255) not null unique,
	password varchar(255) not null,
	role_id int,

	foreign key (role_id) references user_role(id)
);

create table user_profile (
	id int primary key identity(1, 1),
	user_account_id int,
	name varchar(255) not null,
	tittle varchar(255),
	email varchar(255) not null unique,
	phone_number varchar(20),
	date_of_birth date,
	gender varchar(20) default 'Male',
	[address] text,
	personal_link text,
	user_image text,
	about_me text,

	foreign key (user_account_id) references account(id)
);

create table user_education (
	id int primary key identity(1, 1),
	school_name varchar(255),
	major varchar(255),
	[from] date,
	[to] date,
	additional_details text,
	user_profile_id int,

	foreign key (user_profile_id) references user_profile(id),
);

create table user_work_experience (
	id int primary key identity(1, 1),
	job_title varchar(255),
	company_name varchar(255),
	[from] date,
	[to] date,
	user_profile_id int,

	foreign key (user_profile_id) references user_profile(id)
);

create table user_personal_project (
	id int primary key identity(1, 1),
	project_name varchar(255),
	[from] date,
	[to] date,
	description text,
	user_profile_id int,

	foreign key (user_profile_id) references user_profile(id)
);

create table company_profile (
	id int primary key identity(1, 1),
	company_account_id int,
	name varchar(255) not null,
	email varchar(255) not null unique,
	phone_number varchar(20),
	[address] text,
	company_image text,
	date_establish date,
	company_size int,
	company_link text,
	reason text,
	overview text,

	foreign key (company_account_id) references account(id)
);

--COMPANY + JOBs
create table position (
	id int primary key identity(1, 1),
	name varchar(255) not null unique,
);

create table skill (
	id int primary key identity(1, 1),
	name varchar(255) not null
);

create table [location] (
	id int primary key identity(1, 1),
	name varchar(255)
);

create table year_experience (
	id int primary key identity(1, 1),
	name varchar(255)
);

create table job_post (
	id int primary key identity(1, 1),
	title varchar(255) not null,
	recruitment_number int default 1,
	salary int not null,
	[description] text,
	requirement text,
	prioritize text,
	benefit text,
	post_date date,
	expire_date date,
	[address] text,
	year_experience_id int,
	location_id int,
	company_id int not null,
	
	foreign key (location_id) references [location](id),
	foreign key (company_id) references company_profile(id),
	foreign key (year_experience_id) references year_experience(id)
);

create table job_skill (
	job_post_id int not null,
	skill_id int not null,

	foreign key (job_post_id) references job_post(id),
	foreign key (skill_id) references skill(id)
);

create table user_apply_job (
	user_id int,
	job_post_id int,
	[status] varchar(50) default 'PENDING',
	cover_letter text,

	foreign key (user_id) references user_profile(id),
	foreign key (job_post_id) references job_post(id)
);

create table user_skill (
	user_profile_id int,
	skill_id int,

	foreign key (user_profile_id) references user_profile(id),
	foreign key (skill_id) references skill(id)
);

-- INSERT statements for user_role table
INSERT INTO user_role (role_name) VALUES
('company'),
('user');

-- INSERT statements for location table
INSERT INTO location(name) VALUES
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
('Mien Bac'),
('Mien Nam'),
('Mien Trung'),
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
('Toan Quoc'),
('Tra Vinh'),
('Tuyen Quang'),
('Vinh Long'),
('Vinh Phuc'),
('Yen Bai'),
('Nuoc Ngoai');

--INSERT statements for skill table
INSERT INTO skill(name) VALUES
('Agile'),
('Android'),
('Angular'),
('AngularJS'),
('ASP.NET'),
('Assembly'),
('Automation Test'),
('AWS'),
('Azure'),
('Blockchain'),
('Bridge Engineer'),
('Business Analyst'),
('C#'),
('C++'),
('C language'),
('Cloud'),
('COBOL'),
('Cocos'),
('CSS'),
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
('Java'),
('JavaScript'),
('JQuery'),
('Kotlin'),
('Laravel'),
('Linux'),
('Magento'),
('Manager'),
('MVC'),
('MySQL'),
('.NET'),
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
('ReactJS'),
('React Native'),
('Ruby'),
('Ruby on Rails'),
('Salesforce'),
('SAP'),
('Scala'),
('Scrum'),
('Sharepoint'),
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
('Wordpress');

-- INSERT statements for year_experience table
INSERT INTO year_experience(name) VALUES
('All experience'),
('0-1 years'),
('1-3 years'),
('3-5 years'),
('5+ years');

-- Inserting 30 rows into the account table
DECLARE @counter INT = 1;

WHILE @counter <= 30
BEGIN
    DECLARE @email VARCHAR(255) = CONCAT('email', @counter, '@example.com');
    DECLARE @password VARCHAR(255) = CONCAT('password', @counter);
    DECLARE @role_id INT = CASE WHEN @counter <= 15 THEN 1 ELSE 2 END; -- Assuming role_id 1 is for company and 2 is for user

    INSERT INTO account (email, password, role_id) 
    VALUES (@email, @password, @role_id);

    SET @counter = @counter + 1;
END;


-- Inserting 30 rows into the user_profile table
DECLARE @user_counter INT = 16;

WHILE @user_counter <= 30
BEGIN
    DECLARE @user_email VARCHAR(255) = CONCAT('user_email', @user_counter, '@example.com');
    DECLARE @user_name VARCHAR(255) = CONCAT('User', @user_counter);

    INSERT INTO user_profile (user_account_id, name, email) 
    VALUES (@user_counter, @user_name, @user_email);

    SET @user_counter = @user_counter + 1;
END;


-- Inserting 30 rows into the company_profile table
DECLARE @company_counter INT = 1;

WHILE @company_counter <= 15
BEGIN
    DECLARE @company_email VARCHAR(255) = CONCAT('company_email', @company_counter, '@example.com');
    DECLARE @company_name VARCHAR(255) = CONCAT('Company', @company_counter);

    INSERT INTO company_profile (company_account_id, name, email, phone_number) 
    VALUES (@company_counter, @company_name, @company_email, '1234567890');

    SET @company_counter = @company_counter + 1;
END;

-- Insert statements for job_post table
INSERT INTO job_post (title, recruitment_number, salary, [description], requirement, prioritize, benefit, post_date, expire_date, [address], year_experience_id, location_id, company_id)
VALUES 
('Software Engineer', 3, 80000, 'Seeking experienced software engineers proficient in Java and Python.', 'Bachelor''s degree in Computer Science or related field.', 'Experience with Agile methodologies preferred.', 'Competitive salary and benefits package.', '2024-03-20', '2024-04-20', '123 Main St, City, Country', 1, 1, 1),
('Data Analyst', 2, 60000, 'Looking for data analysts with experience in SQL and data visualization tools.', 'Bachelor''s degree in Statistics or related field.', 'Strong analytical skills and attention to detail.', 'Flexible work schedule and remote work options.', '2024-03-20', '2024-04-20', '456 Oak Ave, City, Country', 2, 2, 2),
('Marketing Manager', 1, 70000, 'Hiring a marketing manager to lead our marketing campaigns and initiatives.', 'Bachelor''s degree in Marketing or related field.', 'Experience with digital marketing and social media platforms.', 'Opportunity for career growth and advancement.', '2024-03-20', '2024-04-20', '789 Elm St, City, Country', 3, 3, 3),
('Accountant', 2, 55000, 'Seeking skilled accountants with experience in financial analysis and reporting.', 'Bachelor''s degree in Accounting or Finance.', 'CPA certification preferred.', 'Health insurance and retirement benefits.', '2024-03-20', '2024-04-20', '101 Pine St, City, Country', 4, 4, 4),
('Project Manager', 1, 75000, 'Looking for experienced project managers to oversee project timelines and budgets.', 'Bachelor''s degree in Business Administration or related field.', 'PMP certification preferred.', 'Opportunity to work with cross-functional teams.', '2024-03-20', '2024-04-20', '202 Oak St, City, Country', 5, 5, 5),
('HR Coordinator', 1, 60000, 'Hiring an HR coordinator to manage employee relations and recruitment activities.', 'Bachelor''s degree in Human Resources or related field.', 'Experience with HRIS systems and talent acquisition.', 'Generous vacation and leave policies.', '2024-03-20', '2024-04-20', '303 Maple St, City, Country', 1, 6, 6),
('Graphic Designer', 2, 65000, 'Seeking creative graphic designers with experience in Adobe Creative Suite.', 'Bachelor''s degree in Graphic Design or related field.', 'Portfolio showcasing design projects.', 'Flexible work environment and creative projects.', '2024-03-20', '2024-04-20', '404 Elm St, City, Country', 2, 7, 7),
('Sales Representative', 3, 60000, 'Looking for energetic sales representatives to drive revenue growth.', 'Bachelor''s degree in Business or related field.', 'Proven track record of meeting sales targets.', 'Commission-based compensation and sales incentives.', '2024-03-20', '2024-04-20', '505 Cedar St, City, Country', 3, 8, 8),
('Customer Service Specialist', 2, 50000, 'Hiring customer service specialists to assist customers with inquiries and issues.', 'High school diploma or equivalent.', 'Strong communication and problem-solving skills.', 'Training and career development opportunities.', '2024-03-20', '2024-04-20', '606 Birch St, City, Country', 4, 9, 9),
('Legal Counsel', 1, 85000, 'Seeking experienced legal counsel to provide legal advice and support.', 'Juris Doctor (JD) degree and active bar membership.', 'Experience in corporate law and contract negotiation.', 'Competitive compensation and comprehensive benefits.', '2024-03-20', '2024-04-20', '707 Oak St, City, Country', 5, 10, 10);