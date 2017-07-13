using System;
using System.Globalization;

namespace RcisSchoolBell.lib
{
  public static  class Extentions
    {
      public static string ToShortDots(this string str,int length)
      {
          return str.Length > length ? string.Concat(str.Substring(0, length), "...") : str;
      }

      public static short ToInt(this string value)
      {
          if (value == null)
              return 0;
          return short.Parse(value, CultureInfo.CurrentCulture);
      }

      public static DateTime ToTime(this string value)
      {
          if (value == null)
              return new DateTime(0L);
          return DateTime.Parse(value,CultureInfo.CurrentCulture);
      }
    }
}
