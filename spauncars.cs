using UnityEngine;
using System.Collections;

public class spauncars : MonoBehaviour{
    public GameObject[] cars;
    public static float second = 2.5f;
     private float[] position = { -1.47f, -0.51f, 0.58f, 1.61f };
    private score SCORE;
    public int sco;
    public int b;
      private void Start()
    {
       b = 0;
       SCORE = GameObject.Find("deletepanel").GetComponent<score>();         
        StartCoroutine(spawn());
    }
    IEnumerator spawn()
    {
        while (true)
        {
            sco = SCORE.a;
           if (sco > b && second-0.5 > 0)
            {
                second -= 0.2f;
            }
           {
                    Instantiate(
                    cars[Random.Range(0, cars.Length)],
                    new Vector3(position[Random.Range(0, 4)], 7f, 0),
                    Quaternion.identity
                    );
            }
              yield return new WaitForSeconds(second);
              b = sco;
        }
    }
    public static void ResetValues()
    {
        second = 2.8f;

    }
}
    
     

