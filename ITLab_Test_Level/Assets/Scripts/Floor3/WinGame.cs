using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class WinGame : MonoBehaviour
{
    public move Player;
    public TMPro.TMP_Text endtext;
    public TMPro.TMP_Text text;
    public Button b1;
    public Button b2;
    // Start is called before the first frame update
    void Start()
    {
        endtext.SetText("");
        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(false);
    }
    public void StartAgain() {
        SceneManager.LoadScene(0);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        b1.gameObject.SetActive(true);
        b2.gameObject.SetActive(true);
        Player.EndGame();
        text.gameObject.SetActive(false);
        endtext.SetText("Спасибо что посмотрели этот проект! \nВыберете что сделать дальше:");
    }
    public void Exit() {
        Exit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
