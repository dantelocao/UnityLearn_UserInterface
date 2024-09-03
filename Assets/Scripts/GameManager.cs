using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float score = 0;
    public List<GameObject> targets;
    private float spawnRate = 1.8f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTargets());
        UpdateScore(score);
    }

    IEnumerator SpawnTargets()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(float scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
