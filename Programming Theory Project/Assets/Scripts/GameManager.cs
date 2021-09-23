using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Text scoringText;

    [SerializeField]
    Text usernameText;

    [SerializeField]
    Enemy[] enemies;

    [SerializeField]
    float maxRightBorder = 3f;

    [SerializeField]
    float maxLeftBorder = -3f;

    [SerializeField]
    float maxUpBorder = 4f;

    [SerializeField]
    float maxBottomBorder = -2f;

    bool isGameOn { get; set; }

    int randomEnemySelected;

    int gameLevel { get; set; }
    int maxLevels { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        //set score text
        scoringText.text = MainManager.instance.score.ToString();
        usernameText.text = MainManager.instance.userName;

        isGameOn = true;
        gameLevel = 1;
        maxLevels = 9;
        StartCoroutine(SpawnEnemies());
    }

    private void Update()
    {
        scoringText.text = "Score : " + MainManager.instance.score.ToString();
    }

    IEnumerator SpawnEnemies()
    {
        while (isGameOn)
        {
            
            randomEnemySelected = Random.Range(0, enemies.Length);
            float x = Random.Range(maxLeftBorder, maxRightBorder);
            float y = Random.Range(maxBottomBorder, maxUpBorder);
            float z = 20f;
            Vector3 instantiatePosition = new Vector3(x, y, z);
            Instantiate(enemies[randomEnemySelected], instantiatePosition, enemies[randomEnemySelected].transform.rotation);
            yield return new WaitForSeconds(1);
        }
    }

    
}
