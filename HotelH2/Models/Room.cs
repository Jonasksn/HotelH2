namespace HotelH2.Models
{
    public class Room
    {
        public int id { get; set; }
        public String? roomType { get; set; }
        public int roomNum { get; set; }
        public int price { get; set; }
        public int beds { get; set; }
        public bool isOccupied { get; set; }
    }
}
