using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScript : MonoBehaviour
{
    private float length;
    private float startpos;
    public GameObject cam;
    public float parallaxEffect;

    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float distance = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + distance, transform.position.y, transform.position.z);

        if (temp > startpos + length) 
            startpos += length;
        else if (temp < startpos - length) 
            startpos -= length;
    }
}
