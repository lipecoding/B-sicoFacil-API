using AutoMapper;
using BásicoFacil.API.DTO.Request;
using BásicoFacil.API.DTO.Response;
using BásicoFacil.API.Entity;
using BásicoFacil.API.Repository.Interface;
using BásicoFacil.API.Service.Interface;

namespace BásicoFacil.API.Service
{
    public class DataService : IDataService
    {
        private readonly IMapper _mapper;
        private readonly IDataRepository _repository;

        public DataService(IMapper mapper, IDataRepository dataRepository)
        {
            _mapper = mapper;
            _repository = dataRepository;
        }

        public async Task<AddDataResponse> AddData(AddDataRequest request)
        {
            var map = _mapper.Map<UserData>(request);

            map.Pontos = map.Agua ? 1 : 0;
            map.Pontos += map.Esgoto ? 1 : 0;
            map.Pontos += map.Coleta ? 1 : 0;
            map.Pontos += map.Drenagem ? 1 : 0;

            var addCustomer = await _repository.AddData(map);

            var response = _mapper.Map<AddDataResponse>(addCustomer);

            return response;
        }

        public async Task<GetDataResponse> GetData()
        {
            var userData = await _repository.GetData();

            GetDataResponse response = new();

            response.Agua = userData.Count(x => x.Agua == true);
            response.Esgoto = userData.Count(x => x.Esgoto == true);
            response.Coleta = userData.Count(x => x.Coleta == true);
            response.Drenagem = userData.Count(x => x.Drenagem == true);
            response.Total = userData.Count();

            foreach (var data in userData)
            {
                switch (data.Pontos)
                {
                    case >= 3:
                        response.Bom++;
                        break;
                    case 2:
                        response.Razoavel++;
                        break;
                    case 1:
                        response.Ruim++;
                        break;
                }       
            }
            return response;
        }
    }
}
