using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundTrip1 : MonoBehaviour
{
    [SerializeField] float range;
    [SerializeField] float speed;
    private float moved = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed);
        moved += speed;

        if((speed > 0 && moved > range) || (speed < 0 && moved < 0))
        {
            speed *= -1;
        }
    }
}
