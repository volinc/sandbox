using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Forms.Driving.Extensions
{
    public static class ArgumentExceptionExtensions
    {
        /// <summary>
        /// Выбрасывает исключение <see cref="ArgumentNullException"/>, если параметр равен <c>null</c>.
        /// </summary>
        /// <typeparam name="T">Тип параметра.</typeparam>
        /// <param name="argument">Параметр.</param>
        /// <param name="argumentName">Имя параметра.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ThrowIfNull<T>(this T argument, string argumentName)
            where T : class
        {
            if (argument == null)
                throw new ArgumentNullException(argumentName);

            return argument;
        }

        /// <summary>
        /// Выбрасывает исключение <see cref="ArgumentException"/>, если параметр есть <c>null</c> или пустая строка.
        /// </summary>
        /// <param name="argument">Параметр.</param>
        /// <param name="argumentName">Имя параметра.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ThrowIfNullOrWhitespace(this string argument, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(argument))
                throw new ArgumentException("The string argument cannot be null or whitespace.", argumentName);

            return argument;
        }

        /// <summary>
        /// Выбрасывает исключение <see cref="ArgumentException"/>, если параметр является пустой строкой или
        /// содержит только пробельные символы: пробел, табуляция, новая строка и т.д.
        /// </summary>
        /// <param name="argument">Параметр.</param>
        /// <param name="argumentName">Имя параметра.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ThrowIfWhitespace(this string argument, string argumentName)
        {
            if (argument?.Trim() == string.Empty)
                throw new ArgumentException("The string argument cannot be whitespace.", argumentName);

            return argument;
        }

        /// <summary>
        /// Выбрасывает исключение <see cref="ArgumentException"/>, если параметр не соответствует
        /// заданному регулярному выражению.
        /// </summary>
        /// <param name="argument">Параметр.</param>
        /// <param name="argumentName">Имя параметра.</param>
        /// <param name="pattern">Регулярное выражение.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ThrowIfNotRegexMatch(this string argument, string argumentName, string pattern)
        {
            if (!Regex.IsMatch(argument, pattern))
                throw new ArgumentException($"The string argument is not match {pattern} (value: \"{argument}\").", argumentName);

            return argument;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ThrowIfNotValidCondition<T>(this T argument, string argumentName, Func<bool> condition)
        {
            if (condition == null)
                throw new ArgumentNullException(nameof(condition));

            if (!condition.Invoke())
                throw new ArgumentException("The argument is not valid for condition.", argumentName);

            return argument;
        }
    }
}