using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCheak : MonoBehaviour
{
    [SerializeField]private MessageSys message;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Collider>().gameObject.name.Equals("Player"))
        {
            
            message.FirstFl();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
