namespace Friends_info.Data
{

    public class FriendViewModel
    {
        public int Num { get; set; }
        public String Name { get; set; }

        public String Image { get; set; }
    }
    public class Friend : IFriend
    {


        public int Num { get; set; }
        public String Name { get; set; }

        public String Image { get; set; }
        public int ID { get; set; }
        public bool publish { get; set; }
    }
}
