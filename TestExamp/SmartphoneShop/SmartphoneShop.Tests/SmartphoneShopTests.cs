using NUnit.Framework;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
       [Test]
       public void Capacity()
        {
            Shop shop = new Shop(50);
           Assert.AreEqual(50, shop.Capacity);

        }
    }
}