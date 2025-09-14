using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Quark.Cards.Abstract;

namespace Soenneker.Quark.Cards.Registrars;

/// <summary>
/// A series of Blazor Quark components for cards.
/// </summary>
public static class CardRegistrar
{
    /// <summary>
    /// Adds <see cref="ICard"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddCardAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<ICard, CardService>();
        return services;
    }
}
