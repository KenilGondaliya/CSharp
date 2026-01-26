using System;


namespace MyApp.Interface
{
    public class NiceCar
    {

        private IEngine engine;
        private IMedia player = new CdPlayer();

        public NiceCar()
        {
            engine = new PowerEngine();
        }

        public NiceCar(IEngine engine)
        {
            this.engine = engine;
        }




        public void StartMusic()
        {
            player.Start();
        }
        public void StoptMusic()
        {
            player.Stop();
        }

        public void StartEngine()
        {
            engine.Start();
        }

        public void StopEngine()
        {
            engine.Stop();
        }

        public void UpgradeEngine(IEngine engine)
        {
            this.engine = engine;
        }
    }
}