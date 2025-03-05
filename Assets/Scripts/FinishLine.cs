using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinishLine : MonoBehaviour
{

    //public Text finishText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //StartCoroutine(ShowFinishMessage());
            Debug.Log("Race Finished!");
            EndGame();
        }
    }

    void EndGame()
    {
        //StartCoroutine(ShowFinishMessage());
        Debug.Log("Game Over! Player crossed finish line");
        Time.timeScale = 0f; // pause the game
    }

    //IEnumerator ShowFinishMessage()
    //{
    //    if (finishText != null)
    //    {
    //        finishText.text = "Race Completed!";
    //        finishText.enabled = true;

    //        yield return new WaitForSeconds(10f);
    //    }
    //}
}
