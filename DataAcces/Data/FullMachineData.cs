using DataAcces.DbAccess;
using DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Data;

public class FullMachineData : IFullMachineData
{
    private readonly ISqlDataAccess _db;

    public FullMachineData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<FullMachineModel>> GetAll_GetMalfunctions() =>
        _db.LoadData<FullMachineModel, dynamic>(storedProcedure: "dbo.spMachine_GetAll_GetMalfunctions", new { });
}
