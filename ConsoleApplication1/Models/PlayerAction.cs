
namespace TestMachineLearning.Models
{
    public class PlayerAction
    {
        public enum ActionKind
        {
            /// <summary>
            /// 攻撃
            /// </summary>
            Attack,

            /// <summary>
            /// スキル
            /// </summary>
            UseSkill,

            /// <summary>
            /// 行動の種類
            /// </summary>
            NumKinds
        }

        public readonly ActionKind Kind;

        public readonly object Parameter;

        public PlayerAction(ActionKind kind)
        {
            Kind = kind;
            Parameter = null;
        }

        public PlayerAction(ActionKind kind, object parameter)
        {
            Kind = kind;
            Parameter = parameter;
        }
    }
}