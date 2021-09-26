using UnityEngine;

class ChangeShapeCommand : ICommand
{
    private SpriteRenderer _spriteRenderer;
    private Sprite[] _sprites;
    private Sprite _previousSprite;

    public ChangeShapeCommand(SpriteRenderer spriteRenderer, Sprite[] sprites)
    {
        _spriteRenderer = spriteRenderer;
        _sprites = sprites;
    }
    
    public void Execute()
    {
        _previousSprite = _spriteRenderer.sprite;
        int randomIndex = Random.Range(0, _sprites.Length);
        _spriteRenderer.sprite = _sprites[randomIndex];
        Debug.Log("changing shape to" + _sprites[randomIndex].name);
    }

    public void Undo()
    {
        _spriteRenderer.sprite = _previousSprite;
        Debug.Log("changing shape to" + _previousSprite.name);
    }
}