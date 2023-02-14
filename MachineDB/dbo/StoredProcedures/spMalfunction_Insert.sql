CREATE PROCEDURE [dbo].[spMalfunction_Insert]
	@Name nvarchar(50),
	@Priority nvarchar(50),
	@StartTime datetime,
	@EndTime datetime,
	@Description nvarchar(50),
	@Status nvarchar(50),
	@MachineId int

AS
begin
	insert into dbo.[Malfunction] (Name, Priority, StartTime, EndTime, Description, Status, MachineId)
	values (@Name, @Priority, @StartTime, @EndTime, @Description, @Status, @MachineId);
end

