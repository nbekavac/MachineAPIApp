CREATE PROCEDURE [dbo].[spMalfunction_Update]
	@Id int,
	@Name nvarchar(50),
	@Priority nvarchar(50),
	@StartTime datetime,
	@EndTime datetime,
	@Description nvarchar(50),
	@Status nvarchar(50),
	@MachineId int
AS
begin
	update dbo.[Malfunction]
	set Name=@Name, Priority=@Priority, StartTime=@StartTime, EndTime=@EndTime, Description=@Description, Status=@Status, MachineId=@MachineId
	where Id=@Id;
end
