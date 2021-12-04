using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
    [SerializeField]
    private Slider m_slider;

    [SerializeField]
    private Gradient m_gradient;

    [SerializeField]
    private Image m_fill;


    public void SetMaxHealth(int health)
    {
        m_slider.maxValue = health;
        m_slider.value = health;

        m_fill.color = m_gradient.Evaluate(1.0f);
    }

    public void SetHealth(int health)
    {
        m_slider.value = health;

        m_fill.color = m_gradient.Evaluate(m_slider.normalizedValue);
    }
}
