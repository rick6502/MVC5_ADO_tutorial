Create Procedure InsertData  
(  
@FName varchar(50),  
@MName varchar(50),  
@LName varchar(50),  
@EmailId  varchar(50)  
)  
as begin  
  
Insert into Employee (FName,MName,LName,EmailId ) values(@FName,@MName,@LName,@EmailId )  
End  