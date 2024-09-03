

namespace Friends_info.Infrastructure
{
    public class AutoMapperProfile : AutoMapper.Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Data.Friend, Data.FriendViewModel>();
        }
    }
}

