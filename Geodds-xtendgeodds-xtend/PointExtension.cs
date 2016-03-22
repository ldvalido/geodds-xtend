using System;
using System.Device.Location;

namespace GeoddsXtendgeoddsXtend
{
    public static class GeoTools
    {
        public static double Distance(this Point point, Point anotherPoint)
        {
            if (point != null && anotherPoint != null){

                var geoSource = new GeoCoordinate(point.Latitude, point.Longitude);

                var geoTarget = new GeoCoordinate(anotherPoint.Latitude, anotherPoint.Longitude);

                var distanceInMeters = geoSource.GetDistanceTo(geoTarget);

                var returnValue = distanceInMeters/1000;

                return returnValue;
            }else{
                throw new ArgumentNullException("Some point is null");
            }
        } 
    }
}