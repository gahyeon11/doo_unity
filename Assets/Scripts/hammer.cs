using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammer : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Debug.Log("GAME START");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("doo")){
      
            score += 1;
            Debug.Log("Á¡¼ö" + "+" + score);
        }
        if(score > 19)
        {
            Debug.Log("GAME OVER!");
            score = 0;
        }
    }
}
