
using NUnit.Framework;
using d_r_prog;

namespace d_r_prog.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestA()
        {
            string result = Program.NumberToArabic(7);
            Assert.That("VII", Is.EqualTo(result));
        }

        [Test]
        public void TestB()
        {
            string result = Program.NumberToArabic(30);
            Assert.That("XXX", Is.EqualTo(result));
        }

        [Test]
        public void TestC()
        {
            string result = Program.NumberToArabic(555);
            Assert.That("DLV", Is.EqualTo(result));
        }

        [Test]
        public void TestD()
        {
            Assert.That(() => Program.Input_Validator("Buen Dia"), Throws.Exception);
        }

        [Test]
        public void TestE()
        {
            Assert.That(() => Program.Input_Validator(null), Throws.ArgumentNullException);
        }
    }
}
