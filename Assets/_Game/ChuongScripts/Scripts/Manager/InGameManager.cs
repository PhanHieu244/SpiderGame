using System;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace ChuongCustom
{
    public class InGameManager : Singleton<InGameManager>
    {
        [SerializeField] public int PriceToPrice = 1;

        private void Start()
        {
            ScoreManager.Reset();
        }

        [Button]
        public void Win()
        {
            Manager.ScreenManager.OpenScreen(ScreenType.Result);
            //todo:
        }

        [Button]
        public void Lose()
        {
            Manager.ScreenManager.OpenScreen(ScreenType.Lose);
            //todo:
        }

        [Button]
        public void BeforeLose()
        {
            Manager.ScreenManager.OpenScreen(ScreenType.BeforeLose);
            //todo:
        }

        public void Retry()
        {
            //retry
            //todo:
        }

        public void Continue()
        {
            //continue

            //todo:
        }

        private void OnEnable()
        {
            OnGameStart();
        }

        private void OnGameStart()
        {
            ScoreManager.Score = 0;
        }

        public void OnLose()
        {
            ScoreManager.OnUpdateHighScore();
            ScreenManager.Instance.OpenScreen(ScreenType.BeforeLose);
            Time.timeScale = 0f;
            transform.DOKill();
        }
        

        public void Revive()
        {
            Time.timeScale = 1f;
            transform.DOKill();
        }

        private void OnDisable()
        {
            Time.timeScale = 1f;
        }
    }
    
}