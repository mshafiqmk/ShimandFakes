using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShimandFackes;

namespace ShimandFackesTests
    {
    [TestClass]
    public class UnitTest1
        {
        [TestMethod]
        public void TestMethod1 ()
            {
            using ( ShimsContext.Create() )
                {
                // hook delegate to the shim method to redirect DateTime.Now
                // to return January 1st of 2000
                ShimDateTime.NowGet = () => new DateTime(2000, 1, 1);
                Y2KChecker.Check();
                }

            }
        }
    }
