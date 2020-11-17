using Microsoft.AspNetCore.Components;

namespace H3x.BlazorBulmaComponents
{
    public abstract class BulmaComponentBase : ComponentBase
    {
        [CascadingParameter]
        private ForwardRef Me { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (Me != null)
                Me.Current = this;
        }
    }
}
