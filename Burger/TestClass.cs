using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Burger
{

    [TestFixture]
    public class TestClass
    {

        static string x = "06082020";
        string y = "C://Projects/Burger/Test" + x + ".txt";


        [Test]
        public void TestForTest()
        {
            
            File.AppendAllText(y, Environment.NewLine + "test5 is passed");
            

        }

        //[TearDown] 
        //public void After()
        //{
        //    TestResult z = new TestResult();
        //    TestContext.ResultAdapter(ResultStateException);
        //    File.AppendAllText(y, Environment.NewLine + TestContext(TestForTest()));
            
        //}
        

    }

}
