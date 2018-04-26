using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public int timeLength;
    public Health healthScript;
    public Text timeText;


    private void Start()
    {
        healthScript = GetComponent<Health>();
        StartCoroutine(TimeCounterOne());
    }

    private void Update()
    {
        timeText.text = "Time: " + timeLength;
    }

    IEnumerator TimeCounterOne()
    {
        yield return new WaitForSeconds(1.0f);
        TimeKeeper();
        yield return StartCoroutine(TimeCounterTwo());
    }
    IEnumerator TimeCounterTwo()
    {
        yield return new WaitForSeconds(1.0f);
        TimeKeeper();
        yield return StartCoroutine(TimeCounterOne());
    }

    public void TimeKeeper()
    {
        timeLength--;

        if(timeLength == 0)
        {
            healthScript.Die();
        }
    }
}
