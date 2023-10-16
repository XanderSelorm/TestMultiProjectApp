using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using TestMultiApp;
using TestClassLibrary;

namespace TestMultiApp
{
    public partial class App
    {
        private List<System.Reflection.Assembly> extraAssemblies = new List<System.Reflection.Assembly>
        {
            typeof(TestClassLibrary.ExampleJsInterop).Assembly,
        };
    }
}