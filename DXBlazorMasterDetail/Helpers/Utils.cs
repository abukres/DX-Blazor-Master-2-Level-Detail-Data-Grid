using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace DXBlazorMasterDetail.Helpers
{
    public static class Utils
    {
        static IWebHostEnvironment _webHostEnvironment;

        public static void Initialize(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public static IWebHostEnvironment GetWebHostEnvironment()

        {
            return _webHostEnvironment;
        }
    }
}
