using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
   public GameObject lost;
   public GameObject menu ;
   public bool lose;
   private score SCORE;
    private int sco;
    
     private   void Start()
    {
         SCORE = GameObject.Find("deletepanel").GetComponent<score>();
        }
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Vector3 poss = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                transform.position = new Vector3(poss.x, transform.position.y, transform.position.z);
            }
            sco = SCORE.count;
            if (lose)
                Playerlose();
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("car"))
        {
     
           Destroy(gameObject);
           Playerlose();
      }
    }          
    void Playerlose()
    {
       if (PlayerPrefs.GetInt("score") < sco)
       PlayerPrefs.SetInt("score", sco);
        Time.timeScale = 0f;
         menu.SetActive(false);
         lost.SetActive(true);
        if (PlayerPrefs.GetString("sound") != "no")
            GameObject.Find("lost").GetComponent<AudioSource>().Play();
    }

}
