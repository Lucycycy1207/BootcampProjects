using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSetup : MonoBehaviour
{

    [SerializeField]
    private GameObject mobileControl;

    // Start is called before the first frame update
    void Start()
    {
#if UNITY_ANDROID || UNITY_IOS || UNITY_EDITOR
    mobileControl.SetActive(true);
#endif
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
