using Microsoft.AspNetCore.Components;

namespace H3x.BlazorBulmaComponents
{
    public class BulmaInputBase : ComponentBase
    {
        [Parameter]
        public bool IsDisabled { get; set; }
    }
}
