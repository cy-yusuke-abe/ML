using TestMachineLearning.Models;

namespace TestMachineLearning.Services
{
    public class GetEnvironmentService
    {
        /// <summary>
        /// 無作為に環境を取得する
        /// </summary>
        /// <returns></returns>
        public Environment[] GetEnvironments()
        {
            // TODO : サーバからプレイやデータを取得する。 or 組み込み
            var envA = new Environment()
            {
                Player = new UnitParam()
                {
                    HitPoint = 100,
                    SkillPoint = 3
                },
                Enemy = new UnitParam()
                {
                    HitPoint = 20,
                    SkillPoint = 5
                }
            };

            var envB = new Environment()
            {
                Player = new UnitParam()
                {
                    HitPoint = 120,
                    SkillPoint = 8
                },
                Enemy = new UnitParam()
                {
                    HitPoint = 100,
                    SkillPoint = 20
                }
            };

            return new Environment[]
            {
                envA, envB
            };
        }

        /// <summary>
        /// 指定したプレイヤと敵の環境を取得する
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="enemyId"></param>
        /// <returns></returns>
        public Environment GetEnvironment(int playerId, int enemyId)
        {
            return new Environment()
            {
                Player = new UnitParam()
                {
                    HitPoint = 80,
                    SkillPoint = 1,
                },
                Enemy = new UnitParam()
                {
                    HitPoint = 10,
                    SkillPoint = 3
                }
            };
        }
    }
}