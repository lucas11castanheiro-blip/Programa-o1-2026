namespace SaleOrder
{
    public class Customer
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }

        public static int InstanceCount {  get; set; }

        public Customer()
        {
            InstanceCount++;
        }

        public override string ToString() {
            return $@"
                Id: {this.Id}, 
                Name: {this.Name}, 
                Birthdate: {this.BirthDate.ToLongDateString()}
            ";
        }

    }
}


