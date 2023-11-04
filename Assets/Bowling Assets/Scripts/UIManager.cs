using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] private Transform frameHolder;
    [SerializeField] private GameObject messageUIStrike;
    [SerializeField] private GameObject messageUISpare;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private TMP_Text scoreText;

    private FrameUI[] frames;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
