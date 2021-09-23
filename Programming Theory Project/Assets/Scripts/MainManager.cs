using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public static MainManager instance;

    [SerializeField]
    InputField usernameText;

    public int score { get; set; }
    public string userName { get; set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(instance);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    private void OnEnable()
    {
        BulletController.onScoreUpdate += UpdateScore;
    }

    private void OnDisable()
    {
        BulletController.onScoreUpdate -= UpdateScore;
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void StartGame()
    {
        userName = usernameText.text;
        SceneManager.LoadScene(1);
    }

    void UpdateScore(int addition)
    {
        score += addition;
    }
}
