using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace EF6Test
{
    public static class ValidationExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ThrowIfNull<T>(this T argument, string argumentName)
            where T : class
        {
            if (argument == null)
                throw new ArgumentNullException(argumentName);

            return argument;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ThrowIfNullOrWhitespace(this string argument, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(argument))
                throw new ArgumentException("The string argument cannot be null or whitespace.", argumentName);

            return argument;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ThrowIfWhitespace(this string argument, string argumentName)
        {
            if (argument?.Trim() == string.Empty)
                throw new ArgumentException("The string argument cannot be whitespace.", argumentName);

            return argument;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ThrowIfNotRegexMatch(this string argument, string argumentName, string pattern)
        {
            if (!Regex.IsMatch(argument, pattern))
                throw new ArgumentException($"The string argument is not match {pattern} (value: \"{argument}\").",
                    argumentName);

            return argument;
        }
    }
}