CREATE PROCEDURE [dbo].[spMalfunction_GetSpecificNumberOfMalfunctions]

AS
begin
	select top 3 *
	from dbo.Malfunction
	ORDER BY Priority, StartTime DESC;
	
end

