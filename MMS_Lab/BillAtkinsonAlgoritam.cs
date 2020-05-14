using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;



//-----------------------------------------------------------------------------
// Uradio sam samo zadatak 6) E. Hafmanov algoritam nisam uspeo da implementiram
//
// U slucaju problema, na ovom linku imate celu verziju projekta: 
//
//  https://github.com/Jakov1970/MMS-Lab4
//
//------------------------------------------------------------------------------


namespace MMS
{
    public class BillAtkinsonAlgoritam : DitheringBase
    {
        public BillAtkinsonAlgoritam(FindColor colorfunc, 
            bool useFastMode = false) : base(colorfunc, useFastMode: useFastMode)
        {
            this.methodLongName = "BillAtkinson"; this.fileNameAddition = "_SIE";
        }

        override protected void PushError(int x, int y, short[] quantError)
        {
            // Push error
            //       X     1/8   1/8
            // 1/8   1/8   1/8  
            //       1/8   

            int xMinusOne = x - 1;
            int xPlusOne = x + 1;
            int xPlusTwo = x + 2;
            int yPlusOne = y + 1;
            int yPlusTwo = y + 2;
                        
            int trenutniRed = y;
            if (this.IsValidCoordinate(xPlusOne, trenutniRed))
            {
                this.ModifyImageWithErrorAndMultiplier(xPlusOne, trenutniRed, quantError, 1.0f / 8.0f);
            }

            if (this.IsValidCoordinate(xPlusTwo, trenutniRed))
            {
                this.ModifyImageWithErrorAndMultiplier(xPlusTwo, trenutniRed, quantError, 1.0f / 8.0f);
            }

            // Next row
            trenutniRed = yPlusOne;
            if (this.IsValidCoordinate(xMinusOne, trenutniRed))
            {
                this.ModifyImageWithErrorAndMultiplier(xMinusOne, trenutniRed, quantError, 1.0f / 8.0f);
            }

            if (this.IsValidCoordinate(x, trenutniRed))
            {
                this.ModifyImageWithErrorAndMultiplier(x, trenutniRed, quantError, 1.0f / 8.0f);
            }

            if (this.IsValidCoordinate(xPlusOne, trenutniRed))
            {
                this.ModifyImageWithErrorAndMultiplier(xPlusOne, trenutniRed, quantError, 1.0f / 8.0f);
            }

            // Next row
            trenutniRed = yPlusTwo;
            if (this.IsValidCoordinate(x, trenutniRed))
            {
                this.ModifyImageWithErrorAndMultiplier(x, trenutniRed, quantError, 1.0f / 8.0f);
            }

        }
    }
}
