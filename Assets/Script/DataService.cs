using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Unity.VisualScripting;

public class DataService : MonoBehaviour
{
    List<string[]> data;
    const string filename = "Questions.txt";
    // Start is called before the first frame update
    void Start()
    {
        /*
        foreach (string[] question in Read("Questions.txt"))
        {
            print($"{question[0]} {question[1]} {question[2]} {question[3]} {question[4]}");
        }
        

        List<string[]> questions = GetData();
        for (int i = 0; i < questions.Count; i++)
        {
            print($"{questions[i][0]} {questions[i][1]} {questions[i][2]} {questions[i][3]} {questions[i][4]}");
        }
        */
    }

    void Read()
    {
        StreamReader streamReader = new StreamReader(filename);
        string[] question;
        data = new List<string[]>();
      
        string line = streamReader.ReadLine();               
        while (line != null)
        {           
            question = line.Split("|");
            line = streamReader.ReadLine();
            data.Add(question);
        }
        
        streamReader.Close();      
    }

    void Shuffle()
    {
        for (int i = 0; i < data.Count; i++)
        {
            int randomIndex = Random.Range(0, data.Count - 1);
            string[] swap = data[i];
            data[i] = data[randomIndex];
            data[randomIndex] = swap;
        }
    }

    public List<string[]> GetData()
    {
        Read();
        Shuffle();
        ShuffleAnswers();

        return data;
    }

    void ShuffleAnswers()
    {
        foreach (string[] answer in data)
        {
            for (int i = 2; i < answer.Length; i++)
            {
                int randomIndex = Random.Range(2, answer.Length - 1);
                string swap = answer[i];
                answer[i] = answer[randomIndex];
                answer[randomIndex] = swap;
            }            
        }
    }
}
