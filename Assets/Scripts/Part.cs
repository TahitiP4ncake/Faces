using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum partType
{
    eye,
    mouth,
    nose
}

public class Part : MonoBehaviour
{

    public bool active;
    public float maxAngle = 1;
    public float speed = .1f;

    private float xoff;
    private float yoff;
    private float zoff;
    
    public FaceGenerator face;

    public partType type;

    private void Start()
    {
        xoff = Random.Range(0f, 100f);
        yoff = Random.Range(0f, 100f);
        zoff = Random.Range(0f, 100f);

        speed = Random.Range(speed / 4, speed);

    }


    void Update()
    {
        transform.localEulerAngles = new Vector3(Mathf.PerlinNoise(0,Time.time*speed + xoff)*maxAngle, 
                                                 Mathf.PerlinNoise(0, Time.time*speed + yoff)*maxAngle, 
                                                 Mathf.PerlinNoise(0, Time.time*speed + zoff)*maxAngle);
    }

    public void Generate()
    {
        switch (type)
        {
            case partType.eye:
                
                break;
            case partType.mouth:
                
                break;
            case partType.nose:
                
                break;
        }
    }
}
