﻿using AlgorythmLab2.Model;
using AlgorythmLab2.View;

namespace AlgorythmLab2.ViewModel
{
    public class FractalDrawer
    {
        public FractalDrawer(FractalWindow fractalWindow, int depth)
        {
            double midX = fractalWindow.Width / 2;
            double midY = fractalWindow.Height / 2;
            CoordinateCalculator calculator = new CoordinateCalculator(depth);
            calculator.Execute(midX, midY);
            foreach (var line in calculator.StarsPolylines)
            {
                fractalWindow.image.Children.Add(line);
            }
        }
    }
}