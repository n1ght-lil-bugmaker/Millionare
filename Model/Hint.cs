using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionare.Model
{
    class Hint
    {
        private bool _isUsed;
        public Hint()
        {
            _isUsed = false;
        }

        public event Action ToUse;

        public void Use()
        {
            if(_isUsed)
            {
                throw new NotImplementedException("The hint has already been used");
            }

            ToUse();
            _isUsed = true;
        }
        
    }
}
