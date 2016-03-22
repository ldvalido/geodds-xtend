namespace GeoTools
{
    public class Point
    {
        public double Latitude {get;set;}
        
        public double Longitude {get;set;}
        
        #region C...tor
        public Point(double latitude,double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        #endregion
    }
}