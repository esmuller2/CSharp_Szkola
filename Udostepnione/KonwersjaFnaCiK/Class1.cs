namespace KonwersjaFnaCiK
{
    public class KonwenterJakub
    {
        public static double[] FnaCiK(double f)
        {
            double c = (f - 32) * 5.0 / 9.0;
            double k = (f - 32) * 5.0 / 9.0 + 273.15;

            return new double[] {c,k};
        }
    }
}
