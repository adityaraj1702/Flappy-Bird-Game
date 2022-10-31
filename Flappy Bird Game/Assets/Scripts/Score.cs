using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    //public GameObject scorevalue;
    // Start is called before the first frame update
    private void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Score : " + score.ToString();
        //scorevalue.GetComponent<UnityEngine.UI.Text>().text = score.ToString();

    }
}
