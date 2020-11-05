using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Steering
    {
		private bool _steering;

        public bool GetSteering()
        { return _steering; }
        private protected void SetSteering(bool value)
        { _steering = value; }
        public Steering()
		{

		}

		public Steering (bool IsOn)
		{
			this._steering = IsOn;
		}

		public void SteeringL()
		{
			this._steering = true;
		}

		public void SteeringR()
		{
			this._steering = false;
		}
	}
}
