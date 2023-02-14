using DataAcces.DbAccess;
using DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Data;

public class MachineData : IMachineData
{
    private readonly ISqlDataAccess _db;
    public MachineData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<MachineModel>> GetMachines() =>
        _db.LoadData<MachineModel, dynamic>(storedProcedure: "dbo.spMachine_GetAll", new { });

    public async Task<MachineModel?> GetMachine(int id)
    {
        var results = await _db.LoadData<MachineModel, dynamic>(
            storedProcedure: "dbo.spMachine_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertMachine(MachineModel machine) =>
        _db.SaveData(storedProcedure: "dbo.spMachine_Insert", new { machine.Name });

    public Task UpdateMachine(MachineModel machine) =>
        _db.SaveData(storedProcedure: "dbo.spMachine_Update", machine);

    public Task DeleteMachine(int id) =>
        _db.SaveData(storedProcedure: "dbo.spMachine_Delete", new { Id = id });
}
