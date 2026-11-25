using UnityEngine;
using UnityEngine.SceneManagement;

public class ExampleClass : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("New Scene", LoadSceneMode.Single);
    }

}