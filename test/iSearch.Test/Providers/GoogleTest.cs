using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace iSearch.Providers
{
    [TestClass]
    public class GoogleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Google_Search_pattern_null()
        {
            var target = new Google();

            target.Search(null);
        }
    }
}
