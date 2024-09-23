using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ModName.Core.Injectors;

namespace ModName.Core.Factories;

public class DrawableFactory
{
    private readonly Dictionary<string, Type> _drawableTypes;

    public DrawableFactory()
    {
        _drawableTypes = Assembly.GetAssembly(typeof(IInjectDrawable))
            .GetTypes()
            .Where(t => typeof(IInjectDrawable).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .ToDictionary(t => t.Name, t => t);
    }

    public void CreateAll()
    {
        foreach (var instance in _drawableTypes.Values.Select(type => (IInjectDrawable)Activator.CreateInstance(type)))
            new DrawableSelfInjector(instance).Inject();
    }
}