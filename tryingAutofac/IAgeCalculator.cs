namespace tryingAutofac
{
    public interface IAgeCalculator
    {
        bool CanUseZip(int age);
    }
    
    public class NzAgeCalc: IAgeCalculator
    {
        public bool CanUseZip(int age)
        {
            return age >= 18;
        }
    }
    
    public class UsAgeCalc: IAgeCalculator
    {
        public bool CanUseZip(int age)
        {
            return age >= 21;
        }
    }
}