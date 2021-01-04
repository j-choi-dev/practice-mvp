using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Choi.Model
{
    public class ValueModel
    {
        public int DamageValue { get; private set; }
        public void SetDamaeValue(int val)
        {
            Debug.Log($"{DamageValue} -> {val}");
            DamageValue = val;
        }
    }
}