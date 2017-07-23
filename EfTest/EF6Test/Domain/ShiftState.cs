namespace EF6Test.Domain
{
    public enum ShiftState : long
    {
        //пауза
        //доступна
        //занята
        //закрыта

        Pause = 10,
        Available = 20,
        Busy = 30,
        Closed = 40,
    }
}
