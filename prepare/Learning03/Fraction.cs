
    public class Fraction
    {
        private int _top;
        private int _bottom;

        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        public Fraction(int top)
        {
            _top = top;
            _bottom = 1;
        }

        //this class passes top and bottom into the private variables _top and _bottom
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        public string GetFractionString()
        {
            string stringFraction = $"{_top}/{_bottom}";
            return stringFraction;
        }

        public double GetDecimalValue()
        {
            double doubleFraction = (double)_top / (double)_bottom;
            return doubleFraction;
        }
    }