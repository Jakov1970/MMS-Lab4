﻿using System;
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
    public class FloydSteinbergDithering : DitheringBase
    {
        public FloydSteinbergDithering(FindColor colorfunc, bool useFastMode = false) : base(colorfunc, useFastMode: useFastMode)
        {
            this.methodLongName = "Floyd-Steinberg";
            this.fileNameAddition = "_FS";
        }

        override protected void PushError(int x, int y, short[] quantError)
        {
            // Push error
            // 			X		7/16
            // 3/16		5/16	1/16

            int xMinusOne = x - 1;
            int xPlusOne = x + 1;
            int yPlusOne = y + 1;

            // Current row
            if (this.IsValidCoordinate(xPlusOne, y))
            {
                this.ModifyImageWithErrorAndMultiplier(xPlusOne, y, quantError, 7.0f / 16.0f);
            }

            // Next row
            if (this.IsValidCoordinate(xMinusOne, yPlusOne))
            {
                this.ModifyImageWithErrorAndMultiplier(xMinusOne, yPlusOne, quantError, 3.0f / 16.0f);
            }

            if (this.IsValidCoordinate(x, yPlusOne))
            {
                this.ModifyImageWithErrorAndMultiplier(x, yPlusOne, quantError, 5.0f / 16.0f);
            }

            if (this.IsValidCoordinate(xPlusOne, yPlusOne))
            {
                this.ModifyImageWithErrorAndMultiplier(xPlusOne, yPlusOne, quantError, 1.0f / 16.0f);
            }
        }
    }
}
