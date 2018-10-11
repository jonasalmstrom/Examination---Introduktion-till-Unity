using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public float astSpeed;
    public float astRotate;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, -astSpeed * Time.deltaTime, 0, Space.World);

        transform.Rotate(0, 0, -astRotate * Time.deltaTime);

        Warp();
    }

    void Warp()
    {
        //Om asteroiden åker utanför skärmen på höger sida så warpar den till andra sidan på en random y position
        if (transform.position.x > 10)
        {
            transform.position = new Vector3(-10f, Random.Range(-11f, 11f));

        }
        //Om asteroiden åker utanför skärmen på vänster sida så warpar den till andra sidan på en random y position
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(10f, Random.Range(-11f, 11f));
        }
        //Om asteroiden åker utanför på toppen av skärmen så warpar den till botten på en random x position
        if (transform.position.y > 6)
        {
            transform.position = new Vector3(Random.Range(-7f, 7f), -6f);
        }
        //Om asteroiden åker utanför på botten av skärmen så warpar den till toppen på en random x position
        if (transform.position.y < -6)
        {
            transform.position = new Vector3(Random.Range(-7f, 7f), 6f);
        }
    }
}
