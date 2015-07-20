using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Web;

namespace Bluebeam
{
    public static class SecureStringExtensions
    {
        public static string ToUnsecureString(this SecureString source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            IntPtr secureString = IntPtr.Zero;

            try
            {
                secureString = Marshal.SecureStringToGlobalAllocUnicode(source);
                return Marshal.PtrToStringUni(secureString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(secureString);
            }
        }

        public static SecureString ToSecureString(this string source)
        {
            if (null == source)
                throw new ArgumentNullException("source");

            var result = new SecureString();

            foreach (char c in source)
                result.AppendChar(c);

            result.MakeReadOnly();

            return result;
        }
    }
}