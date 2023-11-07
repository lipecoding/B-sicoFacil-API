using BásicoFacil.API.Data;
using BásicoFacil.API.Entity;
using BásicoFacil.API.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BásicoFacil.API.Repository
{
    public class DataRepository : IDataRepository
    {
        private readonly AppDbContext _context;

        public DataRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<UserData> AddData(UserData userData)
        {
            await _context.AddAsync(userData);
            await _context.SaveChangesAsync();

            return userData;
        }

        public async Task<List<UserData>> GetData()
        {
            return await _context.Data.ToListAsync();
            
        }
    }
}
