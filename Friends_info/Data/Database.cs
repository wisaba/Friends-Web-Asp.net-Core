namespace Friends_info.Data
{
    public class Database
    {

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
               });
           
            }
            return friends;
        }
    }
}
