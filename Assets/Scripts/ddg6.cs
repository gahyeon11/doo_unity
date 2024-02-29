using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ddg6 : MonoBehaviour
{
    public float xPos, yPos, zPos;
    public float plus;
    // Start is called before the first frame update
    void Start()
    {
        xPos = -14f;
        yPos = 20f;
        zPos = -2f;
        plus = Random.Range(0.005f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        if (yPos > 22 || yPos < 15)
        {           
            plus = plus * -1;
        }
        yPos = yPos + plus;
        transform.position = new Vector3(xPos, yPos, zPos);
        if (yPos < 15)
        {
            zPos = zPos + 10;
        }
        if (zPos > -2)
        {
            zPos = -22;
        }

    }
}
