using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    [SerializeField]
    private AudioSource start;

    [SerializeField]
    private float MenuStartTime = 1.0f;

    IEnumerator TransitionToNextScene()
    {
        start.Play();

        yield return new WaitForSeconds(MenuStartTime);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayGame()
    {
        StartCoroutine(TransitionToNextScene());
    }
}