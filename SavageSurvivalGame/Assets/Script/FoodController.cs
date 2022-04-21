using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FoodController : MonoBehaviour
{
    public Image currentFood; // ภาพแสดง Bar
    public Text txt; // แสดงข้อความ %
    public float food = 100;
    private float maxfood = 100;
    public static FoodController instance;
    public GameObject NewStart;

    void Start()
    {
        instance = this;
        InvokeRepeating("updateFoodHealth", 1.0f, 2f);
    }
    
    void Update()
    {
        float radio = food / maxfood; 
        currentFood.rectTransform.localScale = new Vector3(radio, 1, 1);
        txt.text = (radio * 100) + " % ";
        
    }
    void updateFoodHealth()
    {
        if (food > 0)
        {
            food -= 1f;
        }
        if (food == 0 )
        {
            SceneManager.LoadScene("LoseScene");
            Debug.Log("ตายแล้ว");
        }
    }
    
    //จะถูกเรียกใช้งานตอนกดใช้ไอเทม
    public void Chicken()
    {
        food += 10;
        if (food >= maxfood)
        {
            food = maxfood;
        }
    }
    public void Mushroom()
    {
        food += 3;
        if (food >= maxfood)
        {
            food = maxfood;
        }
    }
    public void Banana()
    {
        food += 7;
        if (food >= maxfood)
        {
            food = maxfood;
        }
    }
}
