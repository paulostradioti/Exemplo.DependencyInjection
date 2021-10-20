using System;

namespace Exemplo.DependencyInjection.Services
{
    public class MyService : ITransientService, IScopedService, ISingletonService
    {
        private Guid id;

        public MyService()
        {
            id = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return id;
        }
    }
}