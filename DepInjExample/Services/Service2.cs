namespace DepInjExample.Services
{
    public interface IService2
    {
        int GetValue();
    }

    public class Service2 : IService2
    {
        private int value = 0;
        public int GetValue()
        {
            return value++;
        }
    }
}
