using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    bool dead = false;
    [SerializeField] AudioSource deathSound;

    private void Update()
    {
        if (transform.position.y < -5f && !dead)
        {
            Die();
        }
    }

   
       

    


    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PalyerMovement>().enabled = false;
            Die();
        }


    //     if (collision.gameObject.CompareTag("FirstQ"))
      //  {
        //   
          //  GameObject objectToHide = GameObject.Find("Panel");
            //objectToHide.SetActive(true);
       // }


    }

    void Die() {
        

        Invoke(nameof(ReloadLevel), 1.3f);
        dead = true;
        deathSound.Play();

      


    }

    void ReloadLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
