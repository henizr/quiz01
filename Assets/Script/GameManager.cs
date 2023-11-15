using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class GameManager : MonoBehaviour
{
    DataService dataService;
    List<string[]> data;
    public Text question;
    public Text answer1, answer2, answer3, answer4, scoreText;
    public Sprite[] logo;
    int currentIndex = 0;
    int score = 0;



    // Start is called before the first frame update
    void Start()
    {
        dataService = GetComponent<DataService>();
        data = dataService.GetData();
        /*
        foreach (string[] item in data)
        {
            print(item[0]);
        }
        */
        SetData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckAnswer1()
    {
        
        if (data[currentIndex][1] == data[currentIndex][1])
        {
            score++;
            print("Win");
        }
        
        SetData();
    }

    public void CheckAnswer2()
    {
        
        if (data[currentIndex][1] == data[currentIndex][1])
        {
            score++;
            print("Win");
        }
        
        SetData();
        
    }

    public void CheckAnswer3()
    {
        
        if (data[currentIndex][1] == data[currentIndex][1])
        {
            score++;
            print("Win");
        }
        
        SetData();
    }

    public void CheckAnswer4()
    {
        
        if (data[currentIndex][1] == data[currentIndex][1])
        {
            score++;
            print("Win");
        }       
        SetData();
    }

    public void SetData()
    {        
        question.text = data[currentIndex][0];
        scoreText.text = score.ToString();
        answer1.text = data[currentIndex][1];
        answer2.text = data[currentIndex][2];
        answer3.text = data[currentIndex][3];
        answer4.text = data[currentIndex][4];
        currentIndex++;
    }
}
