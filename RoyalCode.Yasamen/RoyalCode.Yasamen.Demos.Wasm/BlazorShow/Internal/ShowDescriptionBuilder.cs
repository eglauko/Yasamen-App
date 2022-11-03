﻿using Microsoft.AspNetCore.Components;
using System.Xml.Linq;

namespace RoyalCode.Yasamen.Demos.Wasm.BlazorShow.Internal;

public class ShowDescriptionBuilder<TComponent> : IShowDescriptionBuilder<TComponent>
    where TComponent : class, IComponent
{
    private readonly ShowDescription showDescription;

    public ShowDescriptionBuilder(ShowDescription showDescription)
    {
        this.showDescription = showDescription;
    }

    public IShowDescriptionBuilder<TComponent> AddScene(Action<ISceneBuilder> configure)
    {
        throw new NotImplementedException();
    }

    public IShowDescriptionBuilder<TComponent> Description(string description)
    {
        showDescription.Description = description;
        return this;
    }

    public IShowDescriptionBuilder<TComponent> Group(string groupName)
    {
        showDescription.Group = groupName;
        return this;
    }

    public IShowDescriptionBuilder<TComponent> Name(string name)
    {
        showDescription.Name = name;
        return this;
    }

    public IShowDescriptionBuilder<TComponent> Route(string route)
    {
        showDescription.Route = route;
        return this;
    }

    public IShowDescriptionBuilder<TComponent> Properties(Action<IShowProperties<TComponent>> configure)
    {
        throw new NotImplementedException();
    }
}
