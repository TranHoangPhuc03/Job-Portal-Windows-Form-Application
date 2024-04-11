CREATE DATABASE QLXinViec;

USE QLXinViec;

--ACCOUNT
CREATE TABLE user_role (
	id INT PRIMARY KEY IDENTITY(1, 1),
	role_name VARCHAR(255)
);

CREATE TABLE account (
	id INT PRIMARY KEY IDENTITY(1, 1),
	email VARCHAR(255) NOT NULL UNIQUE,
	password VARCHAR(255) NOT NULL,
	role_id INT,

	FOREIGN KEY (role_id) REFERENCES user_role(id)
);

--USER
CREATE TABLE user_profile (
	id INT PRIMARY KEY IDENTITY(1, 1),
	user_account_id INT,
	[name] VARCHAR(255) NOT NULL,
	title VARCHAR(255),
	email VARCHAR(255) NOT NULL UNIQUE,
	phone_number VARCHAR(20),
	date_of_birth DATE,
	gender VARCHAR(20) DEFAULT 'Male',
	[address] TEXT,
	personal_link TEXT,
	user_image TEXT,
	about_me TEXT,

	FOREIGN KEY (user_account_id) REFERENCES account(id)
);

CREATE TABLE user_education (
	id INT PRIMARY KEY IDENTITY(1, 1),
	school_name VARCHAR(255),
	major VARCHAR(255),
	[from] DATE,
	[to] DATE,
	additional_details TEXT,
	user_profile_id INT,

	FOREIGN KEY (user_profile_id) REFERENCES user_profile(id),
);

CREATE TABLE user_work_experience (
	id INT PRIMARY KEY IDENTITY(1, 1),
	job_title VARCHAR(255),
	company_name VARCHAR(255),
	[from] DATE,
	[to] DATE,
	user_profile_id INT,

	FOREIGN KEY (user_profile_id) REFERENCES user_profile(id)
);

CREATE TABLE user_personal_project(
	id INT PRIMARY KEY IDENTITY(1, 1),
	project_name VARCHAR(255),
	[from] DATE,
	[to] DATE,
	description TEXT,
	user_profile_id INT,

	FOREIGN KEY (user_profile_id) REFERENCES user_profile(id)
);

CREATE TABLE user_favourite_job(
	[user_id] INT,
	job_post_id INT,

	FOREIGN KEY ([user_id]) REFERENCES user_profile(id),
	FOREIGN KEY (job_post_id) REFERENCES job_post(id),
	PRIMARY KEY ([user_id], job_post_id)
);

--COMPANY + JOB
CREATE TABLE company_profile (
	id INT PRIMARY KEY IDENTITY(1, 1),
	company_account_id INT,
	[name] VARCHAR(255) NOT NULL,
	email VARCHAR(255) NOT NULL UNIQUE,
	phone_number VARCHAR(20),
	[address] TEXT,
	company_image TEXT,
	date_establish DATE,
	company_size INT,
	company_link TEXT,
	reason TEXT,
	overview TEXT,
	tax_code VARCHAR(20),
	business_license TEXT,

	FOREIGN KEY (company_account_id) REFERENCES account(id)
);

CREATE TABLE skill (
	id INT PRIMARY KEY IDENTITY(1, 1),
	[name] VARCHAR(255) NOT NULL
);

CREATE TABLE [location] (
	id INT PRIMARY KEY IDENTITY(1, 1),
	[name] VARCHAR(255)
);

CREATE TABLE year_experience (
	id INT PRIMARY KEY IDENTITY(1, 1),
	[name] VARCHAR(255)
);

CREATE TABLE job_post (
	id INT PRIMARY KEY IDENTITY(1, 1),
	title VARCHAR(255) NOT NULL,
	recruitment_number INT DEFAULT 1,
	salary INT NOT NULL,
	[description] TEXT,
	requirement TEXT,
	prioritize TEXT,
	benefit TEXT,
	post_date DATE,
	expire_date DATE,
	[address] TEXT,
	year_experience_id INT,
	location_id INT,
	company_id INT NOT NULL,
	
	FOREIGN KEY (location_id) REFERENCES [location](id),
	FOREIGN KEY (company_id) REFERENCES company_profile(id),
	FOREIGN KEY (year_experience_id) REFERENCES year_experience(id)
);

CREATE TABLE job_skill (
	job_post_id INT,
	skill_id INT,

	FOREIGN KEY (job_post_id) REFERENCES job_post(id),
	FOREIGN KEY (skill_id) REFERENCES skill(id),
	PRIMARY KEY (job_post_id, skill_id)
);

CREATE TABLE user_apply_job (
	[user_id] INT,
	job_post_id INT,
	[status] VARCHAR(50),
	cover_letter TEXT,
	applied_at DATE,
	cv_attach TEXT,

	FOREIGN KEY ([user_id]) REFERENCES user_profile(id),
	FOREIGN KEY (job_post_id) REFERENCES job_post(id),
	PRIMARY KEY ([user_id], job_post_id)
);

CREATE TABLE user_skill (
	user_profile_id INT,
	skill_id INT,

	FOREIGN KEY (user_profile_id) REFERENCES user_profile(id),
	FOREIGN KEY (skill_id) REFERENCES skill(id),
	PRIMARY KEY (user_profile_id, skill_id)
);

CREATE TABLE [following](
	company_id INT,
	[user_id] INT,

	FOREIGN KEY ([user_id]) REFERENCES account(id),
	FOREIGN KEY (company_id) REFERENCES account(id),
	PRIMARY KEY([user_id], company_id)
);

--Social
CREATE TABLE social_post(
	id INT PRIMARY KEY IDENTITY(1, 1),
	title TEXT,
	contents TEXT,
	post_date DATE,
	account_id INT,

	FOREIGN KEY (account_id) REFERENCES account(id)
);

CREATE TABLE social_post_skill(
	social_post_id INT,
	skill_id INT,

	FOREIGN KEY (social_post_id) REFERENCES social_post(id),
	FOREIGN KEY (skill_id) REFERENCES skill(id),
	PRIMARY KEY (social_post_id, skill_id)
);

CREATE TABLE mail(
	id INT PRIMARY KEY IDENTITY(1, 1),
	[from] INT,
	[to] INT,
	title TEXT,
	contents TEXT,
	attach_file TEXT,
	send_date DATE,

	FOREIGN KEY ([from]) REFERENCES account(id),
	FOREIGN KEY ([to]) REFERENCES account(id)
);
GO

--PROCEDURE
CREATE PROCEDURE usp_RegisterCompanyAccount
    @Email VARCHAR(255),
    @Password VARCHAR(255),
    @Name VARCHAR(255),
    @BusinessLicense TEXT
AS
BEGIN
    DECLARE @InsertedAccountId TABLE (id INT);

    INSERT INTO account (email, [password], role_id)
	OUTPUT INSERTED.id INTO @InsertedAccountId
    VALUES (@Email, @Password, 1);

    DECLARE @CompanyAccountId INT;
    SELECT @CompanyAccountId = id FROM @InsertedAccountId;

    INSERT INTO company_profile (company_account_id, name, email, business_license)
    VALUES (@CompanyAccountId, @Name, @Email, @BusinessLicense);
END;
GO

CREATE PROCEDURE usp_RegisterUserAccount
    @Email VARCHAR(255),
    @Password VARCHAR(255),
    @Name VARCHAR(255)
AS
BEGIN
    DECLARE @InsertedAccountId TABLE (id INT);

    INSERT INTO account (email, [password], role_id)
	OUTPUT INSERTED.id INTO @InsertedAccountId
    VALUES (@Email, @Password, 2);

    DECLARE @UserAccountId INT;
    SELECT @UserAccountId = id FROM @InsertedAccountId;

    INSERT INTO user_profile (user_account_id, name, email)
    VALUES (@UserAccountId, @Name, @Email);
END;
GO