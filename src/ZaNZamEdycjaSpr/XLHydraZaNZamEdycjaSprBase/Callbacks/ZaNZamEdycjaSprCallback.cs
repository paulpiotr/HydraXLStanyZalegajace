#region using

using System;
using System.Windows.Forms;
using Hydra;

#endregion

[assembly: CallbackAssemblyDescription(
    "Stany zalegające w zakładce zamówienia.",
    "Stany zalegające w zakładce zamówienia, dodatek do importu w dla programu XL.",
    "ISK Sp Z o.o. [piotr.paul@isk.com.pl] [paul.piotr@gmail.com]",
    "1.0",
    "2019.3.0.0",
    "25-01-2021")]

namespace ZaNZamEdycjaSpr.XLHydraZaNZamEdycjaSprBase.Callbacks
{
    [SubscribeProcedure(Procedures.ZaNZamEdycjaSpr, "Stany zalegające w zakładce zamówienia.")]
    public class ZaNZamEdycjaSprCallback : Callback
    {
        public override void Init()
        {
            try
            {
                AddSubscription(true, 0, Events.JustAfterWindowOpening,
                    new XLHydraZaNZamEdycjaSprChild.Callbacks.ZaNZamEdycjaSprCallback(this).JustAfterWindowOpening);
                AddSubscription(false, 0, Events.OpenWindow,
                    new XLHydraZaNZamEdycjaSprChild.Callbacks.ZaNZamEdycjaSprCallback(this).OnOpenWindow);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public override void Cleanup()
        {
        }
    }
}
