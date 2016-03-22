using System;

namespace GeoddsXtend
{
    public class Polygon
    {
        #region C...tor

        public Polygon(Point[] vertexesPoints)
        {
            _vertexesPoints = vertexesPoints;
        }
        #endregion

        #region Private Properties

        private readonly Point[] _vertexesPoints;

        #endregion

        #region Public Methods
        public bool IsInside(Point point)
        {
            // Get the angle between the point and the
            // first and last vertices.
            var vertexLength = _vertexesPoints.Length - 1;
            var totalAngle = GetAngle(
                _vertexesPoints[vertexLength].Latitude, _vertexesPoints[vertexLength].Longitude,
                point.Latitude, point.Longitude,
                _vertexesPoints[0].Latitude, _vertexesPoints[0].Longitude);

            // Add the angles from the point
            // to each other pair of vertices.
            for (var i = 0; i < vertexLength; i++)
            {
                totalAngle += GetAngle(
                    _vertexesPoints[i].Latitude, _vertexesPoints[i].Longitude,
                    point.Latitude, point.Longitude,
                    _vertexesPoints[i + 1].Latitude, _vertexesPoints[i + 1].Longitude);
            }

            // The total angle should be 2 * PI or -2 * PI if
            // the point is in the polygon and close to zero
            // if the point is outside the polygon.
            return (Math.Abs(totalAngle) > 0.000001);
        }
        #endregion

        #region Auxiliar Members
        // Return the angle ABC.
        // Return a value between PI and -PI.
        // Note that the value is the opposite of what you might
        // expect because Y coordinates increase downward.
        static float GetAngle(float aX, float aY,
            float bX, float bY, float cX, float cY)
        {
            // Get the dot product.
            var dotProduct = DotProduct(aX, aY, bX, bY, cX, cY);

            // Get the cross product.
            var crossProduct = CrossProductLength(aX, aY, bX, bY, cX, cY);

            // Calculate the angle.
            return (float)Math.Atan2(crossProduct, dotProduct);
        }
        // Return the dot product AB · BC.
        // Note that AB · BC = |AB| * |BC| * Cos(theta).
        private static float DotProduct(float aX, float aY,
            float bX, float bY, float cX, float cY)
        {
            // Get the vectors' coordinates.
            var bAx = aX - bX;
            var bAy = aY - bY;
            var bCx = cX - bX;
            var bCy = cY - bY;

            // Calculate the dot product.
            return (bAx * bCx + bAy * bCy);
        }

        // Return the cross product AB x BC.
        // The cross product is a vector perpendicular to AB
        // and BC having length |AB| * |BC| * Sin(theta) and
        // with direction given by the right-hand rule.
        // For two vectors in the X-Y plane, the result is a
        // vector with X and Y components 0 so the Z component
        // gives the vector's length and direction.
        static float CrossProductLength(float aX, float aY,
            float bX, float bY, float cX, float cY)
        {
            // Get the vectors' coordinates.
            var bAx = aX - bX;
            var bAy = aY - bY;
            var bCx = cX - bX;
            var bCy = cY - bY;

            // Calculate the Z coordinate of the cross product.
            return (bAx * bCy - bAy * bCx);
        }
        #endregion
    }
}
