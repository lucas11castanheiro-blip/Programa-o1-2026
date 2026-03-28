using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Apartament
    {
        public int Id { get; set; }
        public string? Owner { get; set; }
        public int Num { get; set; }
        public string? Address { get; set; }
        public float Price { get; set; }
        public TransactionType Transacao { get; set; }

        public static int ApartamentCount { get; set; }

        public Apartament() {
            ApartamentCount++;
        }


    }
}
