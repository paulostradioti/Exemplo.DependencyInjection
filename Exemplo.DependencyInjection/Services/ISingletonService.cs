using System;

namespace Exemplo.DependencyInjection.Services
{
    public interface ISingletonService
    {
        Guid GetID();
    }
}