using System;
using CommandPattern;

public class CommandMain : IPatternMain
{
    private Queue<ICommand> commands = new(); //fifo
    private Stack<ICommand> previous = new(); //lifo
    
    public void Run()
    {
        GarageDoor garageDoor = new GarageDoor();
        LightSwitch lightSwitch = new LightSwitch();
        
        commands.Enqueue(new TurnOnLightSwitch(lightSwitch));
        commands.Enqueue(new OpenGarageDoor(garageDoor));
        
        //do all commands
        while (commands.Count > 0)
        {
            var command = commands.Dequeue();
            command.Execute();
            previous.Push(command);
        }
        
        //undo all commands
        while (previous.Count > 0)
        {
            var command = previous.Pop();
            command.Undo();
        }
    }
}