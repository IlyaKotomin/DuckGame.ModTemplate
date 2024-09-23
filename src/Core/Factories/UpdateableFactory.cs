using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ModName.Core.Injectors;

namespace ModName.Core.Factories;

public class UpdateableFactory
{
    private readonly Dictionary<string, Type> _updateableTypes;

    public UpdateableFactory()
    {
        _updateableTypes = Assembly.GetAssembly(typeof(IInjectUpdateable))
            .GetTypes()
            .Where(t => typeof(IInjectUpdateable).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .ToDictionary(t => t.Name, t => t);
    }

    public void CreateAll()
    {
        foreach (var instance in _updateableTypes.Values.Select(type => (IInjectUpdateable)Activator.CreateInstance(type)))
            new UpdateableSelfInjector(instance).Inject();
    }
}