using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    private static List<Question> unansweredQuestions;
    private static int score = 0;

    private Question currentQuestion;

    [SerializeField]
    private AudioSource correct;
    [SerializeField]
    private AudioSource wrong;

    [SerializeField]
    private Text factText;
    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private Text AText;
    [SerializeField]
    private Text BText;
    [SerializeField]
    private Text CText;
    [SerializeField]
    private Text DText;

    [SerializeField]
    private Text AAnswerText;
    [SerializeField]
    private Text BAnswerText;
    [SerializeField]
    private Text CAnswerText;
    [SerializeField]
    private Text DAnswerText;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private float timeBetweenQuestions = 1.0f;

    public void Start ()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            List<Question> questions = new List<Question>();
            questions = GetQuestions();
            unansweredQuestions = questions;
        }
        SetCurrentQuestion();
    }

    private List<Question> GetQuestions()
    {
        List<Question> questions = new List<Question>();
        string fileData = System.IO.File.ReadAllText("Assets/Questions.csv");
        string[] lines = fileData.Split("\n"[0]);

        foreach(string line in lines)
        {
            if (!string.IsNullOrEmpty(line))
            {
                Question question = new Question();
                string[] dataLine = (line.Trim()).Split(',');

                question.setFact(dataLine[0]);
                question.setAnswer(dataLine[1]);
                question.setA(dataLine[2]);
                question.setB(dataLine[3]);
                question.setC(dataLine[4]);
                question.setD(dataLine[5]);

                questions.Add(question);
            }
        }
        return questions;
    }

    private void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        string fact = currentQuestion.getFact();
        string answer = currentQuestion.getAnswer();
        string a = currentQuestion.getA();
        string b = currentQuestion.getB();
        string c = currentQuestion.getC();
        string d = currentQuestion.getD();

        factText.text = fact;
        scoreText.text = "Score: " + score;
        AText.text = a;
        BText.text = b;
        CText.text = c;
        DText.text = d;

        unansweredQuestions.RemoveAt(randomQuestionIndex);

        if (answer == a)
        {
            AAnswerText.text = "CORRECT";
            BAnswerText.text = "WRONG";
            CAnswerText.text = "WRONG";
            DAnswerText.text = "WRONG";
        }
        else if (answer == b)
        {
            AAnswerText.text = "WRONG";
            BAnswerText.text = "CORRECT";
            CAnswerText.text = "WRONG";
            DAnswerText.text = "WRONG";
        }
        else if (answer == c)
        {
            AAnswerText.text = "WRONG";
            BAnswerText.text = "WRONG";
            CAnswerText.text = "CORRECT";
            DAnswerText.text = "WRONG";
        }
        else
        {
            AAnswerText.text = "WRONG";
            BAnswerText.text = "WRONG";
            CAnswerText.text = "WRONG";
            DAnswerText.text = "CORRECT";
        }
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelect(int selection)
    {
        string answer = currentQuestion.getAnswer();
        string a = currentQuestion.getA();
        string b = currentQuestion.getB();
        string c = currentQuestion.getC();
        string d = currentQuestion.getD();

        switch (selection)
        {
            case 1:
                animator.SetTrigger("AClicked");
                if (answer == a)
                {
                    score++;
                    correct.Play();
                    scoreText.text = "Score: " + score;
                    Debug.Log("CORRECT!");
                }
                else
                {
                    score--;
                    wrong.Play();
                    scoreText.text = "Score: " + score;
                    Debug.Log("WRONG!");
                }

                StartCoroutine(TransitionToNextQuestion());
                break;
            case 2:
                animator.SetTrigger("BClicked");
                if (answer == b)
                {
                    score++;
                    correct.Play();
                    scoreText.text = "Score: " + score;
                    Debug.Log("CORRECT!");
                }
                else
                {
                    score--;
                    wrong.Play();
                    scoreText.text = "Score: " + score;
                    Debug.Log("WRONG!");
                }

                StartCoroutine(TransitionToNextQuestion());
                break;
            case 3:
                animator.SetTrigger("CClicked");
                if (answer == c)
                {
                    score++;
                    correct.Play();
                    scoreText.text = "Score: " + score;
                    Debug.Log("CORRECT!");
                }
                else
                {
                    score--;
                    wrong.Play();
                    scoreText.text = "Score: " + score;
                    Debug.Log("WRONG!");
                }

                StartCoroutine(TransitionToNextQuestion());
                break;
            case 4:
                animator.SetTrigger("DClicked");
                if (answer == d)
                {
                    score++;
                    correct.Play();
                    scoreText.text = "Score: " + score;
                    Debug.Log("CORRECT!");
                }
                else
                {
                    score--;
                    wrong.Play();
                    scoreText.text = "Score: " + score;
                    Debug.Log("WRONG!");
                }

                StartCoroutine(TransitionToNextQuestion());
                break;
            default:
                Debug.Log("No Selection");
                break;
        }
    }
}
