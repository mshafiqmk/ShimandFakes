using System;
using System.Fakes;
using System.IO.Fakes;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShimandFackes;

namespace UnitTestProject1
    {
    [TestClass]
    public class UnitTest1
        {
        [TestMethod]
        public void TestMethod1 ()
            {
            using (ShimsContext.Create ())
                {
                // hook delegate to the shim method to redirect DateTime.Now
                // to return January 1st of 2000
                ShimDateTime.NowGet = () => new DateTime (2001, 1, 1);
                Y2KChecker.Check ();
                }
            }
        [TestMethod]
        public void TestMethod2 ()
            {
            using (ShimsContext.Create ())
                {
                // hook delegate to the shim method to redirect DateTime.Now
                // to return January 1st of 2000

                ShimFile.ReadAllTextString = (str) => { return "file content"; };

                ShimDateTime.NowGet = () => new DateTime (2001, 1, 1);
                Y2KChecker.Check ();
                }
            }

        [TestMethod]
        public void TestMethod4 ()
            {
             }


        [TestMethod]
        public void MyTestMethod ()
            {
            //Arrange 

            }
        }
    }

