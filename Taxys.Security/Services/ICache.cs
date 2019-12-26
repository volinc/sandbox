namespace Taxys.Security.Services
{
    using System;
    using System.Threading.Tasks;
    using Taxys.Domain;

    /// <summary>
    /// Описывает кеш.
    /// </summary>
    public interface ICache
    {
        /// <summary>
        /// Асинхронно добавляет указанные ключ и значение (или обновляет значение и переиод времени) в кэш на указанный период времени.
        /// </summary>
        /// <typeparam name="TValue">Тип значения.</typeparam>
        /// <param name="key">Ключ.</param>
        /// <param name="value">Значение.</param>
        /// <param name="lifeTime">Время жизни значений.</param>
        Task AddOrUpdateAsync<TValue>(string key, TValue value, TimeSpan? lifeTime = null);

        /// <summary>
        /// Асинхронно добавляет указанные ключ и значение в кэш на указанный период времени, если их там нет.
        /// </summary>
        /// <typeparam name="TValue">Тип значения.</typeparam>
        /// <param name="key">Ключ.</param>
        /// <param name="value">Значение.</param>
        /// <param name="lifeTime">Время жизни значений.</param>
        /// <returns><c>true</c>, если ключ и значение добавлены; <c>false</c>, если они уже есть в кэше.</returns>
        Task<bool> TryAddAsync<TValue>(string key, TValue value, TimeSpan? lifeTime = null);

        /// <summary>
        /// Асинхронно возвращает значение, связанное с заданным ключом.
        /// </summary>
        /// <typeparam name="TValue">Тип значения.</typeparam>
        /// <param name="key">Ключ значения, которое необходимо получить.</param>
        /// Метод возвращает значение, связанное с указанным ключом, если он найден; в противном случае —
        /// значение по умолчанию для запрашиваемого типа.
        /// <returns><c>true</c>, если кэш содержит элемент с указанным ключом; в противном случае — <c>false</c>.</returns>
        Task<ConditionalValue<TValue>> TryGetValueAsync<TValue>(string key);

        /// <summary>
        /// Асинхронно удаляет значение из кэша.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task RemoveAsync(string key);

        /// <summary>
        /// Асинхронно удаляет значение из кэша.
        /// </summary>
        /// <param name="key">Ключ значение для удаления.</param>        
        /// Метод возвращает значение, связанное с указанным ключом, если он найден; в противном случае —
        /// значение по умолчанию для типа параметра.
        /// <returns><c>true</c>, если кэш содержал элемент с указанным ключом; в противном случае — <c>false</c>.</returns>
        Task<ConditionalValue<TValue>> TryRemoveAsync<TValue>(string key);
    }
}
