using Accord.Neuro.Learning;
using Accord.Neuro.Networks;
using TestMachineLearning.Models;
using TestMachineLearning.Simulator;

namespace TestMachineLearning.Services
{
    /// <summary>
    /// RNNによる機械学習を行う
    /// </summary>
    /// <remarks>
    /// 関連するパラメータを入力し、行動に対する評価を出力とする。
    /// </remarks>
    public class TrainService
    {
        // TODO : DIにする？
        private ISimulator _simulator = new DummySimulator();

        /// <summary>
        /// 指定した環境で学習を行う
        /// </summary>
        /// <param name="environments">環境のリスト</param>
        /// <param name="trainCount">学習回数</param>
        /// <returns></returns>
        public DeepBeliefNetwork Train(Environment[] environments, int trainCount)
        {
            var network = new DeepBeliefNetwork(
                _simulator.NumInputDimensions,                            // 入力層の次元数
                hiddenNeurons: new [] {1, _simulator.NumOutputDimensions} // ネットワークの次元数 (隠れ層, 出力層)
            );
            var teacher = CreateTeacher(network);

            foreach (var env in environments)
            {
                var result = _simulator.Simulate(env);

                var data = teacher.GetLayerInput(result.Inputs);
                while (trainCount-- > 0)
                {
                    teacher.RunEpoch(data, result.Outputs);
                }

                network.UpdateVisibleWeights();
            }

            return network;
        }

        private DeepNeuralNetworkLearning CreateTeacher(DeepBeliefNetwork network)
        {
            var teacher = new DeepNeuralNetworkLearning(network);

            teacher.Algorithm = (activationNetwork, index) =>
                new ParallelResilientBackpropagationLearning(activationNetwork);
            teacher.LayerIndex = network.Machines.Count - 1;

            return teacher;
        }
    }
}