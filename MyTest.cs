using NUnit.Framework;

public class UnityAssertExample
{
    [Test]
    public void TestAssertAreEqual()
    {
        int x = 5;
        Assert.AreEqual(5, x);  // Ýki deðeri karþýlaþtýrýr ve eþit olup olmadýðýný kontrol eder.
    }

    [Test]
    public void TestAssertAreNotEqual()
    {
        int x = 5;
        int y = 10;
        Assert.AreNotEqual(x, y);  // Ýki deðeri karþýlaþtýrýr ve eþit olmadýðýný kontrol eder.
    }

    [Test]
    public void TestAssertIsTrue()
    {
        bool condition = true;
        Assert.IsTrue(condition);  // Belirtilen koþulun doðru (true) olup olmadýðýný kontrol eder.
    }

    [Test]
    public void TestAssertIsFalse()
    {
        bool condition = false;
        Assert.IsFalse(condition);  // Belirtilen koþulun yanlýþ (false) olup olmadýðýný kontrol eder.
    }

    [Test]
    public void TestAssertIsNull()
    {
        string str = null;
        Assert.IsNull(str);  // Bir nesnenin null olup olmadýðýný kontrol eder.
    }

    [Test]
    public void TestAssertIsNotNull()
    {
        string str = "Hello";
        Assert.IsNotNull(str);  // Bir nesnenin null olmadýðýný kontrol eder.
    }

    [Test]
    public void TestAssertAreSame()
    {
        object obj1 = new object();
        object obj2 = obj1;
        Assert.AreSame(obj1, obj2);  // Ýki nesnenin ayný nesne referansýna sahip olup olmadýðýný kontrol eder.
    }

    [Test]
    public void TestAssertAreNotSame()
    {
        object obj1 = new object();
        Assert.AreNotSame(obj1, new object());  // Ýki nesnenin ayný nesne referansýna sahip olmadýðýný kontrol eder.
    }

    [Test]
    public void TestAssertGreater()
    {
        int x = 5;
        int y = 10;
        Assert.Greater(y, x);  // Bir deðerin diðerinden büyük olduðunu kontrol eder.
    }

    [Test]
    public void TestAssertLess()
    {
        int x = 5;
        int y = 10;
        Assert.Less(x, y);  // Bir deðerin diðerinden küçük olduðunu kontrol eder.
    }

    [Test]
    public void TestAssertDoesNotThrow()
    {
        Assert.DoesNotThrow(() => { int result = 5 / 2; });  // Belirtilen kodun herhangi bir istisna (exception) fýrlatmadýðýný kontrol eder.
    }
}
