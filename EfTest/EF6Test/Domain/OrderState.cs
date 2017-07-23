namespace EF6Test.Domain
{
    public enum OrderState : long
    {
        //Создан
        //Запланирован
        //Поиск
        //Провален
        //Доезд
        //Ожидание
        //Исполнение
        //Завершен
        //Закрыт

        Created = 10,
        Scheduled = 20,
        Searching = 30,
        Failed = 40,
        Arrival = 50,
        Waiting = 60,
        Execution = 70,
        Finished = 80,
        Closed = 90,
    }
}
