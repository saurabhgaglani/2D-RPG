using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public string LevelName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
            Application.LoadLevel(LevelName);

               
        
        
    }
}
