using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rastgeleborular : MonoBehaviour
{

    public GameObject pipePrefab;
    public float miny;
    public float maxy;
    public float x;
    public float interval;
    void Start()
    {
        InvokeRepeating("spawn", interval, interval);
    }

    private void spawn()
    {
        GameObject instance = Instantiate(pipePrefab);
        instance.transform.position = new Vector2(x, Random.Range(miny, maxy));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
