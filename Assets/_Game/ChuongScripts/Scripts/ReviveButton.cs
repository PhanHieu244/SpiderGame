using ChuongCustom;
using UnityEngine;

namespace _Game.ChuongScripts.Scripts
{
    public class ReviveButton : MonoBehaviour
    {
        public void Revive()
        {
            if (Data.Player.Heart <= 0)
            {
                ToastManager.Instance.ShowMessageToast("Not have enough heart!!!");
            }
            else
            {
                Data.Player.Heart--;
                InGameManager.Instance.Revive();
                ScreenManager.Instance.Back();
            }
            
        }
    }
}