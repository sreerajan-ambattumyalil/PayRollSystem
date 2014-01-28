using System.Text.RegularExpressions;
using DataAccess;
using NUnit.Framework;

namespace DataAcessTests
{
    [TestFixture]
    public class EmployeeDataAccessorTest
    {
        [Test]
        public void LoadAll()
        {
            new EmployeeRepository(new SqlConnectionManager()).LoadAllEmployeeNameAndId();
        }

        [Test]
        public void ShouldValidateSalary()
        {
//            [0-9]*\.[0-9]
//            var isMatch = new Regex(@"^\d{18}\.\d{2}$").IsMatch("12.8");
            var isMatch = new Regex(@"^\d{6}$").IsMatch("000823");
            Assert.IsTrue(isMatch);
        }
    }
}
