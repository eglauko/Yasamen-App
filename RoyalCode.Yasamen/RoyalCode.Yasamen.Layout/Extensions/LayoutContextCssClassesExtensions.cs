﻿
namespace RoyalCode.Yasamen.Layout;

/// <summary>
/// Extensions methods for <see cref="LayoutContext"/> for get css classes 
/// depending on the type of property and its value.
/// </summary>
public static class LayoutContextCssClassesExtensions
{
    public const string IsInteractedClass = "b-menu-interacted";
    public const string IsNotInteractedClass = "b-menu-original";

    public static string GetInteractedCssClass(this LayoutContext context)
        => context.MenuInteracted ? IsInteractedClass : IsNotInteractedClass;
}