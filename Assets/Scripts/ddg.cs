using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ddg : MonoBehaviour
{
    public float xPos, yPos, zPos; //Pos�� �δ����� ��ġ
    public float plus;



       void Start()
    {
        xPos = 8.5f;

        yPos = 20f;
        
        zPos = -22f;
        plus = Random.Range(0.008f, 0.02f);



        
    }

    // Update is called once per frame
    void Update()
    {
        if(yPos > 22 || yPos < 15)
        {
            plus = plus * -1;
        }
            yPos = yPos + plus;

        transform.position = new Vector3(xPos, yPos, zPos);
        if (yPos < 15) {
            zPos = zPos + 10;
        }
        if(zPos > -2)
        {
            zPos = -22;
        }

    }
}
