using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserDestroyer : MonoBehaviour
{

    int lasertimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lasertimer >= 100)
        {
            Destroy(gameObject);
        }
        ++lasertimer;

    }
}
