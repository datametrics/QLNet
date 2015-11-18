﻿/*
 Copyright (C) 2008 Siarhei Novik (snovik@gmail.com)
  
 This file is part of QLNet Project https://github.com/amaggiulli/qlnet

 QLNet is free software: you can redistribute it and/or modify it
 under the terms of the QLNet license.  You should have received a
 copy of the license along with this program; if not, license is  
 available online at <http://qlnet.sourceforge.net/License.html>.
  
 QLNet is a based on QuantLib, a free-software/open-source library
 for financial quantitative analysts and developers - http://quantlib.org/
 The QuantLib license is available online at http://quantlib.org/license.shtml.
 
 This program is distributed in the hope that it will be useful, but WITHOUT
 ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 FOR A PARTICULAR PURPOSE.  See the license for more details.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNet {
    //! Black-Scholes-Merton differential operator
    /*! \ingroup findiff

        \test coefficients are tested against constant BSM operator
    */
    public static class OperatorFactory {
        public static TridiagonalOperator getOperator(GeneralizedBlackScholesProcess process, Vector grid,
                                                      double residualTime, bool timeDependent) {
            if (timeDependent)
                //! Black-Scholes-Merton differential operator
                /*! \ingroup findiff

                    \test coefficients are tested against constant BSM operator
                */
                return new PdeOperator<PdeBSM>(grid, process, residualTime);
            else
                return new BSMOperator(grid, process, residualTime);
        }
        public static TridiagonalOperator getOperator(OneFactorModel.ShortRateDynamics process, Vector grid) {
            throw new NotImplementedException();
            //! Interest-rate single factor model differential operator
            //return new PdeOperator<PdeShortRate>(grid, process);
        }
    }
}