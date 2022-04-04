using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism
{
    public class Repository
    {
        Dictionary<string, string> CompanyList;
        public Dictionary<string, List<string>> ArrayDictionary { get; set; }

        public Repository()
        {
            CompanyList = new Dictionary<string, string>();
        }
        public void Add(string key, string value)
        {
            CompanyList.Add(key, value);
        }

        public Dictionary<string, string> GetDictionary()
        {
            return CompanyList;
        }

    }
}
