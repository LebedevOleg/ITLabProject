using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class MapPoint : MonoBehaviour
{
    [SerializeField] private Transform Section1;
    [SerializeField] private Transform Section2;
    [SerializeField] private Transform Section3;
    [SerializeField] private Transform Section4;
    [SerializeField] private Transform Section5;
    [SerializeField] private Transform Section6;
    [SerializeField] private GameObject TP;


    // Start is called before the first frame update
    void Start()
    {
        TP.SetActive(false);
    }
    public void Cheak() {

        if ((Section1.eulerAngles.y ==0f ||Section1.eulerAngles.y == 180f) && Section2.eulerAngles.y == 180f && (Section3.eulerAngles.y == 90f || Section3.eulerAngles.y == 270f) && (Section4.eulerAngles.y == 90f|| Section4.eulerAngles.y ==270f) && Section5.eulerAngles.y == 270f &&  Section6.eulerAngles.y == 0f) {            
            TP.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
