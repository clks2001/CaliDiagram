﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using DiagramLib.ViewModels;
using DiagramLib.Views;

namespace DiagramLib
{
    public class DiagramLibHelpers
    {
        public void InitViewLocator()
        {
            OriginalLocateForModel = ViewLocator.LocateForModel;
            ViewLocator.LocateForModel = LocateForModel;
        }
        private Func<object, DependencyObject, object, UIElement> OriginalLocateForModel;

        private UIElement LocateForModel(object o, DependencyObject dependencyObject, object arg3)
        {
            if (o is DiagramBaseViewModel)
            {
                Type type = o.GetType();

                DiagramBaseView diagramBaseView = new DiagramBaseView();
             //   diagramBaseView.con = "asd";
                if (type.IsSubclassOf(typeof(DiagramBaseViewModel)))
                {
                    UIElement element = OriginalLocateForModel(o, dependencyObject, arg3);
                    FrameworkElement fe = element as FrameworkElement;

                    diagramBaseView.Content = fe;
                    ViewModelBinder.Bind(o, element, arg3);
                    return diagramBaseView;
                }
                return diagramBaseView;
            }
            return OriginalLocateForModel(o, dependencyObject, arg3);
        }
    }
}