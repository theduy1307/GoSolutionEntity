CREATE EXTENSION IF NOT EXISTS "pgcrypto";
DO $$
DECLARE 
	-- Employees
	EmployeeId UUID := '63c3f8c6-ae4e-47f6-ae0b-b30dedf51341';
	
	-- Rights
    Right_CreateEmployee UUID := '25680ef0-ce38-4fc4-8014-24f3e76b4289';
	Right_CreateSchedule UUID := '7c533967-0022-472d-9294-579fb70f9034';
	Right_CreateEmployeeScheduling UUID := 'f1a89c7c-3671-4e99-892b-c327416464ad';

	-- Roles
	Role_Admin UUID := 'ff1dec77-36ec-48a8-82ca-02a9fd23230c';
	Role_Manager UUID := 'd5bdc6b7-f035-4c65-b74f-b01bbe404567';
	Role_Member UUID := '8c5374c1-99d3-4afc-9268-337c86efe82e';
	
	-- Menu
	Menu_HumanResource UUID := 'b78992af-8bbc-498b-bc78-0e5c54a037a7';
	Menu_HumanResource_Schedule UUID := 'ca5a76e8-8fbe-4944-af3b-d40bc9da9cad';
	Menu_Recruitment UUID := '1137a36a-1f57-4752-b22a-95d3651f796b';
	Menu_Recruitment_Session UUID := '68246e27-9092-4b11-b3a9-c723e314f923';
	Menu_Recruitment_Candidate UUID := '9cf62412-d842-48b3-bd74-ad7ce3d4baba';
BEGIN
-- Insert Employee

	INSERT INTO
		PUBLIC."Employees" (
			"Id",
			"FullName",
			"DateOfBirth",
			"Gender",
			"CreatedBy",
			"CreateDate"
		)
	VALUES
		(
			EmployeeId,
			'Trần Thế Duy',
			'1998-07-13',
			1,
			EmployeeId,
			'2024-02-19 08:00:00'
		);

	-- Insert Account
	INSERT INTO
		PUBLIC."Accounts" (
			"Id",
			"EmployeeId",
			"IsActive",
			"Username",
			"Password",
			"Salt",
			"CreatedBy",
			"CreateDate",
			"LastLogin"
		)
	VALUES
		(
			'6951ca9a-813b-4541-a425-4edfda1a1e90',
			EmployeeId,
			true,
			'vip.theduy1307@gmail.com',
			'289e623ff7c11dbae257aaea74ccae5b',
			'Xp2mG',
			EmployeeId,
			NOW(),
			NOW()
		);

	-- Insert rights data
	INSERT INTO public."Rights"("Id", "Name") VALUES (Right_CreateEmployee, 'Create employee and account');
	INSERT INTO public."Rights"("Id", "Name") VALUES (Right_CreateSchedule, 'Create schedule');
    INSERT INTO public."Rights"("Id", "Name") VALUES (Right_CreateEmployeeScheduling, 'Create employee scheduling');
	-- Insert roles data
	INSERT INTO public."Roles"("Id", "Name") VALUES (Role_Admin, 'Admin');
	INSERT INTO public."Roles"("Id", "Name") VALUES (Role_Manager, 'Manager');
	INSERT INTO public."Roles"("Id", "Name") VALUES (Role_Member, 'Member');

	-- Insert RoleRights table
	INSERT INTO public."RoleRights"("RoleId", "RightId") VALUES (Role_Admin, Right_CreateEmployee);
	INSERT INTO public."RoleRights"("RoleId", "RightId") VALUES (Role_Admin, Right_CreateSchedule);
	INSERT INTO public."RoleRights"("RoleId", "RightId") VALUES (Role_Admin, Right_CreateEmployeeScheduling);
	INSERT INTO public."RoleRights"("RoleId", "RightId") VALUES (Role_Manager, Right_CreateEmployeeScheduling);
	-- Insert EmployeeRole
	INSERT INTO public."EmployeeRole"("EmployeesId", "RolesId") VALUES (EmployeeId, Role_Admin);

	-- Insert Menu
	INSERT INTO public."Menus"(
	"Id", "Name", "Icon", "Url")
	VALUES (Menu_HumanResource, 'Nhân sự', 'manage_accounts', null);
	
	INSERT INTO public."Menus"(
	"Id", "Name", "Icon", "Url", "ParentId")
	VALUES (Menu_HumanResource_Schedule, 'Lịch làm việc', null, 'schedule', Menu_HumanResource);
	
	INSERT INTO public."Menus"(
	"Id", "Name", "Icon", "Url")
	VALUES (Menu_Recruitment, 'Tuyển dụng', 'person_search', null);

	INSERT INTO public."Menus"(
	"Id", "Name", "Icon", "Url", "ParentId")
	VALUES (Menu_Recruitment_Session, 'Đợt tuyển dụng', null, 'recruitment-session', Menu_Recruitment);

	INSERT INTO public."Menus"(
	"Id", "Name", "Icon", "Url", "ParentId")
	VALUES (Menu_Recruitment_Candidate, 'Ứng viên', null, 'candidate', Menu_Recruitment);

	-- Insert MenuRole
	INSERT INTO public."MenuRole"(
	"MenusId", "RolesId")
	VALUES (Menu_HumanResource_Schedule, Role_Admin);
	
	INSERT INTO public."MenuRole"(
	"MenusId", "RolesId")
	VALUES (Menu_Recruitment_Session, Role_Admin);
	
	INSERT INTO public."MenuRole"(
	"MenusId", "RolesId")
	VALUES (Menu_Recruitment_Candidate, Role_Admin);

	INSERT INTO public."MenuRole"(
	"MenusId", "RolesId")
	VALUES (Menu_HumanResource_Schedule, Role_Member);
END $$;
