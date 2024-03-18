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
	email varchar(255) not null unique,
	phone_number varchar(20),
	date_of_birth date,
	gender varchar(20) default 'Male',
	[address] text,
	personal_link text,
	user_image text

	foreign key (user_account_id) references account(id)
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

create table [location] (
	id int primary key identity(1, 1),
	name varchar(255)
);

create table skill (
	id int primary key identity(1, 1),
	name varchar(255) not null
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
