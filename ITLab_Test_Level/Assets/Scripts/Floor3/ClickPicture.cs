using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickPicture : MonoBehaviour
{
    [SerializeField] private MapPoint Map;
    [SerializeField] private GameObject Player;
    RaycastHit hit;
    Ray ray;
    
    // Start is called before the first frame update
    void Start()
    {
        ray = new Ray(Camera.main.ScreenToWorldPoint(Input.mousePosition), Player.transform.forward);
    }

    // Update is called once per frame

    void Update()
    {
        Physics.Raycast(ray, out hit);
        if (hit.collider != null && hit.collider.gameObject == this.gameObject)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                this.gameObject.transform.Rotate(90, 0, 0);
                Map.Cheak();
            }
        }
    }
}
