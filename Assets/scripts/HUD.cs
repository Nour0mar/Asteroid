using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField]
    Text Score;
    public static float ElapsedSecond = 0.0f;
    bool GameTimerIsRunning = true;
    // Start is called before the first frame update
    void Start()
    {
        Score.GetComponent<Text>();
        Score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (GameTimerIsRunning==true)
        {
            ElapsedSecond +=Time.deltaTime;
            Score.text ="Time :" +Mathf.Round(ElapsedSecond);
        }
        
    }
    public void StopGameTimer()
    {
        GameTimerIsRunning = false;
    }
}
