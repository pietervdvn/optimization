﻿/*
 *  Licensed to SharpSoftware under one or more contributor
 *  license agreements. See the NOTICE file distributed with this work for 
 *  additional information regarding copyright ownership.
 * 
 *  SharpSoftware licenses this file to you under the Apache License, 
 *  Version 2.0 (the "License"); you may not use this file except in 
 *  compliance with the License. You may obtain a copy of the License at
 * 
 *       http://www.apache.org/licenses/LICENSE-2.0
 * 
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

using Itinero.Optimization.Tours;

namespace Itinero.Optimization.TSP
{
    /// <summary>
    /// Contains extension method for the ITSProblem.
    /// </summary>
    public static class ITSProblemExtensions
    {

        /// <summary>
        /// Solves this TSP using a default solver.
        /// </summary>
        /// <returns></returns>
        public static Tour Solve(this ITSProblem problem)
        {
            return problem.Solve(new Solvers.EAXSolver(Algorithms.Solvers.GA.GASettings.Default));
        }

        /// <summary>
        /// Solvers this problem using the given solver.
        /// </summary>
        public static Tour Solve(this ITSProblem problem, Algorithms.Solvers.ISolver<float, ITSProblem, TSPObjective, Tour, float> solver)
        {
            return solver.Solve(problem, new TSPObjective());
        }
    }
}
