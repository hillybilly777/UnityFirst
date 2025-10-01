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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ourRigidBody.AddExplosionForce(1000, transform.position - new Vector3(0, -1, -1), 3);    

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
        collision.transform.position += Vector3.back;
    }

}
