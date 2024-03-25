using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futtat
{
    public class Kor
    {

        private int centerX;
        public int CenterX 
        {
            get { return centerX;}
            set { centerX = value; }
        }
        private int centerY;
        public int CenterY
        {
            get { return centerY;}
            set { centerY = value; }
        }

        public void setKozeppont(int x, int y)
        {
            CenterX = x;
            CenterY = y;
        }

        private double r;
        public double R
        {
            get { return r; }
            set { r = value; }
        }

        public Kor(int centerX, int centerY, double r)
        {
            CenterX = centerX;
            CenterY = centerY;
            R = r;
        }

        public double Terulet()
        {
            return Math.Round(R * R * Math.PI,2);
        }

        public double Kerulet()
        {
            return Math.Round(2 * R * Math.PI,2);
        }

        public override string? ToString()
        {
            return $"A megadott kör középpontja: ({CenterX}:{CenterY}) koordinátán található; Sugara: {R} cm; Kerülete: {this.Kerulet()} cm²; Területe: {this.Terulet()} cm³";
        }
    }
}
