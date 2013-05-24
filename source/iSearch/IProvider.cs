using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSearch
{
    public interface IProvider
    {
        IEnumerable<Record> Search(string pattern);
    }
}
