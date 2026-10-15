
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int targetsHit = 0;
    public int totalTargets = 4;

    public float timeLeft = 10f;
    public TMP_Text timerText;

    private bool gameOver = false;

    void Update()
    {
        if (gameOver) return;

        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            timeLeft = 0;
            gameOver = true;
            Debug.Log("TIME'S UP! YOU LOSE!");
        }

        timerText.text = Mathf.CeilToInt(timeLeft).ToString();
    }

    public void TargetDestroyed()
    {
        if (gameOver) return;

        targetsHit++;

        Debug.Log("Targets Hit: " + targetsHit + "/" + totalTargets);

        if (targetsHit >= totalTargets)
        {
            gameOver = true;
            Debug.Log("YOU WIN!");
        }
    }
}
