using Friends_info.Data.Context;
using Friends_info.Data;
using System.Security.Policy;
using Microsoft.EntityFrameworkCore;

namespace Friends_info.Services
{

    public class FriendsService : FriendsRepository
    {

        Friends_infoDbContext _dbContext;
        public FriendsService(Friends_infoDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<List<Friend>> Read()
        {
            return await this._dbContext.Friends.ToListAsync();
        }
        public async void Create(Friend model)
        {
            this._dbContext.Friends.Add(model);
            await _dbContext.SaveChangesAsync();

        }
        public async void Update(Friend model)
        {
            this._dbContext.Friends.Update(model);
            await _dbContext.SaveChangesAsync();
        }
        public async void Delete(int id)
        {
            Friend model = this._dbContext.Friends.Find(id);
            this._dbContext.Friends.Remove(model);
            await _dbContext.SaveChangesAsync(true);


        }

    }
}

   

