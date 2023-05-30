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
        [TestMethod]
        public void GivenEmail_WhenAnalyed_ShouldReturn_Valid()
        {
            string email = "abc@yahoo.com";
            string result = validate.ValidateEmail(email);
            Assert.AreEqual(result, "Valid");
        }
        [TestMethod]
        public void GivenPhoneNumber_WhenAnalyed_ShouldReturn_Valid()
        {
            string number = "91 7890654321";
            string result = validate.ValidatePhoneNumber(number);
            Assert.AreEqual(result, "Valid");
        }
        [TestMethod]
        public void GivenPassword_WhenAnalyed_ShouldReturn_Valid()
        {
            string password = "Adh123@df";
            string result = validate.ValidatePassword(password);
            Assert.AreEqual(result, "Valid");
        }
        [TestMethod]
        public void GivenMails_WhenAnalyed_ShouldReturn_Valid()
        {
            string result = validate.ValidateAllMails();
            Assert.AreEqual(result, "Valid");
        }
    }
}