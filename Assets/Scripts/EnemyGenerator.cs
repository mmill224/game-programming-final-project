using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    Vector3 minGameField = new Vector3(-100, -100, -100);
    Vector3 maxGameField = new Vector3(100, 100, 100);

    int randomGuy;
    public GameObject newObject;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(newObject, randomVector(), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        randomGuy = UnityEngine.Random.Range(0,1000);
        if (randomGuy > 991)
        {
            Instantiate(newObject, randomVector(), Quaternion.identity);
        }
    }
        Vector3 randomVector()
    {
        Vector3 result = new Vector3(UnityEngine.Random.Range(minGameField.x, maxGameField.x), 
                             UnityEngine.Random.Range(minGameField.y, maxGameField.y), 
                             UnityEngine.Random.Range(minGameField.z, maxGameField.z));
        return result;
    }

    

}
