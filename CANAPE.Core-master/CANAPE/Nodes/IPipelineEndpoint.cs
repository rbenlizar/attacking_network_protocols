//    CANAPE Core Network Testing Library
//    Copyright (C) 2017 James Forshaw
//    Based in part on CANAPE Network Testing Tool
//    Copyright (C) 2014 Context Information Security
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using CANAPE.DataAdapters;

namespace CANAPE.Nodes
{
    /// <summary>
    /// Interface for a pipeline endpoint
    /// </summary>
    public interface IPipelineEndpoint
    {
        /// <summary>
        /// Get or set the data adapter
        /// </summary>
        IDataAdapter Adapter { get; set; }
        
        /// <summary>
        /// Start the node
        /// </summary>        
        void Start();

        /// <summary>
        /// Event signaled when data is received
        /// </summary>
        event EventHandler DataRecieved;
    }
}
