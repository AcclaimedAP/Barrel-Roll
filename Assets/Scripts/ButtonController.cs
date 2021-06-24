using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonController : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PointsCollectingController.pointsMax = 0;
        PointsCollectingController.pointsCurrent = 0;

    }
}
