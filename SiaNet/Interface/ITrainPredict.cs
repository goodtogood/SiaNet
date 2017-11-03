﻿using SiaNet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaNet.Interface
{
    /// <summary>
    /// Interface for Train and Predictions by neural network models
    /// </summary>
    public interface ITrainPredict
    {
        /// <summary>
        /// Trains the model using train data.
        /// </summary>
        /// <param name="trainData">The train data.</param>
        /// <param name="validationData">The validation data.</param>
        /// <param name="epoches">The epoches.</param>
        /// <param name="batchSize">Size of the batch.</param>
        /// <param name="OnEpochStart">The on epoch start.</param>
        /// <param name="OnEpochEnd">The on epoch end.</param>
        /// <returns></returns>
        Dictionary<string, List<double>> Train(object trainData, object validationData, int epoches, int batchSize, On_Epoch_Start OnEpochStart, On_Epoch_End OnEpochEnd);

        /// <summary>
        /// Evaluates the model test data.
        /// </summary>
        /// <param name="testData">The test data.</param>
        /// <returns></returns>
        IList<float> Evaluate(object testData);
    }
}