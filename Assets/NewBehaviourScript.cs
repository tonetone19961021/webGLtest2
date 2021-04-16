using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cube;
    public float MoveSpeed = 5;

    private float angle_Sum;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("FUCK");
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        if (Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0)
        {
            angle_Sum = Mathf.Atan2(h, v) / (Mathf.PI / 180);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, angle_Sum, transform.eulerAngles.z);
            
        }
        
        
        if (Input.GetKey(KeyCode.W) )
        {
            transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed, Space.World);
            
        }
        if (Input.GetKey(KeyCode.A) )
        {
            transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed, Space.World);
            
        }
        if (Input.GetKey(KeyCode.S) )
        {
            transform.Translate(Vector3.back * Time.deltaTime * MoveSpeed, Space.World);
           
        }
        if (Input.GetKey(KeyCode.D) )
        {
            transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed, Space.World);
            
        }

    }
}
