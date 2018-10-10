using System;
using TestMachineLearning.Services;

namespace TestMachineLearning
{
    internal class Entry
    {
        private const int TrainTimes = 1000;

        /// <summary>
        /// 強化学習によって学習したAIを使い、指定したクエストを試す
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("[usage] Program <Quest Master ID>");
                return;
            }
            var questMasterId = int.Parse(args[0]);

            var envService = new GetEnvironmentService();

            // ================================================================
            // 学習
            // ================================================================
            var envs = envService.GetEnvironments();

            var trainService = new TrainService();
            var network = trainService.Train(envs, TrainTimes);

            // ================================================================
            // 結果出力
            // ================================================================
            var env = envService.GetEnvironment(1, 100);

            var computeService = new ComputeService();
            computeService.Compute(network, env, questMasterId);
        }

    }
}