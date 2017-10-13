using Forms.Driving.Data;
using Forms.Driving.Domain.Entities;

namespace Forms.Driving.Domain
{
    /// <summary>
    /// Описывает интерфейс уведомителя, который показывает пользователю «системные» уведомления.
    /// </summary>
    public interface INotifier
    {
        /// <summary>
        /// Уведомляет пользователя о неактивном состоянии приложения.
        /// </summary>
        void NotifyInactive();

        /// <summary>
        /// Уведомляет пользователя о недоступном состоянии приложения.
        /// </summary>
        void NotifyUnaccessible();

        /// <summary>
        /// Уведомляет пользователя о доступном состоянии приложения.
        /// </summary>
        void NotifyAccessible();

        /// <summary>
        /// Уведомляет пользователя о новом предложении.
        /// </summary>
        /// <param name="offer">Оффер.</param>
        void NotifyOffer(Offer offer);

        /// <summary>
        ///  Уведомляет пользователя об отмене заказа.
        /// </summary>
        /// <param name="order"></param>
        void NotifyOrderClosed(Order order);

        /// <summary>
        /// Уведомляет пользователя о новом комментарии к заказу.
        /// </summary>
        /// <param name="orderComment">Комментарий к заказу.</param>
        void NotifyNewComment(OrderCommentData orderComment);

        /// <summary>
        /// Отменяет уведомление о новом предложении пассажира.
        /// </summary>
        void CancelOfferNotification();
    }
}