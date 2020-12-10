using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleToAttribute("NoTenKeeTest")]

namespace NoTenKee.Utils
{
    public static class EnvConst
    {
        public const int PARAM_MIN = 2;
        public const int PARAM_MAX = 3;
        public const String DIR_DELIMITER = @"\";
        public const String TEMPLATE_PATH = "template";
        public const String TEMPORARY_PATH = "temporary";
        public const String OUTPUT_PATH = "outputPath";
    }
}
