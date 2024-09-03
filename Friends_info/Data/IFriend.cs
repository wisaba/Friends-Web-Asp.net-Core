namespace Friends_info.Data
{
    public interface IFriend
    {
        int ID { get; set; }
        string Image { get; set; }
        string Name { get; set; }
        int Num { get; set; }
        bool publish { get; set; }
    }
}