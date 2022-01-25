using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_health_script : MonoBehaviour
{
    public int Player_health;
    int damage;
    bool get_hit = false;
    bool toggle;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == ("Damage"))
        {
            get_hit = true;
            toggle = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        get_hit = false;
    }

    private void Update()
    {
        if(get_hit== true)
        {
            if(toggle == true)
            {
                Player_health = Player_health - (damage = Random.Range(10, 50));
                toggle = false;
                StartCoroutine(delay());
            }
        }

        if(Player_health <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(1.9f);
        toggle = true;
    }
}
