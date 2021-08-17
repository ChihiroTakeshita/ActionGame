using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{
    private TextMeshProUGUI timerText;
    static public float second;
    static public int minute;
    private int hour;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        second = Time.timeSinceLevelLoad;
        second = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        second -= Time.deltaTime;
        if (minute > 60)
        {
            hour++;
            minute = 0;
        }
        if (second > 60f)
        {
            minute += 1;
            second = 0;
        }

        timerText.text = minute.ToString("#0") + ":" + second.ToString("00.0");
    }
}
