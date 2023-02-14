using DataAcces.Models;

namespace DataAcces.Data
{
    public interface IMalfunctionData
    {
        Task DeleteMalfunction(int id);
        Task<MalfunctionModel?> GetMalfunction(int id);
        Task<IEnumerable<MalfunctionModel>> GetMalfunctions();
        Task InsertMalfunction(MalfunctionModel malfunction);
        Task UpdateMalfunction(MalfunctionModel malfunction);
        Task ChangeStatus(int id, string status);

        Task<IEnumerable<MalfunctionModel>> GetSpecificNumberOfMalfunctions();
    }
}