namespace GiftNow.Models
{
    public class Gift
    {
        public int GiftId { get; set; }
        public string GiftName { get; set; }
        public string GiftImage { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int CateID { get; set; }
    }
}
