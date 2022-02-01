using System.Collections.Generic;

namespace Bank
{
    public class Bank
    {
        public string Code { get; }
        public string Name { get; }
        public List<Agency> AgencyList { get; }


        public override string ToString()
        {
            return "Nom: " + Name + "\nCode: " + Code + "\nListe des agences: " + AgencyList;
        }
    }
}