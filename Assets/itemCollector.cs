using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class itemCollector : MonoBehaviour
{
    int coins = 0;
    [SerializeField] AudioSource collectionSound;

    [SerializeField] TextMeshProUGUI coinsText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
            collectionSound.Play();


        }
    }
       
}
