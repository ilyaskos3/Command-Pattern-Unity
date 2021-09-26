using UnityEngine;

class MoveCommand : ICommand
{
    private Vector2 _moveVector;
    private Transform _moveObj;
    
    public MoveCommand(Transform moveObj,Vector2 moveVector)
    {
        _moveObj = moveObj;
        _moveVector = moveVector;
    }
    
    public void Execute()
    {
        Debug.Log("moving player by : " + _moveVector);
        _moveObj.position += (Vector3)_moveVector;
    }

    public void Undo()
    {
        Debug.Log("Undo moving player by : " + _moveVector);
        _moveObj.position -= (Vector3)_moveVector;
    }
}