using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject NextTP;
    GameObject TPObject;
    public string name;
    void Start()
    {
        NextTP = GameObject.Find(name);
    }
    void OnCollisionEnter(Collision col){
        Debug.Log("1");
        TPObject = col.collider.gameObject;
        TPObject.transform.position = NextTP.transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
