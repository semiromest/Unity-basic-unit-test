using NUnit.Framework;

public class UnityAssertExample
{
    [Test]
    public void TestAssertAreEqual()
    {
        int x = 5;
        Assert.AreEqual(5, x);  // �ki de�eri kar��la�t�r�r ve e�it olup olmad���n� kontrol eder.
    }

    [Test]
    public void TestAssertAreNotEqual()
    {
        int x = 5;
        int y = 10;
        Assert.AreNotEqual(x, y);  // �ki de�eri kar��la�t�r�r ve e�it olmad���n� kontrol eder.
    }

    [Test]
    public void TestAssertIsTrue()
    {
        bool condition = true;
        Assert.IsTrue(condition);  // Belirtilen ko�ulun do�ru (true) olup olmad���n� kontrol eder.
    }

    [Test]
    public void TestAssertIsFalse()
    {
        bool condition = false;
        Assert.IsFalse(condition);  // Belirtilen ko�ulun yanl�� (false) olup olmad���n� kontrol eder.
    }

    [Test]
    public void TestAssertIsNull()
    {
        string str = null;
        Assert.IsNull(str);  // Bir nesnenin null olup olmad���n� kontrol eder.
    }

    [Test]
    public void TestAssertIsNotNull()
    {
        string str = "Hello";
        Assert.IsNotNull(str);  // Bir nesnenin null olmad���n� kontrol eder.
    }

    [Test]
    public void TestAssertAreSame()
    {
        object obj1 = new object();
        object obj2 = obj1;
        Assert.AreSame(obj1, obj2);  // �ki nesnenin ayn� nesne referans�na sahip olup olmad���n� kontrol eder.
    }

    [Test]
    public void TestAssertAreNotSame()
    {
        object obj1 = new object();
        Assert.AreNotSame(obj1, new object());  // �ki nesnenin ayn� nesne referans�na sahip olmad���n� kontrol eder.
    }

    [Test]
    public void TestAssertGreater()
    {
        int x = 5;
        int y = 10;
        Assert.Greater(y, x);  // Bir de�erin di�erinden b�y�k oldu�unu kontrol eder.
    }

    [Test]
    public void TestAssertLess()
    {
        int x = 5;
        int y = 10;
        Assert.Less(x, y);  // Bir de�erin di�erinden k���k oldu�unu kontrol eder.
    }

    [Test]
    public void TestAssertDoesNotThrow()
    {
        Assert.DoesNotThrow(() => { int result = 5 / 2; });  // Belirtilen kodun herhangi bir istisna (exception) f�rlatmad���n� kontrol eder.
    }
}
