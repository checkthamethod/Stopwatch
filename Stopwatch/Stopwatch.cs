using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private TimeSpan _duration;
        private bool _isRunning = false;

        public TimeSpan TotalDuration
        {
            get
            {
                return _duration;
            }
            set { _duration += value; }
        }
        
  


        public void Start()
        {
            if (_isRunning == false)
            {
                _startTime = DateTime.Now;
                _isRunning = true;
            }
            else
            {
                throw new InvalidOperationException("Clock already running...");
            }

        }

        public void Stop()
        {
            if (_isRunning == true)
            {
                _stopTime = DateTime.Now;
                _isRunning = false;
                TotalDuration = _stopTime - _startTime;
                Console.WriteLine("Time elapsed: {0}", TotalDuration);
                
            }
            else
            {
                throw new InvalidOperationException("Clock already stopped");
            }
        }

        public void Reset()
        {
            _duration = TimeSpan.Zero;
            _startTime = DateTime.MinValue;
            _stopTime = DateTime.MinValue;
            _isRunning = false;

            Console.WriteLine(TotalDuration);
            Console.WriteLine("Time reset");
        }

        
    }
}