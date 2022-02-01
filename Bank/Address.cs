namespace Bank
{
    public class Address
    {
        private readonly City _city;

        public string StreetAddress { get; }
        public string StreetAddress2 { get; }

        public Address(string streetAddress, string streetAddress2, City city)
        {
            this.StreetAddress = streetAddress;
            this.StreetAddress2 = streetAddress2;
            this._city = city;
        }


        public override string ToString()
        {
            return "Adresse: " + StreetAddress + "\n" + StreetAddress2 + "\n" + _city;
        }
    }
}