namespace Bank
{
    public class City
    {
        private string name;
        private string postalCode;

        public City()
        {
            this.name = "";
            this.postalCode = "";
        }
        
        
        public City(string name, string postalCode)
        {
            this.name = name;
            this. postalCode = postalCode;
        }
        
        
        public override string ToString()
        {
            return postalCode+", "+name;
        }
    }
}