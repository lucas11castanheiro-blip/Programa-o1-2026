using Microsoft.AspNetCore.Mvc;

namespace Aula._04.Models
{
    public class Plant
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
        public int Count { get; set; }
        public double Size { get; set; }

        public bool Validate()
        {
            if (Count == 0
                || Size == 0
                || string.IsNullOrEmpty(Name)
                || string.IsNullOrEmpty(Description)
                || string.IsNullOrEmpty(Color))
                return false;
            return true;
        }
    }
}
