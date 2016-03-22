namespace GeoTools
{
    internal static PointExtension
    {
        internal static double DistanceTo(
            double geoLatitudSource,
            double geoLongitudeSource,
            double geoLatitudTarget,
            double geoLongitudeTarget)
        {
            var geoSource = new GeoCoordinate(geoLatitudSource,geoLongitudeSource);
            
            var geoTarget = new GeoCoordinate(geoLatitudTarget,geoLongitudeTarget);
            
            var returnValue = geoSource.GetDistanceTo(geoTarget);
        }
    }     
}
