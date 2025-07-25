using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] float CollisionCooldown = 1f;
    [SerializeField] float adjustChangeMoveSpeedAmount = -2f;
    const string hitString = "Hit";
    float cooldownTimer = 0f;

    LevelGenerator levelGenerator;
    void Start()
    {
        levelGenerator = FindFirstObjectByType<LevelGenerator>();
    }
    void Update()
    {
        cooldownTimer += Time.deltaTime;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (cooldownTimer < CollisionCooldown) return;

        levelGenerator.ChangeChunkMoveSpeed(adjustChangeMoveSpeedAmount);
        animator.SetTrigger(hitString);
        cooldownTimer = 0;
    }
}
