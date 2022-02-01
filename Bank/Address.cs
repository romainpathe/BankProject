namespace Bank
{
    public class Address
    {
        private readonly string _streetAddress;
        private readonly string _streetAddress2;
        private readonly City _city;


        public Address(string streetAddress, string streetAddress2, City city)
        {
            this._streetAddress = streetAddress;
            this._streetAddress2 = streetAddress2;
            this._city = city;
        }


        public override string ToString()
        {
            return "Adresse: " + _streetAddress + "\n" + _streetAddress2 + "\n" + _city;
        }
    }
}