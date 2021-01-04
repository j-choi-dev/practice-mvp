using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Choi.Model
{
    public class GuageModel
    {
        public int HpMax => 100;
        public IntReactiveProperty HpNow = new IntReactiveProperty();

        public GuageModel()
        {
            HpNow.Value = HpMax;
        }

        public void SetValue(int value)
        {
            HpNow.Value = value;
        }

        public void OnDamaged(int value) => HpNow.Value = HpNow.Value - value >= 0 ? HpNow.Value - value : 0;
    }
}