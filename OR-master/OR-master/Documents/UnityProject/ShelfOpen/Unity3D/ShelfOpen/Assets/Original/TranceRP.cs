using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranceRP : MonoBehaviour
{


    public Vector3 nowposi;
    public Vector3 nowlota;
    private float nowy;
    TextMesh textRPon;
    public GameObject RPCubes;
    public bool tapRP = false;


    // Use this for initialization
    void Start()
    {
        nowposi = new Vector3(0, 0, 0);
        nowlota = new Vector3(0, 0, -90);
        textRPon = RPCubes.GetComponent<TextMesh>();
        tapRP = false;
    }

    // Update is called once per frame
    void Update()
    {
        nowposi = this.transform.localPosition;
        nowy = nowposi.y;
        if (nowposi.y < 0.0)
        {
            textRPon.text = "OFF";
            nowy = -0.5f;
            tapRP = false;
        }
        if (nowposi.y >= 0.0)
        {
            textRPon.text = "ON";
            nowy = 0.5f;
            tapRP = true;
        }

        this.transform.localPosition = new Vector3(0f, nowy, -0.35f);
        this.transform.localEulerAngles = nowlota;
    }
}
