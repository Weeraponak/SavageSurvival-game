using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemQuest2 : MonoBehaviour
{

    private int score = 0;
    private int score1 = 0;
    private int score2 = 0;
    private int Totalscore = 0;
    public Text scoreText;
    public Text scoreText1;
    public Text scoreText2;
    private AudioSource audioSource;
    public AudioClip itemSound;
    public AudioClip completeSound;
    public GameObject CongrateUI;
    int itemCount;
    int CheeseCount;
    int HotdogCount;
    int HamburgerCount;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        CheeseCount = GameObject.FindGameObjectsWithTag("Cheese").Length;
        HotdogCount = GameObject.FindGameObjectsWithTag("Hotdog").Length;
        HamburgerCount = GameObject.FindGameObjectsWithTag("Hamburger").Length;
        itemCount = CheeseCount + HotdogCount + HamburgerCount;
        scoreText.text = "Find Cheese = " + score.ToString() + "/" + CheeseCount.ToString();
        scoreText1.text = "Find Hotdog = " + score1.ToString() + "/" + HotdogCount.ToString();
        scoreText2.text = "Find Hamburger = " + score2.ToString() + "/" + HamburgerCount.ToString();
        Debug.Log(CheeseCount);
        Debug.Log(HotdogCount);
        Debug.Log(HamburgerCount);
        Debug.Log(itemCount);
    }

    private void OnTriggerEnter(Collider target)
    {
        Totalscore = score + score1 + score2;
        if (target.gameObject.tag.Equals("Cheese"))
        {
            Destroy(target.gameObject);
            score += 1;
            scoreText.text = "Find Cheese = " + score.ToString() + "/" + CheeseCount.ToString();
            audioSource.PlayOneShot(itemSound);
        }
        if (target.gameObject.tag.Equals("Hotdog"))
        {
            Destroy(target.gameObject);
            score1 += 1;
            scoreText1.text = "Find Hotdog = " + score1.ToString() + "/" + HotdogCount.ToString();
            audioSource.PlayOneShot(itemSound);
        }
        if (target.gameObject.tag.Equals("Hamburger"))
        {
            Destroy(target.gameObject);
            score2 += 1;
            scoreText2.text = "Find Hamburger = " + score2.ToString() + "/" + HamburgerCount.ToString();
            audioSource.PlayOneShot(itemSound);
        }
        if (Totalscore >= itemCount)
        {
            audioSource.PlayOneShot(completeSound);
            CongrateUI.SetActive(true);
        }
    }
}
