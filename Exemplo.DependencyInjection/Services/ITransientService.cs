using System;

namespace Exemplo.DependencyInjection.Services
{
    public interface ITransientService
    {
        Guid GetID();
    }
}