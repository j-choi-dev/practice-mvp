using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

namespace Choi.View
{
    public class DamageInputFieldView : MonoBehaviour
    {
        [SerializeField] private Text m_DamageValue;

        public StringReactiveProperty Value = new StringReactiveProperty();

        private void Awake()
        {
            m_DamageValue.text = "0";
            Value.Value = m_DamageValue.text;
            if (int.Parse(m_DamageValue.text) > 0 && int.Parse(m_DamageValue.text) < 10)
                Value.Value = m_DamageValue.text;
        }
    }
}