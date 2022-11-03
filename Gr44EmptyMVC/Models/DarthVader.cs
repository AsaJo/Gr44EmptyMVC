namespace Gr44EmptyMVC.Models
{
    public class DarthVader
    {
        public static string TestForFever(double temperature)
        {

            return (temperature > 37) ? "Doctor Vader says you have fever...have a cookie" : "Doctor Vader says you don't have any fever...so no cookie";
        }
    }
}
