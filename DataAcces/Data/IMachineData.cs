using DataAcces.Models;

namespace DataAcces.Data
{
    public interface IMachineData
    {
        Task DeleteMachine(int id);
        Task<MachineModel?> GetMachine(int id);
        Task<IEnumerable<MachineModel>> GetMachines();
        Task InsertMachine(MachineModel machine);
        Task UpdateMachine(MachineModel machine);
    }
}