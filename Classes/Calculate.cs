using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Diagnostics;
using System.Threading;

namespace FlowModel.Classes
{
    class Calculate
    {

        public static List<double> Tp = new List<double>();
        public static List<double> hp = new List<double>();
        public static double Steps = 0;
        public static double OutQ = 0;
        public static double Timer = 0;

        // решил переписывать в каждой функуции параметры как в формулах. Чтобы было видно какие именно используются
        // при наведении на параметр после _param. будет написано что это (если ты смотришь проект)

        static public double F(Materials _param)
        {
            double H = _param.Depth;
            double W = _param.Width;

            return (0.125 * Math.Pow(H / W, 2) - 0.625 * (H / W) + 1);
        }

        static public double QCH(Materials _param)
        {
            double H = _param.Depth;
            double W = _param.Width;
            double Vu = _param.CoverSpeed;

            double _F = F(_param);

            return ((H * W * Vu)/2 * _F);
        }
        
        static public double Gamma(Materials _param)
        {
            double H = _param.Depth;
            double Vu = _param.CoverSpeed;

            return (Vu/H);
        }

        static public double qGamma(Materials _param)
        {
            double H = _param.Depth;
            double W = _param.Width;
            double Vu = _param.CoverSpeed;
            double h0 = _param.KConsistency;
            double n = _param.CurrentIndex;

            double _Gamma = Gamma(_param);

            return (H * W * h0 * Math.Pow(_Gamma, n + 1));
        }

        static public double qA(Materials _param)
        {
            double W = _param.Width;
            double au = _param.KHeatDissipation;
            double b = _param.KTemperature;
            double Tu = _param.СoverTemperature;
            double Tr = _param.CastTemperature;

            return (W * au * (Math.Pow(b,-1) - Tu + Tr));
        }

        /// <summary>
        /// Поиск температуры и вязкости
        /// </summary>
        /// <param name="Parametrs"></param>
        static public void SearchTemperatureAndViscosity(Materials _param) 
        {
            Tp.Clear();
            hp.Clear();
            Steps = _param.Step;
            double b = _param.KTemperature;
            double W = _param.Width;
            double au = _param.KHeatDissipation;
            double Tu = _param.СoverTemperature;
            double Tr = _param.CastTemperature;
            double p = _param.Density;
            double c = _param.SpecificHeat;
            double T0 = _param.MeltingPoint;
            double mu = _param.KConsistency;
            double n = _param.CurrentIndex;

            double _qGamma = qGamma(_param);
            double _Gamma = Gamma(_param);
            double _qA = qA(_param);
            double _QCH = QCH(_param);
           
            for (double z = 0; z < _param.Length; z += _param.Step)
            {

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                double T = 0; double h = 0;

                T = Tr + (1 / b) * Math.Log(((b * _qGamma + W * au) / (b * _qA)) * (1 - Math.Exp(-((b * _qA) / (p * c * _QCH)) * z )) 
                    + (Math.Exp(b * (T0 - Tr - (_qA/(p*c*_QCH)) * z))));

                Tp.Add(T);
            
                h = mu * Math.Exp(-b * (T - Tr) * Math.Pow(_Gamma, n - 1));

                hp.Add(h);
                Q(_param);

                stopWatch.Stop();
                Timer = stopWatch.ElapsedTicks;
            }
        }

        static public double Q(Materials _param)
        {
            double p = _param.Density;
            double _QCH = QCH(_param);
            OutQ = (3600 * p * _QCH);
            return OutQ;
        }

    }
}
