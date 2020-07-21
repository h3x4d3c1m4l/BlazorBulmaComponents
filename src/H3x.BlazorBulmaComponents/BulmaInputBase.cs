using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace H3x.BlazorBulmaComponents
{
    public class BulmaInputBase : ComponentBase
    {
        [Parameter]
        public bool IsDisabled { get; set; }
    }
}
