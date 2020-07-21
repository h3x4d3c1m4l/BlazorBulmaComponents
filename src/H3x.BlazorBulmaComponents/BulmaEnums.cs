using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace H3x.BlazorBulmaComponents
{
    public enum BulmaColors
    {
        Primary,
        Link,
        Info,
        Success,
        Warning,
        Danger
    }

    public enum BulmaSizes
    {
        Small,
        Normal,
        Medium,
        Large
    }

    static class Extensions
    {
        public static string ToCssClass(this BulmaColors color) =>
            color switch
            {
                BulmaColors.Primary => "is-primary",
                BulmaColors.Link    => "is-link",
                BulmaColors.Info    => "is-info",
                BulmaColors.Success => "is-success",
                BulmaColors.Warning => "is-warning",
                BulmaColors.Danger  => "is-danger",
                _                   => string.Empty,
            };

        public static string ToCssClass(this BulmaSizes color) =>
            color switch
            {
                BulmaSizes.Small    => "is-small",
                BulmaSizes.Normal   => "is-normal",
                BulmaSizes.Medium   => "is-medium",
                BulmaSizes.Large    => "is-large",
                _                   => string.Empty,
            };
    }
}
