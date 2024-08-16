using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionUI : MonoBehaviour
{
    public void SetBgm (float value)
    {
        SoundManager.Instance.SetBgmVolume(value);
    }
}
