using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMess : MonoBehaviour
{
    [SerializeField] private MessageSys message;
    [SerializeField] private move Sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Collider>().gameObject.name.Equals("Player"))
        {
            Sphere.setBool();
            message.LastFl();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
