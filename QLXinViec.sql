CREATE DATABASE QLXinViec;
GO

USE QLXinViec;
GO

CREATE TABLE skill (
	id INT PRIMARY KEY IDENTITY(1, 1),
	[name] VARCHAR(255) NOT NULL
);
GO

CREATE TABLE [location] (
	id INT PRIMARY KEY IDENTITY(1, 1),
	[name] VARCHAR(255)
);
GO

CREATE TABLE year_experience (
	id INT PRIMARY KEY IDENTITY(1, 1),
	[name] VARCHAR(255)
);
GO

--ACCOUNT
CREATE TABLE account (
	id INT PRIMARY KEY IDENTITY(1, 1),
	email VARCHAR(255) NOT NULL UNIQUE,
	password VARCHAR(255) NOT NULL,
	[name] VARCHAR(255) NOT NULL,
	[role] VARCHAR(20),
	avatar IMAGE,
);
GO

--USER
CREATE TABLE user_profile (
	account_id INT,
	[name] VARCHAR(255) NOT NULL,
	title VARCHAR(255),
	email VARCHAR(255) NOT NULL UNIQUE,
	phone_number VARCHAR(20),
	date_of_birth DATE,
	gender VARCHAR(20) DEFAULT 'Male',
	[address] TEXT,
	personal_link TEXT,
	about_me TEXT,

	FOREIGN KEY (account_id) REFERENCES account(id)
);
GO

CREATE TABLE user_education (
	id INT PRIMARY KEY IDENTITY(1, 1),
	school_name VARCHAR(255),
	major VARCHAR(255),
	[from] DATE,
	[to] DATE,
	additional_details TEXT,
	account_id INT,

	FOREIGN KEY (account_id) REFERENCES account(id),
);
GO

CREATE TABLE user_work_experience (
	id INT PRIMARY KEY IDENTITY(1, 1),
	job_title VARCHAR(255),
	company_name VARCHAR(255),
	[from] DATE,
	[to] DATE,
	account_id INT,

	FOREIGN KEY (account_id) REFERENCES account(id)
);
GO

CREATE TABLE user_personal_project(
	id INT PRIMARY KEY IDENTITY(1, 1),
	project_name VARCHAR(255),
	[from] DATE,
	[to] DATE,
	description TEXT,
	account_id INT,

	FOREIGN KEY (account_id) REFERENCES account(id)
);
GO

--COMPANY + JOB
CREATE TABLE company_profile (
	account_id INT,
	[name] VARCHAR(255) NOT NULL,
	email VARCHAR(255) NOT NULL UNIQUE,
	phone_number VARCHAR(20),
	[address] TEXT,
	date_establish DATE,
	company_size INT,
	company_link TEXT,
	reason TEXT,
	overview TEXT,
	tax_code VARCHAR(20),
	business_license TEXT,

	FOREIGN KEY (account_id) REFERENCES account(id)
);
GO

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
	company_account_id INT NOT NULL,
	
	FOREIGN KEY (location_id) REFERENCES [location](id),
	FOREIGN KEY (company_account_id) REFERENCES account(id),
	FOREIGN KEY (year_experience_id) REFERENCES year_experience(id)
);
GO

CREATE TABLE job_skill (
	job_post_id INT,
	skill_id INT,

	FOREIGN KEY (job_post_id) REFERENCES job_post(id),
	FOREIGN KEY (skill_id) REFERENCES skill(id),
	PRIMARY KEY (job_post_id, skill_id)
);
GO

CREATE TABLE user_apply_job (
	account_id INT,
	job_post_id INT,
	[status] VARCHAR(50),
	cover_letter TEXT,
	applied_at DATE,
	cv_attach TEXT,

	FOREIGN KEY (account_id) REFERENCES account(id),
	FOREIGN KEY (job_post_id) REFERENCES job_post(id),
	PRIMARY KEY (account_id, job_post_id)
);
GO

CREATE TABLE user_skill (
	account_id INT,
	skill_id INT,

	FOREIGN KEY (account_id) REFERENCES account(id),
	FOREIGN KEY (skill_id) REFERENCES skill(id),
	PRIMARY KEY (account_id, skill_id)
);
GO

CREATE TABLE user_favourite_job(
	[user_id] INT,
	job_post_id INT,

	FOREIGN KEY ([user_id]) REFERENCES account(id),
	FOREIGN KEY (job_post_id) REFERENCES job_post(id),
	PRIMARY KEY ([user_id], job_post_id)
);
GO

CREATE TABLE [following](
	account_following INT,
	account_followed INT,

	FOREIGN KEY (account_following) REFERENCES account(id),
	FOREIGN KEY (account_followed) REFERENCES account(id),
	PRIMARY KEY(account_following, account_followed)
);
GO

--Social
CREATE TABLE social_post(
	id INT PRIMARY KEY IDENTITY(1, 1),
	title TEXT,
	contents TEXT,
	post_date DATE,
	account_id INT,

	FOREIGN KEY (account_id) REFERENCES account(id)
);
GO

CREATE TABLE social_post_skill(
	social_post_id INT,
	skill_id INT,

	FOREIGN KEY (social_post_id) REFERENCES social_post(id),
	FOREIGN KEY (skill_id) REFERENCES skill(id),
	PRIMARY KEY (social_post_id, skill_id)
);
GO

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

CREATE TABLE company_image(
	id INT PRIMARY KEY IDENTITY(1, 1),
	company_account_id INT,
	company_image IMAGE,

	FOREIGN KEY (company_account_id) REFERENCES account(id)
);
GO

--PROCEDURE
CREATE PROCEDURE usp_RegisterCompanyAccount
    @Email VARCHAR(255),
    @Password VARCHAR(255),
    @Name VARCHAR(255),
	@Avatar IMAGE,
    @BusinessLicense TEXT
AS
BEGIN
    DECLARE @InsertedAccountId TABLE (id INT);

    INSERT INTO account (email, [password], [name], [role], avatar)
		OUTPUT INSERTED.id INTO @InsertedAccountId
    VALUES (@Email, @Password, @Name, 'company', @Avatar);

    DECLARE @CompanyAccountId INT;
    SELECT @CompanyAccountId = id FROM @InsertedAccountId;

    INSERT INTO company_profile (account_id, business_license)
    VALUES (@CompanyAccountId, @BusinessLicense);
END;
GO

CREATE PROCEDURE usp_RegisterUserAccount
    @Email VARCHAR(255),
    @Password VARCHAR(255),
    @Name VARCHAR(255),
	  @Avatar IMAGE
AS
BEGIN
    INSERT INTO account (email, [password], [name], [role], avatar)
    VALUES (@Email, @Password, @Name, 'user', @Avatar);
END;
GO
