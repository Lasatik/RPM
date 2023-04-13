// https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Gryppa
    {
        private readonly string name;
        public string Name { get => name; }

        private readonly string shortname;
        public string Shortname { get => shortname; }

        private readonly byte chislennost;
        public byte Chislennost { get => chislennost; }

        private readonly short yearPostyp;
        public short YearPostyp { get => yearPostyp; }

        private readonly Specialnost specialnost;
        public Specialnost Specialnost { get => specialnost; }


        private readonly Sotrydnik classleader;
        public Sotrydnik ClassLeader { get => classleader; }

        public Gryppa(string name, string shortname, byte chislennost, short yearPostyp, Specialnost specialnost, Sotrydnik classleader)
        {
            this.name = name;
            this.shortname = shortname;
            this.chislennost = chislennost;
            this.yearPostyp = yearPostyp;
            this.specialnost = specialnost;
            this.classleader = classleader;
        }
    }
}
