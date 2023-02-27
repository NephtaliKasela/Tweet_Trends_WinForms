using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IState_Repository
    {
        public List<State> Read_States_Coordinates(string path);
    }
}
