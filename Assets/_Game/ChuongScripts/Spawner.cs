using System.Collections.Generic;
using ChuongCustom;
using UnityEngine;

namespace _Game.ChuongScripts
{
    public class Spawner : Singleton<Spawner>
    {
        [SerializeField] private CoinAddition _scoreAddition;
        [SerializeField] private List<Enemy> enemyCars;
        [SerializeField] private List<Transform> spawnPositions;
        [SerializeField] private float minTime, range;
        private float randomTime = 0.65f;
        private float elapsedTime = 0;
        
        private void Update()
        {
            if (elapsedTime < randomTime)
            {
                elapsedTime += Time.deltaTime;
                return;
            }
            Spawn();
            elapsedTime = 0f;
            randomTime = Random.Range(minTime, minTime + range);
        }

        private void Spawn()
        {
            var spawnPos = SpawnPos();
            if (Random.Range(0, 100) >= 25)
            {
                var car = Instantiate(enemyCars[Random.Range(0, enemyCars.Count)]);
                car.transform.position = spawnPos;
                return;
            }
            var scoreAddition = Instantiate(_scoreAddition);
            scoreAddition.transform.position = spawnPos;
        }

        private Vector2 SpawnPos()
        {
            return spawnPositions[Random.Range(0, spawnPositions.Count)].position;
        }
    }
}