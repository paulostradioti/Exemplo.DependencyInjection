using System;

namespace Exemplo.DependencyInjection.Services
{
    public interface IScopedService
    {
        Guid GetID();
    }
}