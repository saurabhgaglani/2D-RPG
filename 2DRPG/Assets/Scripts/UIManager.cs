using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public Slider healthBar;
    private PlayerHealthManager phm;




    void Start()
    {
        phm = FindObjectOfType<PlayerHealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.maxValue = phm.player_max_health;
        healthBar.value = phm.getCurrentHealth();
    }
}
