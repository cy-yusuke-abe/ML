using TestMachineLearning.Models;

namespace TestMachineLearning.Simulator
{
    public interface ISimulator
    {
        /// <summary>
        /// 入力層の次元数
        /// </summary>
        int NumInputDimensions { get; }

        /// <summary>
        /// 出力層の次元数
        /// </summary>
        int NumOutputDimensions { get; }

        /// <summary>
        /// シミュレーションを行う
        /// </summary>
        /// <param name="environment"></param>
        /// <returns>結果</returns>
        /// <remarks>
        /// 指定された環境について、環境を更新しながら決着がつくまでのシミュレーションを行う
        /// </remarks>
        SimulateResult Simulate(Environment environment);
    }
}