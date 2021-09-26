using System.Collections;
using System.Collections.Generic;

public class CommandStack
{
    private Stack<ICommand> _commandsHistory = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commandsHistory.Push(command);
    }

    public void UndoLastCommand()
    {
        if (_commandsHistory.Count <= 0)
            return;

        _commandsHistory.Pop().Undo();
    }
}
