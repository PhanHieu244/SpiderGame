namespace ChuongCustom
{
    using System.Collections;
    using System.Collections.Generic;
    using ChuongCustom;
    using UnityEngine;

    public class ContButton : AButton
    {
        public bool _openShop = false;

        protected override void OnClickButton()
        {
            if (Data.Player.Coin >= Manager.InGame.PriceToPrice)
            {
                Data.Player.Coin -= Manager.InGame.PriceToPrice;
                Manager.InGame.Revive();
                Manager.ScreenManager.Back();
            }
            else
            {
                ToastManager.Instance.ShowMessageToast("Not have enough heart!!!");

                if (_openShop)
                {
                    Manager.ScreenManager.OpenScreen(ScreenType.IAPScreen);
                }
            }
        }

        protected override void OnStart()
        {
        }
    }
}