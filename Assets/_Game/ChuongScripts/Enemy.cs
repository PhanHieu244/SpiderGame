using ChuongCustom;
using UnityEngine;

namespace _Game.ChuongScripts
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private int speed = -5;
        private void Update()
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag.Equals("player"))
            {
                InGameManager.Instance.OnLose();
                Destroy(gameObject);
                return;
            }
            if (col.tag.Equals("destroy"))
            {
                Destroy(gameObject);
                return;
            }
        }
    }
}