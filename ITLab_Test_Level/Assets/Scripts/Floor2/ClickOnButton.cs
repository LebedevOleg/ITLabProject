using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Lumin;

public class ClickOnButton : MonoBehaviour
{
    private GameObject Player;
    [SerializeField] private TMPro.TMP_Text message;
    [SerializeField] private Light PointLight1;
    [SerializeField] private Light PointLight2;
    [SerializeField]private GameObject Plato;
    [SerializeField] private GameObject Plato2;
    [SerializeField] private GameObject Door1;
    [SerializeField] private GameObject Door2;
    [SerializeField] private GameObject Button1;
    [SerializeField] private GameObject Button2;
    private int cheak = 0;
    private int OK = 0;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player"); 
        Plato.SetActive(false);
        Plato2.SetActive(false);
        if (this.gameObject.name.Equals("Button1"))
            cheak = 1;
        else
            cheak = 2;
    }
    
    // Update is called once per frame
    void OnTriggerEnter(){
        OK =1;
        message.SetText("Hажмите F чтобы взаимодействовать с кнопокой");
    }
    void OnTriggerExit()
    {
        OK = 0;
        message.SetText("");
    }

    void changeTP(GameObject P){     
        if(P.active == true)
            P.SetActive(false);
        else
            P.SetActive(true);
        Button1.SetActive(false);
        Button2.SetActive(false);
    }
    void Update()
    {
        if(OK ==1){
            if (cheak == 1)
            {
                if (Input.GetKey(KeyCode.F))
                {                    
                    changeTP(Plato);
                    Door1.GetComponent<Animation>().Play();
                    PointLight1.color = Color.green;
                    PointLight2.range = 0;
                    
                }
            }
            else if (cheak == 2) 
            {
                if (Input.GetKey(KeyCode.F))
                {                    
                    changeTP(Plato2);
                    Door2.GetComponent<Animation>().Play();
                    PointLight2.color = Color.green;
                    PointLight1.range = 0;

                }
            }
        }
    }
}
