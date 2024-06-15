using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestryOutOfBound : MonoBehaviour
{
    private float topBorder = 34.4f;
    private float bottomBorder = -13.9f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z >= topBorder)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z <= bottomBorder)
            Destroy(gameObject);
        }
    }

