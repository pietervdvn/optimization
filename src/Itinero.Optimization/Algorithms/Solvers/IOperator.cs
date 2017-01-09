﻿// Itinero.Optimization - Route optimization for .NET
// Copyright (C) 2016 Abelshausen Ben
// 
// This file is part of Itinero.
// 
// Itinero is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// Itinero is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Itinero. If not, see <http://www.gnu.org/licenses/>.

namespace Itinero.Optimization.Algorithms.Solvers
{
    /// <summary>
    /// Abstract representation of a heuristic/solver operator that is applied to a single instance and may lead to better/worse solution.
    /// </summary>
    public interface IOperator<TWeight, TProblem, TObjective, TSolution, TFitness>
        where TWeight : struct
    {
        /// <summary>
        /// Returns the name of the operator.
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// Returns true if the given object is supported.
        /// </summary>
        /// <returns></returns>
        bool Supports(TObjective objective);

        /// <summary>
        /// Returns true if there was an improvement, false otherwise.
        /// </summary>
        /// <param name="delta">The difference between the fitness value before and after the operation. The new fitness value can be calculated by subtracting the delta value from the old fitness value. This means a delta > 0 means an improvement in fitness when lower is better.</param>
        /// <returns></returns>
        bool Apply(TProblem problem, TObjective objective, TSolution solution, out TFitness delta);
    }
}