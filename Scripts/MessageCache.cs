using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Common;
using Sandbox.Definitions;
using Sandbox.Engine;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using SpaceEngineers.Game.ModAPI.Ingame;
using Sandbox.Game;
using VRage.Game;
using VRageMath;

namespace MessageCache {

    class Program : MyGridProgram {

        /// <summary>
        /// CustomData is a filter - only progBlocks containing the value of CustomData are signalled
        /// </summary>

        #region export to game

        
        public void Main( string argument ) {
            Me.CustomData += argument;
        }

        #endregion



    }



}