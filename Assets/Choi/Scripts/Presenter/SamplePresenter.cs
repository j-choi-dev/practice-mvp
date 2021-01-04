using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Choi.View;
using Choi.Model;


namespace Choi.Presenter
{
    public class SamplePresenter : MonoBehaviour
    {
        [SerializeField] private GuageView m_HPGuage;

        [SerializeField] private DamageInputFieldView m_DamageValueView;

        [SerializeField] private UnityEngine.UI.Button m_AtkButton;

        public GuageModel m_GuageModel;

        public ValueModel m_ValueModel;

        private void Awake()
        {
            m_GuageModel = new GuageModel();
            m_ValueModel = new ValueModel();
            SubscribeModel();
            SubscribeView();
        }

        private void SubscribeModel()
        {
            m_AtkButton.OnClickAsObservable().Subscribe(clk =>
            {
                m_GuageModel.OnDamaged(Random.Range(3, 10));
            });

            m_DamageValueView.Value.Subscribe(val =>
            {
                Debug.Log(val);
                m_ValueModel.SetDamaeValue(int.Parse(val));
            });
        }

        private void SubscribeView()
        {
            m_GuageModel.HpNow.Subscribe(nowHp =>
            {
                Debug.Log($"{nowHp} / {m_GuageModel.HpMax}");
                m_HPGuage.SetValue(nowHp, m_GuageModel.HpMax);
            });
        }
    }
}