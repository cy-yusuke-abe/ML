using TestMachineLearning.Models;

namespace TestMachineLearning.Simulator
{
    public class DummySimulator : ISimulator
    {
        /// <summary>
        /// 入力層の次元数
        /// </summary>
        public int NumInputDimensions => 6;

        /// <summary>
        /// 出力層の次元数
        /// </summary>
        public int NumOutputDimensions => 2;

        /// <summary>
        /// ゲームを実行する
        /// </summary>
        /// <param name="environment"></param>
        /// <returns></returns>
        public SimulateResult Simulate(Environment environment)
        {
            var inputs = GetInputLayers(environment);
            var outputs = SimulateInner(environment);

            return new SimulateResult()
            {
                Inputs = inputs,
                Outputs = outputs
            };
        }

        private double[][] GetInputLayers(Environment env)
        {
            // TODO : 使用に合わせてパラメータを増やす
            return new []
            {
                new []
                {
                    (double) (int) env.Player.State,
                    env.Player.HitPoint,
                    env.Player.SkillPoint,

                    (double) (int) env.Enemy.State,
                    env.Enemy.HitPoint,
                    env.Enemy.SkillPoint
                }
            };
        }

        private double[][] SimulateInner(Environment env)
        {
            // TODO : 可能な行動の組み合わせを実行する
            // TODO : APIかC#のコードを使ってゲームのシミュレーションを行い、結果を返す
            return new []
            {
                new [] {1.0, 0.0}
            };
        }
    }
}