using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static UI instance;

    public Slider healthSlider;
    public TextMeshProUGUI healthText, slimesKilledText;
    public int slimesKilled;
    private void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        slimesKilled = 0;
    }

    // Update is called once per frame
    void Update()
    {
        UI.instance.slimesKilledText.text = "Slimes Killed:" + slimesKilled;
    }
}
