﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Console_Games.Tower_Sweeper_Folder.Apparel
{
    class HoundShield : Shield
    {
        //Hound Shield ->name
        //This shield lowers the enemy HP when the enemy hits the shield 
        //the damage that the shield deals is determined by the cleared towers so 20 damage per tower
        //if no tower is cleared then the shield deales 10
        //if the owner is the enemy then the damage is counted 10 damage per towers standing 
        //which means that there will be overall damage minus the cleared ones


        //Note make an abstract class for Human entity so that the enemy and player can inherit something which can be used everywhere


        //consts
        private const int DamagePerTower = 10;
        
            


        //field

        private int damage;
        private Player player;
        private Enemy enemy;
        private bool isPlayerOwner;

        private HoundShield():base("Hound Shield",100)
        {

        }

        public HoundShield(Enemy enemy,Player player,int towerNumber):this()
        {
            this.isPlayerOwner = false;
            this.enemy = enemy;
            this.damage = 10 * towerNumber;
        }

        public HoundShield(Player player):this()
        {
            this.isPlayerOwner = true;
            this.player = player;
            if (this.player.ClearedTowers == 0)
            {
                this.damage = 5;
            }
            else
            {
                this.damage = this.player.ClearedTowers * 10;
            }
            
        }



        //behaviour
        public void DetermineDamagePerTower(int numberClearedTowers)
        {
            this.damage -= (10 * numberClearedTowers);
        }

        protected override void EffectOnHit()
        {
            
        }
    }
}
