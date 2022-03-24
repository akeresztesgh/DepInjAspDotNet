namespace DepInjExample.Services
{
    public interface IService3
    {
        int GetValue();
    }

    public class Service3 : IService3
    {
        private int value = -1;
        public int GetValue()
        {
            Interlocked.Increment(ref value);
            return value;
        }
    }
}
