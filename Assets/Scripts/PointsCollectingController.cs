using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCollectingController : MonoBehaviour
{
    public static int pointsMax = 0;
    public static int pointsCurrent = 0;
    // Start is called before the first frame update
    private bool taken = false;
    private Light lgt;


    void Start()
    {
        lgt = this.gameObject.GetComponent<Light>();
        pointsMax++;
        print(pointsCurrent + "/" + pointsMax);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && taken == false)
            AddPoint();
            Take();
    }
    void AddPoint()
    {
        pointsCurrent++;
        print(pointsCurrent + "/" + pointsMax);
    }
    void Take()
    {
        taken = true;
        lgt.intensity = 1;
        this.GetComponent<Renderer>().enabled = false;
    }

}
