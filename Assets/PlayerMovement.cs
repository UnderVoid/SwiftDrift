using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float lateralSpeed = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("PlayerMovement.cs started");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
          rb.AddForce(lateralSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
          rb.AddForce(-lateralSpeed * Time.deltaTime, 0, 0);
        }
    }
}
