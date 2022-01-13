
-------------------------------- Source Table  --------------------------------
-----  Create Table
	
	create table rmm_Source
		(sou_source_id int identity(1,1) not null primary key,
		sou_source_name varchar(30),
		sou_createddate datetime,
		sou_createdby varchar(30),
		sou_modifieddate datetime,
		sou_modifiedby varchar(30),
		sou_isactive bit default 0);

-----  Insert  ------
	
	create proc prcsourceinsert
	@name varchar(30),
	@createddate datetime,
	@createdby varchar(30),
	@modifieddate datetime,
	@modifiedby varchar(30)
	as
	insert into rmm_Source
	(
	sou_source_name,
	sou_createddate,
	sou_createdby,
	sou_modifieddate,
	sou_modifiedby
	)
	values
	(
	@name,
	@createddate,
	@createdby,
	@modifieddate,
	@modifiedby
	);

	-----  List  ------ 
	
	create proc procSourceSelect
	as
	select sou_source_id as SourceId,
		sou_source_name as SourceNmae,
		sou_createddate as CreatedDate,
		sou_createdby as CreatedBy,
		sou_modifieddate as ModifiedDate,
		sou_modifiedby as ModifiedBy
		from rmm_Source
		where sou_isactive = 0

		select * from rmm_Source 

	-----  Edit  ------
	
	create proc prcsourceEdit
	@id int,
	@name varchar(30),
	@createddate datetime,
	@createdby varchar(30),
	@modifieddate datetime,
	@modifiedby varchar(30)
	as
	update rmm_Source
		set 
		sou_source_name = @name,
		sou_createddate = @createddate,
		sou_createdby = @createdby,
		sou_modifieddate = @modifieddate,
		sou_modifiedby = @modifiedby
		where sou_source_id = @id

		-----  Delete  ------

	create proc procSourceDelete
	@id INT
	as
	update rmm_Source
	set
	sou_isactive = 1
	where 
	sou_source_id = @id;

--------------------------------  Customer Table  --------------------------------
------Create 

	create table rmm_Customers
		(cus_customer_id int identity(1,1) not null primary key,
		cus_first_name varchar(30),
		cus_last_name varchar(30),
		cus_email varchar(30),
		cus_phonenumber INT,
		cus_designation varchar(30),
		cus_company varchar(30),
		cus_city varchar(30),
		cus_collegename varchar(30),
		cus_state varchar(30),
		cus_createddate datetime,
		cus_createdby varchar(30),
		cus_modifieddate datetime,
		cus_modifiedby varchar(30),
		cus_source_id int foreign key references rmm_Source(sou_source_id),
		cus_isactive bit default 0);

		-----  Insert  ------
	
	create proc procCustomerinsert
		@firstname varchar(30),
		@lastname varchar(30),
		@email varchar(30),
		@phonenumber int,
		@designation varchar(30),
		@company varchar(30),
		@city varchar(30),
		@collegename varchar(30),
		@state varchar(30),
		@createddate datetime,
		@createdby varchar(30),
		@modifieddate datetime,
		@modifiedby varchar(30),
		@sid int
		as
		insert into rmm_Customers 
		(
		cus_first_name,
		cus_last_name,
		cus_email,
		cus_phonenumber,
		cus_designation,
		cus_company,
		cus_city,
		cus_collegename,
		cus_state,
		cus_createddate,
		cus_createdby,
		cus_modifieddate,
		cus_modifiedby,
		cus_source_id
		)
		values
		(
		@firstname,
		@lastname,
		@email,
		@phonenumber,
		@designation,
		@company,
		@city,
		@collegename,
		@state,
		@createddate,
		@createdby,
		@modifieddate,
		@modifiedby,
		@sid
		);
		
	-----  List  ------ 
	
	create proc procCustomerSelect
	as
	select 
	cus_customer_id as CustomerId,
		cus_first_name as FirstName,
		cus_last_name as LastNmae,
		cus_email as EmailAddress,
		cus_phonenumber as PhoneNumber,
		cus_designation as Designation,
		cus_company as Company,
		cus_city as City,
		cus_collegename as CollgeName,
		cus_state as State,
		cus_createddate as CreatedDate,
		cus_createdby as CreatedBy,
		cus_modifieddate as ModifiedDate,
		cus_modifiedby as ModifiedBy,
		sou_source_name as SourceName
		from rmm_Customers A inner join rmm_Source B
		on A.cus_customer_id = B.sou_source_id 
		where cus_isactive = 0 ;
	
	-----  Edit  ------
	
	create proc prcCuustomerEdit
		@id int,
		@firstname varchar(30),
		@lastname varchar(30),
		@email varchar(30),
		@phonenumber int,
		@designation varchar(30),
		@company varchar(30),
		@city varchar(30),
		@collegename varchar(30),
		@state varchar(30),
		@createddate datetime,
		@createdby varchar(30),
		@modifieddate datetime,
		@modifiedby varchar(30)
		as
		update rmm_Customers		
		set 
		cus_first_name = @firstname,
		cus_last_name = @lastname,
		cus_email = @email,
		cus_phonenumber = @phonenumber,
		cus_designation = @designation,
		cus_company = @company,
		cus_city = @city,
		cus_collegename = @collegename,
		cus_state = @state,
		cus_createddate = @createddate,
		cus_createdby = @createdby,
		cus_modifieddate = @modifieddate,
		cus_modifiedby = @modifiedby
		where cus_customer_id = @id ;

		-----  Delete  ------
	
	create proc procCustomerDelete
	@id INT
	as
	update rmm_Customers
	set
	cus_isactive = 1
	where 
	cus_customer_id = @id;

