using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
    public Text TimerText;
    public bool playing;
    private float Timer;
    public Button NextLevel;
    GameObject button;
    void Start()
    {
        button = GameObject.Find("Button");
    }
    void Update()
    {

        if (playing == true)
        {
            TimerText.fontSize = 20;
            Timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(Timer / 60F);
            int seconds = Mathf.FloorToInt(Timer % 60F);
            int milliseconds = Mathf.FloorToInt((Timer * 100F) % 100F);
            TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
            button.SetActive(false);   

        }
        else
        {
            TimerText.fontSize = 40;
            button.SetActive(true);   
        }

    }

}