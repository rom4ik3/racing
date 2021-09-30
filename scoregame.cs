using UnityEngine;
using UnityEngine.UI;

public class scoregame : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt("score").ToString();
    }
}
