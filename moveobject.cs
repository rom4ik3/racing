using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class moveobject : MonoBehaviour
{
    public static float SPEED = 2.8f;
    public score SCORE;
    private int sco;
    private int b;
    
   void Start()
    {
     b = 0;
     SCORE = GameObject.Find("deletepanel").GetComponent<score>();
    }
    private void FixedUpdate()
    {
     sco = SCORE.a;
    if (sco > b)
    SPEED += 0.05f;
    transform.Translate(Vector3.down * SPEED * Time.fixedDeltaTime);
    b = sco;
    }
    public static void ResetValues()
    {
        SPEED = 2.8f;
        
    }
}
    

