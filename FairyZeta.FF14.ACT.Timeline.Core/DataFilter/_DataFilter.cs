﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FairyZeta.FF14.ACT.Timeline.Core.DataFilter
{
    /// <summary> [基底] タイムライン／データフィルタ
    /// </summary>
    public class _DataFilter
    {
      /*--- Property/Field Definitions ------------------------------------------------------------------------------------------------------------------------------*/

      /*--- Constructers --------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary> [基底] タイムライン／データフィルタ／コンストラクタ
        /// </summary>
        public _DataFilter()
        {
            this.initFilter();
        }

      /*--- Method: Initialization ----------------------------------------------------------------------------------------------------------------------------------*/
        
        /// <summary> データフィルタの初期化を実行します。
        /// </summary>
        /// <returns> 正常終了時 True </returns> 
        private bool initFilter()
        {
            return true;
        }

      /*--- Method: public ------------------------------------------------------------------------------------------------------------------------------------------*/


      /*--- Method: private -----------------------------------------------------------------------------------------------------------------------------------------*/

    }
}
