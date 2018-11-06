using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Transition_Controller : MonoBehaviour
{

    public GameObject yourObject;

    public GameObject openScene;

    public GameObject loadingScene;
    public Text loadingText;

    public GameObject menuScene;

    // Use this for initialization
    void Start ()
    {

        openScene.SetActive(true);
        loadingScene.SetActive(false);
        menuScene.SetActive(false);

	}

    public void RestartMenu()
    {

        menuScene.SetActive(false);
        openScene.SetActive(true);

    }

    public void StartGame()
    {

        SceneManager.LoadScene("World View_01");

    }

    public void GameActivate()
    {

        StartCoroutine(COnnectScreen());

    }

    IEnumerator COnnectScreen()
    {

        yield return new WaitForSeconds(1);
        loadingScene.SetActive(true);
        openScene.SetActive(false);
        loadingText.text = "Attempting Connection";
        yield return new WaitForSeconds(0.5f);
        loadingText.text = "Attempting Connection.";
        yield return new WaitForSeconds(0.5f);
        loadingText.text = "Attempting Connection..";
        yield return new WaitForSeconds(0.5f);
        loadingText.text = "Attempting Connection...";
        yield return new WaitForSeconds(0.5f);
        loadingText.text = "Attempting Connection";
        yield return new WaitForSeconds(0.5f);
        loadingText.text = "Attempting Connectio";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attempting Connecti";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attempting Connect";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attempting Connec";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attempting Conne";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attempting Conn";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attempting Con";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attempting Co";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attempting C";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attempting";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attemptin";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attempti";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attempt";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attemp";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Attem";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Atte";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "Att";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "At";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "A";
        yield return new WaitForSeconds(0.05f);
        loadingText.text = "";
        yield return new WaitForSeconds(0.5f);
        loadingText.text = "CONNECTION ESTABLISHED";
        yield return new WaitForSeconds(1);
        loadingScene.SetActive(false);
        menuScene.SetActive(true);

    }

}
