using UnityEngine;
using UnityEngine.EventSystems;

public class Block1_Move : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // S = U * T;     S (distance)  = U (velocity) * T (time)
       
        if (Input.GetKey(KeyCode.UpArrow))
        { 
            transform.position += Vector3.up * Time.fixedDeltaTime;
        }
        
    }
}
