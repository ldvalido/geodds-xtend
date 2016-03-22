using Xunit;

namespace GeoddsXtend.Test
{
    public class PointTest
    {
        [Fact]
        public void BasicGetDistanceTest()
        {
            var sourcePoint = new Point(-34.6037f, -58.3816f);//Buenos Aires

            var targetPoint = new Point(-37.9799f, -57.5898f);//MDP
            
            var distance = sourcePoint.Distance(targetPoint);
            
            Assert.Equal(System.Math.Round(distance), 382);
        }   
    }
    
}