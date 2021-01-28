#region using

using System;
using System.Windows.Forms;
using Hydra;

#endregion

[assembly: CallbackAssemblyDescription(
    "Stany zalegające w HydraXLStanyZalegajace.XLHydraBase",
    "Stany zalegające w HydraXLStanyZalegajace.XLHydraBase okno podstawowe, dodatek do importu w dodatkach programu XL",
    "ISK Sp Z o.o. [piotr.paul@isk.com.pl]",
    "1.0",
    "2019.3.0.0",
    "25-01-2021")]

namespace HydraXLStanyZalegajace.XLHydraBase.Callbacks
{
    [SubscribeProcedure(Procedures.ZaNOfeEdycja, "Stany zalegające w HydraXLStanyZalegajace.XLHydraBase")]
    public class ZaNOfeEdycjaCallback : Callback
    {
        public override void Init()
        {
            try
            {
                AddSubscription(true, 0, Events.JustAfterWindowOpening,
                    new XLHydraChild.Callbacks.ZaNOfeEdycjaCallback(this).JustAfterWindowOpening);
                AddSubscription(false, 0, Events.OpenWindow,
                    new XLHydraChild.Callbacks.ZaNOfeEdycjaCallback(this).OnOpenWindow);
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
