using System;
using System.Collections.Generic;
using System.Text;
// b) Seuraavaksi, toteuta ohjelmaan IAction rajapinta, ja luo sille funktio: public void Action(Button b)
namespace Exercise7
{
    interface IAction
    {
        public void Action(Button b);
    }
}
