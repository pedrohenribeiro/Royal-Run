using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] float chedckpointTimeExtension = 5f;
    GameManager gameManager;

    const string playerString = "Player";

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerString))
        {
            gameManager.IncreaseTime(chedckpointTimeExtension);
        }
    }
}
