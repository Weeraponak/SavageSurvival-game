using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemQuest : MonoBehaviour
{
    private int score = 0;
    private int score1 = 0;
    private int Totalscore = 0;
    public Text scoreText;
    public Text scoreText1;
    private AudioSource audioSource;
    public AudioClip itemSound;
    public AudioClip completeSound;

    int itemCount;
    int BoxCount;
    int CrystalCount;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();       
        BoxCount = GameObject.FindGameObjectsWithTag("box").Length;
        CrystalCount = GameObject.FindGameObjectsWithTag("Crystal").Length;
        itemCount = BoxCount + CrystalCount;
        scoreText.text = "Find Box = " + score.ToString() + "/" + BoxCount.ToString();
        scoreText1.text = "Find Crystal = " + score1.ToString() + "/" + CrystalCount.ToString();
        Debug.Log(BoxCount);
        Debug.Log(CrystalCount);
        Debug.Log(itemCount);
    }

    private void OnTriggerEnter(Collider target)
    {
        Totalscore = score + score1;
        if (target.gameObject.tag.Equals("box"))
        {
            Destroy(target.gameObject);
            score += 1;
            scoreText.text = "Find Box = " + score.ToString() + "/" + BoxCount.ToString();
            audioSource.PlayOneShot(itemSound);
        }
        if (target.gameObject.tag.Equals("Crystal"))
        {
            Destroy(target.gameObject);
            score1 += 1;
            scoreText1.text = "Find Crystal = " + score1.ToString() + "/" + CrystalCount.ToString();
            audioSource.PlayOneShot(itemSound);
            
        }
        if (Totalscore >= itemCount)
        {           
            audioSource.PlayOneShot(completeSound);
            StartCoroutine(NextLevel());
        }
    }
    IEnumerator  NextLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Level2");
    }
}
