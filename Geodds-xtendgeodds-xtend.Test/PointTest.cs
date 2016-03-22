using Xunit;

namespace GeoddsXtendgeoddsXtend.Helper
{
    public class PointTest
    {
        [Fact]
        public void BasicGetDistanceTest()
        {
            var sourcePoint = new Point(-34.6037, -58.3816);//Buenos Aires

            var targetPoint = new Point(-37.9799, -57.5898);//MDP
            
            var distance = sourcePoint.Distance(targetPoint);
            
            Assert.Equal(System.Math.Round(distance), 382);
        }   
    }
    
}