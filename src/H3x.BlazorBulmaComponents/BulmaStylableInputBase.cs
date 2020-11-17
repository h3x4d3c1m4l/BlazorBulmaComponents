using Microsoft.AspNetCore.Components;

namespace H3x.BlazorBulmaComponents
{
    public class BulmaStylableInputBase : BulmaInputBase
    {
        [Parameter]
        public BulmaColors Color { get; set; } = BulmaColors.Primary;

        [Parameter]
        public BulmaSizes Size { get; set; } = BulmaSizes.Normal;
    }
}
