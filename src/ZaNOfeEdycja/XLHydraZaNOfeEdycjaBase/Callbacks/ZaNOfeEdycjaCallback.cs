#region using

using System;
using System.Windows.Forms;
using Hydra;

#endregion

[assembly: CallbackAssemblyDescription(
    "Stany zalegające w zakładce oferty.",
    "Stany zalegające w zakładce oferty, dodatek do importu w dla programu XL.",
    "ISK Sp Z o.o. [piotr.paul@isk.com.pl] [paul.piotr@gmail.com]",
    "1.0",
    "2019.3.0.0",
    "25-01-2021")]

namespace ZaNOfeEdycja.XLHydraZaNOfeEdycjaBase.Callbacks
{
    [SubscribeProcedure(Procedures.ZaNOfeEdycja, "Stany zalegające w zakładce oferty.")]
    public class ZaNOfeEdycjaCallback : Callback
    {
        public override void Init()
        {
            try
            {
                AddSubscription(true, 0, Events.JustAfterWindowOpening,
                    new XLHydraZaNOfeEdycjaChild.Callbacks.ZaNOfeEdycjaCallback(this).JustAfterWindowOpening);
                AddSubscription(false, 0, Events.OpenWindow,
                    new XLHydraZaNOfeEdycjaChild.Callbacks.ZaNOfeEdycjaCallback(this).OnOpenWindow);
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
