using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MPBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;


    public void SetMaxMP(int mp)
    {
        slider.maxValue = mp;
        slider.value = mp;
        fill.color = gradient.Evaluate(1f);
    }
    public void SetMP(int mp)
    {
        slider.value = mp;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
