using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Forms.Helpers
{
    public static class StoreHelper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string GeneratePropertyKey<T>(this T ownerInstance, string propertyName)
        {
            return $"{typeof(T).FullName}.{propertyName}";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string GeneratePropertyKey(Type ownerType, string propertyName)
        {
            return $"{ownerType.FullName}.{propertyName}";
        }
    }
}
