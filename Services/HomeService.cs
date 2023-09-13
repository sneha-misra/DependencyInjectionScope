namespace DependencyInjectionScope.Services
{
    public class HomeService : ITransientService, IScopedService, ISingletonService
    {
        Guid id;
        public HomeService()
        {
            id = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return id;
        }
    }

    public interface ITransientService
    {
        Guid GetID();
    }

    public interface IScopedService
    {
        Guid GetID();
    }

    public interface ISingletonService
    {
        Guid GetID();
    }
}
