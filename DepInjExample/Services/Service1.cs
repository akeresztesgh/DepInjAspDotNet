namespace DepInjExample.Services
{
    public interface IService1
    {
        int GetValue();
    }

    public class Service1 : IService1
    {
        private int value = 0;

        public int GetValue()
        {
            return value++;
        }
    }
}
