using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilahAlma : MonoBehaviour
{
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if(distance <= 1.5)
        {
            print(gameObject.name);
        }
    }
}
