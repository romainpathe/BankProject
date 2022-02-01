using System.Collections.Generic;

namespace Bank
{
    public class Bank
    {
        private List<Agency> agencyList;
        private string _name;
        private string _code;

        //accessors
        public string Name => _name;
        public string Code => _code;
        public List<Agency> AgencyList
        {
            get { return agencyList; }
            set { agencyList = value; }
        }
    }
}