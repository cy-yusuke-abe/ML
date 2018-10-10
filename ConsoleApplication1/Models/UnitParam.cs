using System;
using System.Collections.Generic;


namespace TestMachineLearning.Models
{
    public class UnitParam
    {
        [Flags]
        public enum PlayerState
        {
            Normal = 0,
            Poisoned = 1 << 0,
            Confusing = 1 << 1,
            Stone = 1 << 2,
            Silence = 1 << 3
        }

        /// <summary>
        /// HP
        /// </summary>
        public long HitPoint;

        /// <summary>
        /// SP
        /// </summary>
        public long SkillPoint;

        /// <summary>
        /// 状態
        /// </summary>
        public PlayerState State;

        /// <summary>
        /// スキルIDのリスト
        /// </summary>
        public int[] SkillIds =
        {
            1,
            2
        };
    }
}