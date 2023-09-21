namespace DependencyInjection.Services
{
    public class Dummy2 : IDummy2
    {
        public string WriteMore()
        {
            return "More Hello World";
        }
    }

    public interface IDummy2
    {
        string WriteMore();
    }
}
