using System;
using NUnit.Framework;
using PayRollSystem.Models;
using Employee = PayRollSystem.Models.Employee;

namespace DataAcessTests
{
    [TestFixture]
    public class EmployeeTest
    {

        [Test]
        public void ShouldValidateEmployee()
        {
            var employee = Employee();

            var validationResult = employee.Valid();

            Assert.That(validationResult,Is.True);
        }

        [Test]
        public void ShouldValidateEmployeeCode()
        {
            var employee = Employee();
            employee.EmployeeCode.Value = "0123";

            var validationResult = employee.Valid();

            Assert.That(validationResult,Is.False);
            Assert.That(employee.EmployeeCode.Error,Is.EqualTo(ErrorCodeConstants.INVALID_EMPLOYEE_CODE_LENGTH));

            employee.EmployeeCode.Value = "0123ab";

            validationResult = employee.Valid();

            Assert.That(validationResult, Is.False);
            Assert.That(employee.EmployeeCode.Error, Is.EqualTo(ErrorCodeConstants.INVALID_EMPLOYEE_CODE_FORMAT));
        }
        
        [Test]
        public void ShouldValidateEmployeeName()
        {
            var employee = Employee();
            employee.EmployeeName.Value = "Sreerajan";

            var validationResult = employee.Valid();

            Console.WriteLine(employee.EmployeeName.Error);
            Assert.That(validationResult,Is.True);

            employee.EmployeeName.Value = "Sreerajan Ambattumyalil";

            validationResult = employee.Valid();

            Console.WriteLine(employee.EmployeeName.Error);
            Assert.That(validationResult, Is.True);

            employee.EmployeeName.Value = "Sreerajan12345";

            validationResult = employee.Valid();

            Assert.That(validationResult, Is.False);
            Assert.That(employee.EmployeeName.Error, Is.EqualTo(ErrorCodeConstants.INVALID_EMPLOYEE_NAME_FORMAT));
        }

        private static Employee Employee()
        {
            return new Employee
                {
                    EmployeeCode = new Field("012345"),
                    EmployeeName = new Field("Sreerajan Ambattumyalil"),
                    Address = new Field("Address N0 302 Address"),
                    PostCode = new Field("SE16EJ"),
                    Salary = new Field("23456.67"),

                };
        }
    }
}