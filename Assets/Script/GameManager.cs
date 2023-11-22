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
    int currentIndex = -1;
    int score = 0;



    // Start is called before the first frame update
    void Start()
    {
        dataService = GetComponent<DataService>();
        data = dataService.GetData();

        SetData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckAnswer1()
    {

        if (data[currentIndex][1] == data[currentIndex][2])
        {
            score++;
            print("Win");
        }
        
        SetData();
    }

    public void CheckAnswer2()
    {

        if (data[currentIndex][1] == data[currentIndex][3])
        {
            score++;
            print("Win");
        }
        
        SetData();
        
    }

    public void CheckAnswer3()
    {

        if (data[currentIndex][1] == data[currentIndex][4])
        {
            score++;
            print("Win");
        }
        
        SetData();
    }

    public void CheckAnswer4()
    {

        if (data[currentIndex][1] == data[currentIndex][5])
        {
            score++;
            print("Win");
        }       
        SetData();
    }

    public void SetData()
    {
        currentIndex++;
        scoreText.text = score.ToString();
        question.text = data[currentIndex][0];
        answer1.text = data[currentIndex][2];
        answer2.text = data[currentIndex][3];
        answer3.text = data[currentIndex][4];
        answer4.text = data[currentIndex][5];
    }
}
