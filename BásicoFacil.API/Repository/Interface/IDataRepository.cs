using BásicoFacil.API.Entity;

namespace BásicoFacil.API.Repository.Interface
{
    public interface IDataRepository
    {
        Task<UserData> AddData(UserData userData);
        Task<List<UserData>> GetData();
    }
}
