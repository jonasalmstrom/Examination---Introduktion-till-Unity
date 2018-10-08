using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float time = 0;

    // Use this for initialization
    void Start()
    {
        //Gör så att funktionen "Timer" startar om 1 sekund (men det går bra eftersom det startar på noll) och sedan kör funktionen en gång varje sekund
        InvokeRepeating("Timer", 1, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Tar variabeln "time" och sedan lägger till 1 varje sekund
        time += 1 * Time.deltaTime;
    }

    void Timer()
    {
        //Skriver ut variabeln i konsollen och "time.ToString("f0"" gör så att den bara skriver ut i int form
        Debug.Log(string.Format("Time: " + time.ToString("f0")));
    }
}
