using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class jogador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxisRaw("Vertical") > 0) && (transform.position.y < 8.5))
        {
            transform.Translate(0, 0.01f, 0);
        }
        else if ((Input.GetAxisRaw("Vertical") < 0) && (transform.position.y > 2.5))
        {
            transform.Translate(0, -0.01f, 0);
        }

    }
}
