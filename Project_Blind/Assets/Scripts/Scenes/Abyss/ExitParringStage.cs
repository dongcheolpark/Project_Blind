using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blind.Abyss
{
    public class ExitParringStage : ExitPointStage
    {
        [SerializeField] private Wall _leaveWall;
        private PlayerCharacter player;
        private bool isClear = false;
        public GameObject monster;
        protected override void Awake()
        {
            _leaveWall.Enable();
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCharacter>();
            base.Awake();

        }

        private void Update()
        {
            if(player.isParingCheck)
            {
                _leaveWall.Disable();
                isClear = true;
                Debug.Log("wall disabled");
            }
            if(!monster.activeSelf && !isClear)
            {
                monster.GetComponent<CrowdEnemyCharacter>().Reset();
            }
        }
    }
}
