using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;




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
        ResetFrameUI();

        messageUIStrike.SetActive(false);
        messageUISpare.SetActive(false);
        gameOverUI.SetActive(false);
    }
    public void ResetFrameUI() //Reset FrameUI children objects under the FrameHolder Transform
    {
        frames = new FrameUI[frameHolder.childCount];
        for (int i = 0; i < frameHolder.childCount; i++)
        {
            frames[i] = frameHolder.GetChild(i).GetComponent<FrameUI>();
            frames[i].SetFrame(i + 1);
        }
    }

    public void SetFrameValue(int frame, int throwNumber, int score)
    {
        frames[frame - 1].UpdateScore(throwNumber, score);
    }

    public void SetFrameTotal(int frame, int score)
    {
        frames[frame].UpdateTotal(score);
    }

    public void ShowStrike()
    {
        messageUIStrike.SetActive(true);
        Invoke(nameof(HideStrike), 2.0f);
    }

    public void HideStrike()
    {
        messageUIStrike.SetActive(false);
    }

    public void ShowSpare()
    {
        messageUISpare.SetActive(true);
        Invoke(nameof(HideSpare), 2.0f);
    }

    public void HideSpare()
    {
        messageUISpare.SetActive(false);
    }

    public void ShowGamerOver(int totalScore)
    {
        gameOverUI.SetActive(true);
        scoreText.text = totalScore.ToString();
    }
}
