using IntegrationTest.Services;
using IntegrationTest.Services.Interface;

namespace SampleSonarQubeTest;

[TestClass]
public class MathTest
{
    [TestMethod]
    public void Add()
    {
        //var mockMath = new Mock<IMath>();
        //mockMath.Setup(a => a.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(10);
        IMath math = new CalcMath();
        var addNumber = math.Add(1,2);
        Assert.AreEqual(3,addNumber);
    }
}