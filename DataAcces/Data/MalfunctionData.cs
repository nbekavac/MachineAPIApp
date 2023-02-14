using DataAcces.DbAccess;
using DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Data;

public class MalfunctionData : IMalfunctionData
{
    private readonly ISqlDataAccess _db;

    public MalfunctionData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<MalfunctionModel>> GetMalfunctions() =>
        _db.LoadData<MalfunctionModel, dynamic>(storedProcedure: "dbo.spMalfunction_GetAll", new { });

    public async Task<MalfunctionModel?> GetMalfunction(int id)
    {
        var results = await _db.LoadData<MalfunctionModel, dynamic>(
            storedProcedure: "dbo.spMalfunction_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertMalfunction(MalfunctionModel malfunction) =>
        _db.SaveData(storedProcedure: "dbo.spMalfunction_Insert",
            new { malfunction.Name, malfunction.Priority, malfunction.StartTime, malfunction.EndTime, malfunction.Description, malfunction.Status, malfunction.MachineId });

    public Task UpdateMalfunction(MalfunctionModel malfunction) =>
        _db.SaveData(storedProcedure: "dbo.spMalfunction_Update", malfunction);

    public Task DeleteMalfunction(int id) =>
        _db.SaveData(storedProcedure: "dbo.spMalfunction_Delete", new { Id = id });

    public Task ChangeStatus(int id , string status)=> 
        _db.SaveData(storedProcedure:"dbo.spMalfunction_StatusChange", new { Id=id , Status=status });

    public Task<IEnumerable<MalfunctionModel>> GetSpecificNumberOfMalfunctions() =>
        _db.LoadData<MalfunctionModel, dynamic>(storedProcedure: "dbo.spMalfunction_GetSpecificNumberOfMalfunctions", new { });
}
