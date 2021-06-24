using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoalController : MonoBehaviour
{
    public StopWatch Timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider other)
     {
     if(other.gameObject.tag=="Player")
    Contact();
    }
    void Contact()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Timer.playing = false;

    }
}
