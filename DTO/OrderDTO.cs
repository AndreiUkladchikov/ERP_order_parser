namespace DTO
{
    public class OrderDTO
    {
        public int? ClientId { get; set; }
        public string Email { get; set; }
        public int TelegramId { get; set; }
        public DateTime Date { get; set; }
        public byte[] Data { get; set; }
        public string FileType { get; set; }
    }
}
