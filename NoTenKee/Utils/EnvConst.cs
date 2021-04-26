using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleToAttribute("NoTenKeeTest")]

namespace NoTenKee.Utils
{
    public static class EnvConst
    {
        public const int PARAM_MIN = 3;
        public const int PARAM_MAX = 4;
        public const String XML_ENV = "path";
        public const String TEMPLATE_PATH = "template_path";
        public const String TEMPORARY_PATH = "temporary_path";
        public const String OUTPUT_PATH = "output_path";
        public const String DIR_DELIMITER = @"\";
    }
}
