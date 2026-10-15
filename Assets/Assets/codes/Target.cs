
using UnityEngine;

public class Target : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    public void Hit()
    {
        if (gameManager != null)
        {
            gameManager.TargetDestroyed();
        }

        Destroy(gameObject);
    }
}
