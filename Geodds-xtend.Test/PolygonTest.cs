using System.Collections.Generic;
using Xunit;

namespace GeoddsXtend.Test
{
    public class PolygonTest
    {

        [Fact]
        public void TestBasic()
        {
            var vertexes = new List<Point>
            {
                new Point(10, 10),
                new Point(10, 20),
                new Point(20, 10),
                new Point(20, 20)
            };
            var polygon = new Polygon(vertexes.ToArray());

            var belongsTo = polygon.IsInside(new Point(15, 15));
            Assert.True(belongsTo);

            var dontBelognsTo = polygon.IsInside(new Point(5, 5));
            Assert.False(dontBelognsTo);
        }
    }
}
