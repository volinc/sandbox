namespace Taxys.Security.Confirmation
{
    using System;

    /// <summary>
    /// Реализует методы генерации последовательностей случайных символов.
    /// </summary>
    public class CodeGeneratorService
    {
        internal static readonly int PhoneConfirmationCodeLength = 6;

        // MaxLengths.PhoneConfirmationCode задает длину кода подтверждения по телефону. По этой длине
        // вычисляем наименьший и наибольший коды. По этим формулам, для длины 3 наименьшим кодом будет
        // 100 (не 0, и не 1), а наибольшим — 999.
        internal static readonly int MinPhoneCode = (int) Math.Pow(10, PhoneConfirmationCodeLength - 1);
        internal static readonly int MaxPhoneCode = (int) Math.Pow(10, PhoneConfirmationCodeLength) - 1;

        internal readonly Random Random = new Random();

        /// <summary>
        /// Генерирует код подтверждения для телефона. Код короткий, содержит только цифры.
        /// </summary>
        /// <returns>Строка, содержащая случайные цифры.</returns>
        public string GeneratePhoneCode()
        {
            return Random.Next(MinPhoneCode, MaxPhoneCode)
                         .ToString();
        }

        /// <summary>
        /// Генерирует код подтверждения для адреса электронной почты.
        /// </summary>
        /// <returns>GUID.</returns>
        public string GenerateEmailCode()
        {
            return Guid.NewGuid()
                       .ToString("N");
        }
    }
}