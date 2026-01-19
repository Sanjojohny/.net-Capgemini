using System;

namespace Example1;

public class Door
{
    public delegate void Notify();
    public event Notify DoorOpened;
    public event Notify DoorClosed;
    private void Open()
    {
        System.Console.WriteLine("door is open");
    }
    private void Close()
    {
        System.Console.WriteLine("door is closd");

    }
    public void DoorOperations(bool open)
    {
        if (open)
        {
            DoorOpened+=Open;
        }
        else
        {
            DoorClosed+=Close;
        }
        DoorOpened?.Invoke();
        DoorClosed?.Invoke();
    }

}
