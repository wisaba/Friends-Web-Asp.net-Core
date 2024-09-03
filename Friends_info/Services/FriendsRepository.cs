using Friends_info.Data;

namespace Friends_info.Services
{
    public interface FriendsRepository
    {
        void Create(Friend model);
        void Delete(int id);
        Task <List<Friend>> Read();
        void Update(Friend model);
    }
}