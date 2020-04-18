using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour
{
   
    [SerializeField] private MapPoint Map;
    public GameObject go;
    [SerializeField] private Camera goCamera;
    private Vector3 MousePos;
    public float Speed;
    public GameObject sphere;
    private bool floor3;
    private GameObject Player;
    public int SpeedRotation = 1;
    public int jump = 10;
    RaycastHit hit;
    Ray ray;
    private float MyAngle = 0F;


    // Start is called before the first frame update
    void Start()
    {
        floor3 = false;
        go = this.gameObject;
        Player = this.gameObject;
        Vector3 vector = new Vector3(0,0,1);
   
    }
    void FixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            MyAngle = 1;
            MyAngle = ((MousePos.y - (Screen.height / 2)) / Screen.height);
            goCamera.transform.RotateAround(goCamera.transform.position, goCamera.transform.right*-1, MyAngle);
        }
    }
    public void EndGame() {
        Speed = 0;
        SpeedRotation = 0;
        jump = 0;
    }
    public void setBool() {
        floor3 = true;
    }
    void Update()
    {
        MousePos = Input.mousePosition;
        ray = new Ray(goCamera.transform.position,goCamera.transform.forward);
        if (Input.GetKey(KeyCode.W))
        {

            Player.transform.position += Player.transform.forward * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {

            Player.transform.position -= Player.transform.forward * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {

            Player.transform.Rotate(Vector3.down * SpeedRotation);
        }
        if (Input.GetKey(KeyCode.D))
        {

            Player.transform.Rotate(Vector3.up * SpeedRotation);

        }
        if (Input.GetKey(KeyCode.Space))
        {

            Player.transform.position += Player.transform.up * jump * Time.deltaTime;
        }
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == Player)
                sphere.SetActive(false);
            else if(floor3)
            {
                sphere.SetActive(true);
                sphere.transform.position = hit.point;
            }
            if (hit.collider.tag.Equals("MAP") && Input.GetKeyDown(KeyCode.Mouse0))
            {
                hit.collider.gameObject.transform.Rotate(0f, 90f, 0f);
                Map.Cheak();
            }
        }
        else
            sphere.SetActive(false);
    }
}
