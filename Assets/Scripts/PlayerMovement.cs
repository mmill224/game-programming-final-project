using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;

    public float forwardSpeed = 40f, horizontalSpeed = 5f, verticalSpeed = 3f;
    private float activeForwardSpeed, activeHorizontalSpeed, activeVerticalSpeed;
    private float forwardAcceleration = 2.5f, horizontalAcceleration = 2f, verticalAcceleration = 2f;

    public float lookSpeed = 250f;
    private Vector2 lookInput, screenCenter, mouseDistance;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        screenCenter.x = Screen.width  * 0.5f;
        screenCenter.y = Screen.height * 0.5f;

        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        lookInput.x = Input.mousePosition.x;
        lookInput.y = Input.mousePosition.y;

        mouseDistance.x = (lookInput.x - screenCenter.x) / (screenCenter.y);
        mouseDistance.y = (lookInput.y - screenCenter.y) / (screenCenter.y);

        transform.Rotate(-Input.GetAxisRaw("Horizontal")*lookSpeed * 5 * Time.deltaTime, mouseDistance.x * lookSpeed * Time.deltaTime, mouseDistance.y*lookSpeed * Time.deltaTime, Space.Self);

        activeForwardSpeed    = Mathf.Lerp(activeForwardSpeed, Input.GetAxisRaw("Vertical") * forwardSpeed, forwardAcceleration * Time.deltaTime);
        activeVerticalSpeed   = Mathf.Lerp(activeVerticalSpeed, Input.GetAxisRaw("Hover") * verticalSpeed, verticalAcceleration * Time.deltaTime);

        transform.position += transform.right   * activeForwardSpeed * Time.deltaTime;
        transform.position += transform.forward * activeHorizontalSpeed * Time.deltaTime;
        transform.position += transform.up * activeVerticalSpeed * Time.deltaTime;

        
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Start();
    }

}
