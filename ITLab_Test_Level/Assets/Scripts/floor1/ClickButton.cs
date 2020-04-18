using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    GameObject Plato;
    Teleport Teleport;
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        Plato = GameObject.Find(name);
        Plato.SetActive(false);
    }
    void OnCollisionEnter()
    {
        Plato.SetActive(true);
    }
    void OnCollisionExit()
    {
        Plato.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
     
    }
}
