using System;

namespace Forms.Driving.Extensions
{
    /// <summary>
    /// Реализует методы расширения для класса <see cref="UriBuilder"/>.
    /// </summary>
    public static class UriBuilderExtensions
    {
        /// <summary>
        /// Меняет путь в заданном UriBuilder. Если путь был пустой, добавляет его.
        /// </summary>
        /// <param name="uriBuilder">Старый UriBuilder.</param>
        /// <param name="path">Новый путь.</param>
        /// <returns>Новый UriBuilder с новым путем.</returns>
        public static UriBuilder SetPath(this UriBuilder uriBuilder, string path)
        {
            var uri = uriBuilder.ThrowIfNull(nameof(uriBuilder))
                                .Uri;

            var newUriBuilder = new UriBuilder(uri);

            if (path.StartsWith("/"))
                newUriBuilder.Path = path;
            else
                newUriBuilder.Path += path;

            return newUriBuilder;
        }
    }
}