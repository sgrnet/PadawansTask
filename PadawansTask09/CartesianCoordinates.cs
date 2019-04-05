using System;
using System.Collections.Generic;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
	public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
           if (points == null) throw new ArgumentException();
           if (range <= 0) throw new ArgumentException();

            List<Point> res = new List<Point>();
            for (int i = 0; i < points.Length; i++)
            {
                    int xminus, yminus;
                    if (!point.Equals(points[i]))
                    {

                        xminus = Math.Abs( points[i].X - point.X);
                        yminus = Math.Abs( points[i].Y - point.Y);
                            if ((xminus <= range)&&(yminus<= range))
                            {
                                res.Add(points[i]);
                            }
                      
                    }
            }
            return res;
        }
    }
}
