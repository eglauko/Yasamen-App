﻿using Microsoft.AspNetCore.Components;

namespace RoyalCode.Yasamen.Demos.Wasm.BlazorShow;

public interface ICatalogBuilder
{

    ICatalogBuilder AddShow<TShow, TComponent>(TShow show)
        where TShow : IShow<TComponent>, new()
        where TComponent : class, IComponent;
}
