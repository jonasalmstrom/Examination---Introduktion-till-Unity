using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpScript : MonoBehaviour
{
    public Transform player;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Kör Warp funktionen
        Warp();
    }

    void Warp()
    {
        //Om skeppet åker utanför skärmen på höger sida så warpar den till andra sidan på samma y position
        if (transform.position.x > 10)
        {
            transform.position = new Vector3(-10f, transform.position.y);
            
        }
        //Om skeppet åker utanför skärmen på vänster sida så warpar den till andra sidan på samma y position
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(10f, transform.position.y);
        }
        //Om skeppet åker utanför på toppen av skärmen så warpar den till botten på samma x position
        if (transform.position.y > 6)
        {
            transform.position = new Vector3(transform.position.x, -6f);
        }
        //Om skeppet åker utanför på botten av skärmen så warpar den till toppen på samma x position
        if (transform.position.y < -6)
        {
            transform.position = new Vector3(transform.position.x, 6f);
        }
    }
}
