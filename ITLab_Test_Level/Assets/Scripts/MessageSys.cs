using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageSys : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartMessage());
    }
    IEnumerator StartMessage() {
        text.SetText("Добро Пожаловать в Тестовую Игру!");
        yield return new WaitForSeconds(3f);
        text.SetText("Подвинь куб на платформу, чтобы посмотреть, что случится");
        yield return new WaitForSeconds(4f);
        text.SetText("");
    }
    public void FirstFl() {
        StartCoroutine(SecondFloorMessage());
    }
    public void LastFl()
    {
        StartCoroutine(LastFloorMessage());
    }
    IEnumerator SecondFloorMessage() {
        text.SetText("Поздровляю! Вы решили первую головоломку!");
        yield return new WaitForSeconds(3f);
        text.SetText("Решите загадку, чтобы продвинуться дальше");
        yield return new WaitForSeconds(4f);
        text.SetText("");
    }
    IEnumerator LastFloorMessage()
    {
        text.SetText("Осталась последняя головоломка");
        yield return new WaitForSeconds(3f);
        text.SetText("Постройте дорогу от Дома до Магазина");
        yield return new WaitForSeconds(4f);
        text.SetText("");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
