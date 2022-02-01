namespace Bank
{
    public class City
    {
        public string Name { get; }
        public string PostalCode { get; }

        public City(string name, string postalCode)
        {
            this.Name = name;
            this.PostalCode = postalCode;
        }
        
        
        public override string ToString()
        {
            return PostalCode+", "+Name;
        }
    }
}