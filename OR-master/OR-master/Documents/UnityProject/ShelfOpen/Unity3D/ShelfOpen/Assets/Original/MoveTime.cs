using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTime : MonoBehaviour
{

    private float barY;
    private float newY;
    public bool movebar;

    // Use this for initialization
    void Start()
    {
        barY = this.transform.localPosition.y;
        movebar = false;
        //barY = this.transform.localPosition.y;
        //barZ = this.transform.localPosition.z;
    }

    // Update is called once per frame
    //バーが動かされたら
    void Update()
    {
        newY = this.transform.localPosition.y;

        if (newY != barY && movebar == false)
        {
            movebar = true;
        }
        barY = this.transform.localPosition.y;
    }
}
