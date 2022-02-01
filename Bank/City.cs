namespace Bank
{
    public class City
    {
        private readonly string _name;
        private readonly string _postalCode;

        public City()
        {
            this._name = "";
            this._postalCode = "";
        }
        
        
        public City(string name, string postalCode)
        {
            this._name = name;
            this._postalCode = postalCode;
        }
        
        
        public override string ToString()
        {
            return _postalCode+", "+_name;
        }
    }
}