CREATE PROCEDURE [dbo].[spMachine_GetAll_GetMalfunctions]

AS
begin
	select Machine.Id,Machine.Name, Malfunction.Name, DATEDIFF(day, Malfunction.StartTime, Malfunction.EndTime) as DayDiff
	from dbo.Machine INNER JOIN dbo.Malfunction
	ON Machine.Id=Malfunction.MachineId;
end
