using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Choi.View
{
    public class GuageView : MonoBehaviour
    {
        [SerializeField] private Slider m_Slider;

        public float Value => m_Slider.value;

        //public void SetValue(int now, int max) => m_Slider.value = now / max;
        public void SetValue(int now, int max)
        {
            Debug.Log($"Guage Set ... {now} / {max} = {now / (max * 1f)}");
            m_Slider.value = now / (max * 1f);
        }
    }
}
