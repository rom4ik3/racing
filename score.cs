using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
   public Text scoreone;
    public int count;
    public int a;
       public void Start()
    {
        count = 0;
        a = 0;
    }
    
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("car"))
        {
           count++;
           Destroy(collision.gameObject);
           if (PlayerPrefs.GetString("sound") != "no")
                GameObject.Find("add").GetComponent<AudioSource>().Play();
            scoreone.text = count.ToString();
            
           }
                a = count / 2;
                Mathf.FloorToInt(a);
     }
       }
