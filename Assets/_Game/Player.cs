using _Game;
using _Game.ChuongScripts;
using ChuongCustom;
using UnityEngine;

public class Player : Singleton<Player>
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private MonoMovement monoMovement;
    [SerializeField] private float time;

    private void Start()
    {
        monoMovement.Move(transform, 0f, 0);
        _renderer.sprite = SkinDataManager.Instance.CurrentSkin;
    }

    public void MoveDown()
    {
        monoMovement.StopMove();
        monoMovement.MoveNext(transform, time, false);
    }

    public void MoveUp()
    {
        monoMovement.StopMove();
        monoMovement.MoveBack(transform, time, false);
    }
}
