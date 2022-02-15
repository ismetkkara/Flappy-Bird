using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borukontrol : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        Destroy(gameObject, lifeTime);
    }
}
