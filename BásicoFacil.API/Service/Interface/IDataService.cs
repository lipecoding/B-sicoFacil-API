using BásicoFacil.API.DTO.Request;
using BásicoFacil.API.DTO.Response;

namespace BásicoFacil.API.Service.Interface
{
    public interface IDataService
    {
        Task<AddDataResponse> AddData(AddDataRequest request);
        Task<GetDataResponse> GetData();
    }
}
