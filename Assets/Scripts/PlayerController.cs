using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] KeyCode _undoCommandKey = KeyCode.R;
    [SerializeField] KeyCode _changeShapeCommandKey = KeyCode.Q;
    [SerializeField] Sprite[] _characterSprites;
    [SerializeField] SpriteRenderer _spriteRenderer;

    CommandStack _commandStack = new CommandStack();
    

    private void Update()
    {
        DetectMovement();
        DetectShapeChange();
        DetectUndoInput();
    }

    private void DetectMovement()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _commandStack.ExecuteCommand(new MoveCommand(transform,Vector2.up));
        }else if (Input.GetKeyDown(KeyCode.A))
        {
            _commandStack.ExecuteCommand(new MoveCommand(transform,Vector2.left));
        }else if (Input.GetKeyDown(KeyCode.S))
        {
            _commandStack.ExecuteCommand(new MoveCommand(transform,Vector2.down));
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            _commandStack.ExecuteCommand(new MoveCommand(transform,Vector2.right));
        }

    }

    private void DetectShapeChange()
    {
        if (Input.GetKeyDown(_changeShapeCommandKey))
        {
            _commandStack.ExecuteCommand(new ChangeShapeCommand(_spriteRenderer,_characterSprites));
        }
    }
    

    private void DetectUndoInput()
    {
        if (Input.GetKeyDown(_undoCommandKey))
        {
            _commandStack.UndoLastCommand();
        }
    }
}
