using UnityEngine;

public class ApplyForceToCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Rigidbody ourRigidBody;

    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ourRigidBody.AddExplosionForce(200, transform.position - new Vector3(0, -1, -1), 3);

        }

    }
}
