using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeScript : MonoBehaviour
{

    public Text TimeText;
    public float TimeLeft = 250f;


    // Use this for initialization
    void Start()
    {
        TimeText.text = "TimeLeft: " + TimeLeft;
    }

    public void Update()
    {
        TimeLeft -= Time.deltaTime;

        if (TimeLeft > 0 )
        {
            TimeText.text = "Time: " + (int)TimeLeft;
        }
        else
        {
            SceneManager.LoadScene("lose");
        }
    }
}
