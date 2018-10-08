using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneScript : MonoBehaviour
{

    public SpriteRenderer rend;

    [Header("Movement")]
    public float moveSpeed;

    public float rotateSpeed;

    [Header("Effects")]
    public Color color;

    public TrailRenderer trailRend;

    [Header("Color codes")]
    public float colorCode1;

    public float colorCode2;

    public float colorCode3;

    [Header("Random Spawning")]
    public float xStart;
    public float yStart;

    
    // Use this for initialization
    void Start()
    {
        //Gör så att flygplanet startar som vitt default
        rend.color = color;
        rend.color = Color.white;
        //Randomiserar movementspeed
        moveSpeed = Random.Range(2, 10);
        //Genererar en random x position mellan två värden och en y position lika så
        xStart = Random.Range(-10, 10);
        yStart = Random.Range(-6, 6);
        //Spawnar Skeppet mellan x och y värdet ovan
        transform.position = new Vector3((xStart), (yStart));

       
    }

    // Update is called once per frame
    void Update()
    {
        //Randomiserar en färgkod
        colorCode1 = Random.Range(0f, 1f);
        System.Math.Round(colorCode1, 1);
        //-||-
        colorCode2 = Random.Range(0f, 1f);
        System.Math.Round(colorCode2, 1);
        //-||-
        colorCode3 = Random.Range(0f, 1f);
        System.Math.Round(colorCode3, 1);

        //Gör så att flygplanet rör sig konstant framåt
        transform.Translate(0, moveSpeed * Time.deltaTime, 0, Space.Self);

        //När man trycker på D så svänger skeppet till höger och byter färg till blått
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotateSpeed * Time.deltaTime);
            rend.color = Color.blue;
        }

        //När man trycker på A så svänger skeppet till vänster och byter färg till grönt
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotateSpeed / 2 * Time.deltaTime);
            rend.color = Color.green;
        }

        //När man trycker på S så åker man häflten så snabbt
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, (-moveSpeed / 2) * Time.deltaTime, 0, Space.Self);
        }

        //När man trycker Space så ändras skeppet till en random färg
        if (Input.GetKey(KeyCode.Space))
        {
            rend.color = new Color(colorCode1, colorCode2, colorCode3);
        }

        
    }
}

