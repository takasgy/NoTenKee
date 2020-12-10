using System;
using System.Collections.Generic;
using System.Text;

namespace NoTenKee.Utils
{
    public class EnvUtil
    {
        public static String GetValue(String key)
        {
            // TODO プロパティの値取得処理
            switch (key)
            {
                case EnvConst.TEMPLATE_PATH:
                    return @"C:\NoTenKee\template" + EnvConst.DIR_DELIMITER;
                case EnvConst.OUTPUT_PATH:
                    return @"C:\NoTenKee\output" + EnvConst.DIR_DELIMITER;
                case EnvConst.TEMPORARY_PATH:
                    return @"C:\NoTenKee\temporary" + EnvConst.DIR_DELIMITER;
                default:
                    return null;
            }
        }

    }
}
