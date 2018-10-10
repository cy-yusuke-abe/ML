using System;

namespace TestMachineLearning.Models
{
    public class Skill
    {
        [Flags]
        public enum SkillTargetType
        {
            Self,
            Ally,
            Opponent,
            AllyGroup,
            OpponentGroup,
            AreaExAlly,
            AreaExOpponent,
            Area
        }

        /// <summary>
        /// コスト
        /// </summary>
        public int Cost;

        /// <summary>
        /// 対象のパラメータ
        /// </summary>
        public string TargetParameter;

        /// <summary>
        /// 属性
        /// </summary>
        public Attribute Attrribute;

        /// <summary>
        /// 効果最小値
        /// </summary>
        public int EffectMin;

        /// <summary>
        /// 効果最大値
        /// </summary>
        public int EffectMax;

        /// <summary>
        /// 対象のタイプ
        /// </summary>
        public SkillTargetType TargetType;
    }
}