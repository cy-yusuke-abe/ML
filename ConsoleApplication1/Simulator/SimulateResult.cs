
namespace TestMachineLearning.Simulator
{
    public class SimulateResult
    {
        /// <summary>
        /// 入力層の次元数
        /// </summary>
        public int NumInputDimensions
        {
            get
            {
                return Inputs[0].Length;
            }
        }

        /// <summary>
        /// 出力層の次元数
        /// </summary>
        public int NumOutputDimensions
        {
            get
            {
                return Outputs[0].Length;
            }
        }

        /// <summary>
        /// 入力層
        /// </summary>
        public double[][] Inputs;

        /// <summary>
        /// 出力層
        /// </summary>
        public double[][] Outputs;
    }
}