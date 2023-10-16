using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using TestBlazorMaui;

namespace TestBlazorMaui
{
    public partial class Main
    {
        private List<System.Reflection.Assembly> extraAssemblies = new List<System.Reflection.Assembly>
        {
            typeof(TestClassLibrary.ExampleJsInterop).Assembly,
        };
    }
}