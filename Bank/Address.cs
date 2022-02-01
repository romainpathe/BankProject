namespace Bank
{
    public class Address
    {
        private string streetAddress;
        private string streetAddress2;
        private City city;


        public Address(string streetAddress, string streetAddress2, City city)
        {
            this.streetAddress = streetAddress;
            this.streetAddress2 = streetAddress2;
            this.city = city;
        }


        public override string ToString()
        {
            return "Adresse: " + streetAddress + "\n" + streetAddress2 + "\n" + city;
        }
    }
}