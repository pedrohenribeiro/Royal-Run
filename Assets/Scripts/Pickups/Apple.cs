using UnityEngine;

public class Apple : PickUp
{
    LevelGenerator levelGenerator;
    [SerializeField] float adjustChangeMoveSpeedAmount = 3f;

    public void Init(LevelGenerator levelGenerator)
    {
        this.levelGenerator = levelGenerator;
    }

    protected override void OnPickup()
    {
        levelGenerator.ChangeChunkMoveSpeed(adjustChangeMoveSpeedAmount);
    }
}
