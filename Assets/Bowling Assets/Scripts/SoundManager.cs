using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource ballSFX, pinSFX, uiSFX;

    [SerializeField] private AudioClip clipThrowStart, clipRoll, clipPinCollision, clipBallFall;
    [SerializeField] private AudioClip clipButtonHover, clipButtonPressed, clipSpare, clipStrike;


    public void PlaySound(string soundClipName)
    {
        switch (soundClipName)
        {
            case "throw":
                ballSFX.PlayOneShot(clipThrowStart);
                break;
            case "roll":
                ballSFX.loop = true;
                ballSFX.clip = clipRoll;
                ballSFX.Play();
                break;
            case "collide":
                ballSFX.loop = false;
                ballSFX.Stop();
                pinSFX.PlayOneShot(clipPinCollision);
                break;
            case "ballFall":
                //Do Something;
                break;
            case "strike":
                //Do Something;
                break;
            case "spare":
                //Do Something;
                break;
            case "buttonHover":
                //Do Something;
                break;
            case "buttonClick":
                //Do Something;
                break;
            default:
                //Do Something;
                break;

        }
    }
}
