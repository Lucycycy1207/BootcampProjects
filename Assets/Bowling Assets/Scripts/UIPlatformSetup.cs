using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Burst.CompilerServices;

public class UIPlatformSetup : MonoBehaviour
{
    [SerializeField] TMP_Text instructionText;
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_ANDROID || UNITY_IOS
instructionText.text = "Press LEFT button to move LEFT and RIGHT button to move RIGHT.\r\nHit the THROW button to throw ball.";
#elif UNITY_STANDALONE || UNITY_STANDALONE_WIN || UNITY_EDITOR
        instructionText.text = "Press A to move LEFT and D to move RIGHT.\r\nHit the SPACE button to throw ball.";
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
