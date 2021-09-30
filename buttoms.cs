using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoms : MonoBehaviour
{
    public Sprite black, white;
    public GameObject on, off;
    public GameObject playmenu, menu, choice, play, exit, google, sound, restartall, carhero;
    private score SCORE;
    private int sco;
       private void Start()
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
        }
    }
    private void Update()
    {
        if (Time.timeScale == 0f)
        {
            return;
        }
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = white;
    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = black;
    }

    
    public void OnMouseUpAsButton(){
            if (PlayerPrefs.GetString("sound") != "no")
             GameObject.Find("click").GetComponent<AudioSource>().Play();
        switch (gameObject.name)
        {
            case "play":
                SceneManager.LoadScene("play");
                moveobject.ResetValues();
                spauncars.ResetValues();
                break;
            case "google":
                Application.OpenURL("http://google.com");
                break;
            case "exit":
                Application.Quit();
                break;
            case "sound":
                if
                    (PlayerPrefs.GetString("sound") != "no") {
                    PlayerPrefs.SetString("sound", "no");
                    on.SetActive(false);
                    off.SetActive(true);
                }
                else
                {
                    PlayerPrefs.SetString("sound", "yes");
                    on.SetActive(true);
                    off.SetActive(false);
                    
                }
                   break;
            case "restart":
                SceneManager.LoadScene("play");
                Time.timeScale = 1f;
                moveobject.ResetValues();
                spauncars.ResetValues();

                break;
            case "home":
                SceneManager.LoadScene("menu");
                Time.timeScale = 1f;
                break;
            case "menu":
                playmenu.SetActive(true);
                menu.SetActive(false);
                carhero.SetActive(false);
                Time.timeScale = 0f;
                SCORE = GameObject.Find("deletepanel").GetComponent<score>();
                sco = SCORE.count;
                if (PlayerPrefs.GetInt("score") < sco)
                    PlayerPrefs.SetInt("score", sco);
                break;
            case "cont":
                playmenu.SetActive(false);
                menu.SetActive(true);
                carhero.SetActive(true);
                Time.timeScale = 1f;
                GetComponent<SpriteRenderer>().sprite = black;
                break;
                case "restartall":
                choice.SetActive(true);
                play.SetActive(false);
                exit.SetActive(false);
                google.SetActive(false);
                sound.SetActive(false);
                restartall.SetActive(false);
                GetComponent<SpriteRenderer>().sprite = black;
                break;
            case "ok":
                PlayerPrefs.DeleteAll();
                SceneManager.LoadScene("menu");
                break;
            case "cancel":
                GetComponent<SpriteRenderer>().sprite = black;
                choice.SetActive(false);
                play.SetActive(true);
                exit.SetActive(true);
                google.SetActive(true);
                sound.SetActive(true);
                restartall.SetActive(true);
            break;


        }

    }
}


