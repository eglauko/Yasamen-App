﻿
using RoyalCode.Yasamen.Commons.Internal;

namespace RoyalCode.Yasamen.Commons;

public class CssClassMap
{
    public static CssClassMap Create(Func<bool> condition, string? cssClass)
    {
        var map = new CssClassMap(new List<ICssClassBuilder>());
        
        if (cssClass is not  null)
            map.Add(condition, cssClass);
        
        return map;
    }

    public static CssClassMap Create(params string?[]? cssClasses)
    {
        var map = new CssClassMap(new List<ICssClassBuilder>());

        if (cssClasses != null && cssClasses.Length != 0)
            map.Add(cssClasses);

        return map;
    }

    private readonly ICollection<ICssClassBuilder> conditions;

    private CssClassMap(ICollection<ICssClassBuilder> conditions)
    {
        this.conditions = conditions;
    }

    public CssClassMap Add(params string?[] cssClasses)
    {
        conditions.Add(new CssClasses(cssClasses));
        return this;
    }

    public CssClassMap Add(Func<bool> condition, string cssClass)
    {
        conditions.Add(new CssClassCondition(condition, cssClass));
        return this;
    }

    public CssClassMap Add(Func<bool> condition, string cssClassWhenTrue, string cssClassWhenFalse)
    {
        conditions.Add(new CssClassCondition(condition, cssClassWhenTrue));
        conditions.Add(new CssClassCondition(() => !condition(), cssClassWhenFalse));
        return this;
    }
    
    public override string ToString()
    {
        var classes = new List<string>();
        foreach (var condition in conditions)
        {
            condition.Build(classes);
        }
        return string.Join(" ", classes);
    }
}
