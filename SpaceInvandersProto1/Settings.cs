using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceInvandersProto1
{

    public static class Difficulty
    {
        public static int SetHP(int input)
        {

            int hp = 10;
            switch (input)
            {
                case 1:
                    hp = 10;
                    break;
                case 2:
                    hp = 15;
                    break;
                case 3:
                    hp = 20;
                    break;
                default:
                    break;
            }
            return hp;
        }
        public static int SetEnemyNumber(int input)
        {

            int enemyNumber = 10;
            switch (input)
            {
                case 1:
                    enemyNumber = 10;
                    break;
                case 2:
                    enemyNumber = 15;
                    break;
                case 3:
                    enemyNumber = 20;
                    break;
                default:
                    break;
            }
            return enemyNumber;
        }

        class Enemies
        {
            int health = Difficulty.SetHP(1);
        }

        public static int SetDifficulty(int input)
        {

            int DifficultySetting = 1;
            switch (input)
            {
                case 1:
                    DifficultySetting = 1;
                    break;
                case 2:
                    DifficultySetting = 2;
                    break;
                case 3:
                    DifficultySetting = 3;
                    break;
                default:
                    DifficultySetting = 2;
                    break;
            }
            return DifficultySetting;
        }

    }
}
