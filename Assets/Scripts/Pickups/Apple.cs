using UnityEngine;

public class Apple : PickUp
{
    LevelGenerator levelGenerator;
    [SerializeField] float adjustChangeMoveSpeedAmount = 3f;

    void Start()
    {
        levelGenerator = FindAnyObjectByType<LevelGenerator>();
    }
    protected override void OnPickup()
    {
        levelGenerator.ChangeChunkMoveSpeed(adjustChangeMoveSpeedAmount);
    }
}
