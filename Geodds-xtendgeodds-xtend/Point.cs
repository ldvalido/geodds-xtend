namespace GeoddsXtendgeoddsXtend
{
    public class Point
    {
        public float Latitude {get;set;}
        
        public float Longitude {get;set;}
        
        #region C...tor
        public Point(float latitude,float longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        #endregion
    }
}