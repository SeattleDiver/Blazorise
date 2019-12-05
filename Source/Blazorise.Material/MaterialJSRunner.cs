#region Using directives
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;
#endregion

namespace Blazorise.Material
{
    public partial class MaterialJSRunner : Blazorise.JSRunner
    {
        public MaterialJSRunner( IJSRuntime runtime )
               : base( runtime )
        {
        }

        public override ValueTask<bool> InitializeTooltip( string elementId, ElementReference elementRef )
        {
            return runtime.InvokeAsync<bool>( $"blazoriseMaterial.tooltip.initialize", elementId, elementRef );
        }

        public override ValueTask<bool> ActivateDatePicker( string elementId, string formatSubmit )
        {
            return runtime.InvokeAsync<bool>( $"blazoriseMaterial.activateDatePicker", elementId, formatSubmit );
        }

        public override ValueTask<bool> OpenModal( ElementReference elementRef, string elementId )
        {
            return runtime.InvokeAsync<bool>( $"blazoriseMaterial.modal.open", elementRef, elementId );
        }

        public override ValueTask<bool> CloseModal( ElementReference elementRef, string elementId )
        {
            return runtime.InvokeAsync<bool>( $"blazoriseMaterial.modal.close", elementRef, elementId );
        }
    }
}
