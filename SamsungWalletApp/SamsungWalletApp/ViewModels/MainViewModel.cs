using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungWalletApp.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Onboadings = GetOnBoarding();
        }

        public List<Onboadings> Onboadings { get; set; }
        private List<Onboadings> GetOnBoarding()
        {
            return new List<Onboadings>
            {
                new Onboadings{Heading = "Create events in minutes", Caption = "From small birethday parties whit friends to large community event."},
                new Onboadings{Heading = "Mange all your events in one single place", Caption = "FromMange all your events in one single place to always get remionder."},
                new Onboadings{Heading = "Explore events around you", Caption = "Select any event that intereset you a list awesome avents."}
            };
        }
    }

    public class Onboadings
    {
        public string Heading { get; set; }
        public string Caption { get; set; }
    }
}
