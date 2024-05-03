using UnityEngine;
using UnityEngine.EventSystems;

namespace _Game.ChuongScripts.Scripts
{
    public class Input : MonoBehaviour ,IPointerDownHandler, IPointerUpHandler
    {
        public void OnPointerDown(PointerEventData eventData)
        {
            Player.Instance.MoveDown();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            Player.Instance.MoveUp();
        }
    }
}