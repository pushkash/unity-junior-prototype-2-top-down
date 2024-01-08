using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmerHealth : MonoBehaviour
{
    public Slider healthSlider;
    public int damage = 3;

    private int currentDamage = 0;

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue = damage;
        healthSlider.value = currentDamage;
        healthSlider.fillRect.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void CatchBall()
    {
        Debug.Log("Here");
        // if ball fall on the ground, damage set += 1
        currentDamage += 1;
        healthSlider.fillRect.gameObject.SetActive(true);
        healthSlider.value = currentDamage;
        Debug.Log(currentDamage);
    }
}
