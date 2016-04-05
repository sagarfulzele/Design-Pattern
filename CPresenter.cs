﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVP
{
    public class CPresenter
    {
        IView mview;
        public CPresenter(IView view)
        {
            mview = view;
        }
        public double CalculateCircleArea()
        {
            CModel model = new CModel();
            mview.ResultText = model.getArea(double.Parse(mview.RadiusText)).ToString();
            return Convert.ToDouble(mview.ResultText.ToString());
        }
    }
}