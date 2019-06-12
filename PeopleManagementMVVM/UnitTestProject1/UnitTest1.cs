using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleManagementMVVM;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstNameCheck()
        {
            ViewModel viewModel = new ViewModel();
            var name = viewModel.FirstName;
            Assert.AreEqual(name, "Ivan");
        }

        [TestMethod]
        public void LastNameCheck()
        {
            ViewModel viewModel = new ViewModel();
            var name = viewModel.LastName;
            Assert.AreEqual(name, "Dobrinov");
        }

        [TestMethod]
        public void AgeCkeck()
        {
            ViewModel viewModel = new ViewModel();
            var name = viewModel.Age;
            Assert.AreEqual(name, "25");
        }

        [TestMethod]
        public void EmailChek()
        {
            ViewModel viewModel = new ViewModel();
            var name = viewModel.Email;
            Assert.AreEqual(name, "idobrinov@abv.bg");
        }

        [TestMethod]
        public void AddCommandCheck()
        {
            ViewModel viewModel = new ViewModel();
            var check = viewModel.addCommandCheck;
            Assert.IsTrue(check);
        }

        [TestMethod]
        public void DeleteCommandCheck()
        {
            ViewModel viewModel = new ViewModel();
            var check = viewModel.deleteCommandCheck;
            Assert.IsTrue(check);
        }
    }
}
