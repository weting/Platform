CREATE Table dbo.CompanyInfo (
	[ID] int primary key, 
	[Name] char(10) NOT NULL,
	[Identifier] char(8) NOT NULL, 
	[Owner] char(10) NOT NULL, 
	[Phone] char(10) NOT NULL, 
	[Cellphone] char(10) NOT NULL, 
	[Address] char(50) NOT NULL
)
