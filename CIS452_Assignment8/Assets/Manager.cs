using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 60f;

    public Text timer;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timer.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            SceneManager.LoadScene(0);
        }

        GameObject[] apples;
        apples = GameObject.FindGameObjectsWithTag("Apple");
        GameObject[] bananas;
        bananas = GameObject.FindGameObjectsWithTag("Orange");

        if (apples.Length == 0 && bananas.Length == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
