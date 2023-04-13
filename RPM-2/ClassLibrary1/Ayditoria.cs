// https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ayditoria
    {
        private readonly string nazvanie;
        public string Nazvanie { get => nazvanie; }

        private readonly Sotrydnik otvetstvenni;
        public Sotrydnik Otvetstvenni { get => otvetstvenni; }

        private readonly byte posadMesta;
        public byte PosadMesta { get => posadMesta; }

        private readonly byte kolvoOkon;
        public byte KolvoOkon { get => kolvoOkon; }

        private readonly Oborudovanie oborudovanie;
        public Oborudovanie Oborudovanie { get => oborudovanie; }

        public Ayditoria(string nazvanie, Sotrydnik otvetstvenni, byte posadMesta, byte kolvoOkon, Oborudovanie oborudovanie)
        {
            this.nazvanie = nazvanie;
            this.otvetstvenni = otvetstvenni;
            this.posadMesta = posadMesta;
            this.kolvoOkon = kolvoOkon;
            this.oborudovanie = oborudovanie;
        }
    }
}