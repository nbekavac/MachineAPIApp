using DataAcces.Models;

namespace DataAcces.Data
{
    public interface IFullMachineData
    {
        Task<IEnumerable<FullMachineModel>> GetAll_GetMalfunctions();
    }
}