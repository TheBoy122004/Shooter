using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Vector3.SignedAngle(transform.position, Input.mousePosition, Vector3.forward);
        //float Angle = (transform.position.y - Input.mousePosition.y) / (transform.position.x - Input.mousePosition.x);
        //float RotateAng = Mathf.Atan(Angle) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
        if(Input.GetKey(KeyCode.W)) {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
