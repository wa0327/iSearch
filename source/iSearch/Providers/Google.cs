using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSearch.Providers
{
    public sealed class Google : IProvider
    {
        public IEnumerable<Record> Search(string pattern)
        {
            if (string.IsNullOrEmpty(pattern))
            {
                throw new ArgumentNullException("pattern");
            }

            throw new NotImplementedException();
        }
    }
}
