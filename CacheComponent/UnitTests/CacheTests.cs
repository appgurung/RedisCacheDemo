using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class CacheTests
    {
        ICacheProvider _cacheProvider;

        [TestInitialize]
        public void Initialize()
        {
            _cacheProvider = new RedisCacheProvider();
        }

        [TestMethod]
        public void Test_SetValue()
        {
            List<Person> people = new List<Person>()
            {
                new Person(1, "Joe", new List<Contact>()
                {
                    new Contact("1", "123456789"),
                    new Contact("2", "234567890")
                })
            };

            _cacheProvider.Set("People", people);
        }

        [TestMethod]
        public void Test_GetValue()
        {
            var contacts = _cacheProvider.Get<List<Contact>>("People");

            Assert.IsNotNull(contacts);
            Assert.AreEqual(2, contacts.Count);
        }
    }
}