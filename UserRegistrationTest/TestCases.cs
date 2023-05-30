using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class TestCases
    {
        Validation validate = new Validation();
        [TestMethod]
        public void GivenFirstName_WhenAnalyed_ShouldReturn_Valid()
        {
            string firstName = "Abcd";
            string result = validate.ValidateFirstName(firstName);
            Assert.AreEqual(result, "Valid");
        }
        [TestMethod]
        public void GivenLastName_WhenAnalyed_ShouldReturn_Valid()
        {
            string lastName = "Xyz";
            string result = validate.ValidateLastName(lastName);
            Assert.AreEqual(result, "Valid");
        }
    }
}