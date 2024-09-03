using AutoMapper;
using Friends_info.Data;

namespace Friends_info.Data
{

    public class Database
    {
        private IMapper mapper;

        public Database(IMapper mapper)
        {
            this.mapper = mapper;
        }


        public static List<Friend> GetFriends()
        {



            List<Friend> friends = new List<Friend>();

            for (int i = 1; i <= 10; i++)
            {
                friends.Add(new Friend()
                {
                    Name = "Maggy",
                    Num = i,
                    Image = "/img/10.jfif",
                    publish = true,
                });

            }
            return friends;
        }
    }
}