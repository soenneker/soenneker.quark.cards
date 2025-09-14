using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using Soenneker.Quark.Cards.Abstract;

namespace Soenneker.Quark.Cards;

public sealed class CardService : ICard
{
    private readonly IJSRuntime _jsRuntime;
    private readonly ILogger<CardService> _logger;

    public CardService(IJSRuntime jSRuntime, ILogger<CardService> logger)
    {
        _jsRuntime = jSRuntime;
        _logger = logger;
    }
}


