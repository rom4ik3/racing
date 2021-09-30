using UnityEngine;


public class click : MonoBehaviour

{
    public GameObject on, off;
    void Start()
    {
        if (gameObject.name == "sound")
        {
            if (PlayerPrefs.GetString("sound") == "yes")
            {
                on.SetActive(true);
                off.SetActive(false);
            }
            else
            {
                on.SetActive(false);
                off.SetActive(true);
            }
            if (GameObject.FindGameObjectsWithTag("audio").Length == 1)
                DontDestroyOnLoad(gameObject);
            else
                Destroy(gameObject);

        }


    }
}
