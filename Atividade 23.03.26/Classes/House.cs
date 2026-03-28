using System.Reflection.Metadata;

namespace Classes
{
    public class House
    {
        public int Id { get; set; }
        public string? Owner { get; set; }
        public int Num{ get; set; }
        public string? Address { get; set; }
        public double Price { get; set; }
        public TransactionType Transacao { get; set; }
        public static int HouseCount { get; set; }

        public House() {
            HouseCount++;
        }

    }
}
