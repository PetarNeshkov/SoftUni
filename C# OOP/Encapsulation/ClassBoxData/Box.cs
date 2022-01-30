using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
   public class Box
    {
        private const string INVALID_SIDE_EXC_MSG = "{0} cannot be zero or negative.";
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length
        {
            get => length;
            private set
            {
                ValidateSide(value, nameof(Length));
                length = value;
            }
        }
        public double Width
        {
            get => width;
            private set
            {
                ValidateSide(value, nameof(Width));
                width = value;
            }
        }
        public double Height
        {
            get => height;
            private set
            {
                ValidateSide(value, nameof(Height));
                height = value;
            }
        }
        public double CalculateSurfaceArea() =>
            (2 * Length*Width)+CalculateLateralSurfaceArea();
        public double CalculateLateralSurfaceArea() =>
            (2 * Length * Height) + (2 * Width * Height);
        public double CalculateVolume() =>
            Length * Width * Height;
        private void ValidateSide(double side,string paramName)
        {
            if (side<=0)
            {
                throw new ArgumentException(String.Format(INVALID_SIDE_EXC_MSG,paramName));
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {CalculateSurfaceArea():F2}")
              .AppendLine($"Lateral Surface Area - {CalculateLateralSurfaceArea():F2}")
              .AppendLine($"Volume - {CalculateVolume():F2}");
            return sb.ToString().TrimEnd();
        }
    }
}
