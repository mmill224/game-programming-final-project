using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speed = 10f;

    public Transform player;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        transform.position += transform.forward * speed * Time.deltaTime;
        // Vector3 direction = player.position - transform.position;
        // float angle = Mathf.Atan3(direction.y, direction.x, direction.z) * Mathf.Rad3Deg;
    }

    void OnTriggerEnter()
    {  
        Destroy(gameObject);
        Start();
    }


}
