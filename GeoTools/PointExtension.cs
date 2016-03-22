namespace GeoTools
{
    public static class GeoTools
    {
        public static double Distance(this Point point, Point anotherPoint)
        {
            if (point != null && anotherPoint != null){
                return GisHelper.DistanceTo(
                    point.Latitude,
                    point.Longitude,
                    anotherPoint.Latitude,
                    anotherPoint.Longitude
                    );
            }else{
                throw new NullArgumentException("Some is point.");
            }
        } 
    }
}