using System;

namespace AbstractionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            DiCorEngine di_Engine = new DiCorEngine();
            TATACar _harrier = new TATACar(di_Engine);
            _harrier.Drive();
            _harrier.Halt();

            VeriCorEngine v_Engine = new VeriCorEngine();
            TATACar _nexon = new TATACar(v_Engine);
            _nexon.Drive();
            _nexon.Halt();

            MultiJetEngine m_Engine = new MultiJetEngine();
            TATACar _hexa = new TATACar(m_Engine);
            _hexa.Drive();
            _hexa.Halt();


            RevorTron r_Engine = new RevorTron();
            TATACar _safari = new TATACar(r_Engine);
            _safari.Drive();
            _safari.Halt();

        }
    }
}
