namespace DependencyInjection.Services
{
    public class DummyClass : IDummy
    {
        public string Write()
        {
            return "Hello World";
        }
    }

    public interface IDummy
    {
        public string Write();
    }
}
