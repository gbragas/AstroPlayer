using UnityEngine;

public class Desativar : MonoBehaviour
{

    bool bouncing = false;


    void OnCollisionEnter(Collision player)
    {
        if (player.gameObject.tag == "Player" && !bouncing)
        {
            Invoke("SetInactive", 7.0f);
            bouncing = true;
        }
    }

    void SetInactive()
    {
        this.gameObject.SetActive(false);
        bouncing = false;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
