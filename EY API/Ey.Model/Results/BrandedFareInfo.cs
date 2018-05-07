using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Model.Results
{
    public class BrandedFareInfo
    {
        public Baggage baggage { get; set; }
        public Brandbasedattribute brandBasedAttribute1 { get; set; }
        public Brandbasedattribute brandBasedAttribute2 { get; set; }
        public Changenoshow changeNoShow { get; set; }
        public Changetravel changeTravel { get; set; }
        public Chauffeur chauffeur { get; set; }
        public Checkin checkIn { get; set; }
        public Marketbasedattribute marketBasedAttribute1 { get; set; }
        public Marketbasedattribute marketBasedAttribute2 { get; set; }
        public Milesearned milesEarned { get; set; }
        public Preferredseat preferredSeat { get; set; }
        public Refund refund { get; set; }
        public Refundnoshow refundNoShow { get; set; }
        public Upgrade upgrade { get; set; }

        public int SegmentId { get; set; }

        public class Baggage
        {
            public string fiValues { get; set; }
            public string gfValues { get; set; }
            public string gjValues { get; set; }
            public string gyValues { get; set; }
            public string header { get; set; }
            public Isenabled isEnabled { get; set; }
            public string jbValues { get; set; }
            public string jfValues { get; set; }
            public string jsValues { get; set; }
            public string trValues { get; set; }
            public string ybValues { get; set; }
            public string yfValues { get; set; }
            public string ysValues { get; set; }
            public string yvValues { get; set; }
            public string attributePosition { get; set; }
        }

        public class Isenabled
        {
            public bool business { get; set; }
            public bool economy { get; set; }
            public bool first { get; set; }
            public bool residence { get; set; }
        }

        public class Brandbasedattribute
        {
            public string fiValues { get; set; }
            public string gfValues { get; set; }
            public string gjValues { get; set; }
            public string gyValues { get; set; }
            public string header { get; set; }
            public Isenabled isEnabled { get; set; }
            public string jbValues { get; set; }
            public string jfValues { get; set; }
            public string jsValues { get; set; }
            public string trValues { get; set; }
            public string ybValues { get; set; }
            public string yfValues { get; set; }
            public string ysValues { get; set; }
            public string yvValues { get; set; }
            public string attributePosition { get; set; }
        }

        public class Changenoshow
        {
            public changeValues fiValues { get; set; }
            public changeValues gfValues { get; set; }
            public changeValues gjValues { get; set; }
            public changeValues gyValues { get; set; }
            public string header { get; set; }
            public Isenabled isEnabled { get; set; }
            public changeValues jbValues { get; set; }
            public changeValues jfValues { get; set; }
            public changeValues jsValues { get; set; }
            public changeValues trValues { get; set; }
            public changeValues ybValues { get; set; }
            public changeValues yfValues { get; set; }
            public changeValues ysValues { get; set; }
            public changeValues yvValues { get; set; }
            public string attributePosition { get; set; }
        }

        public class changeValues
        {
            public string changeable { get; set; }
            public string charge { get; set; }
            public bool isChangeable { get; set; }
            public bool isRefundable { get; set; }
        }

        public class ErnedValues
        {
            public string codeshare { get; set; }
            public string etihad { get; set; }
        }
        public class Changetravel
        {
            public changeValues fiValues { get; set; }
            public changeValues gfValues { get; set; }
            public changeValues gjValues { get; set; }
            public changeValues gyValues { get; set; }
            public string header { get; set; }
            public Isenabled isEnabled { get; set; }
            public changeValues jbValues { get; set; }
            public changeValues jfValues { get; set; }
            public changeValues jsValues { get; set; }
            public changeValues trValues { get; set; }
            public changeValues ybValues { get; set; }
            public changeValues yfValues { get; set; }
            public changeValues ysValues { get; set; }
            public changeValues yvValues { get; set; }
            public string attributePosition { get; set; }
        }

        public class Chauffeur
        {
            public string fiValues { get; set; }
            public string gfValues { get; set; }
            public string gjValues { get; set; }
            public string gyValues { get; set; }
            public string header { get; set; }
            public Isenabled isEnabled { get; set; }
            public string jbValues { get; set; }
            public string jfValues { get; set; }
            public string jsValues { get; set; }
            public string trValues { get; set; }
            public string ybValues { get; set; }
            public string yfValues { get; set; }
            public string ysValues { get; set; }
            public string yvValues { get; set; }
            public string attributePosition { get; set; }
        }

        public class Checkin
        {
            public string fiValues { get; set; }
            public string gfValues { get; set; }
            public string gjValues { get; set; }
            public string gyValues { get; set; }
            public string header { get; set; }
            public Isenabled isEnabled { get; set; }
            public string jbValues { get; set; }
            public string jfValues { get; set; }
            public string jsValues { get; set; }
            public string trValues { get; set; }
            public string ybValues { get; set; }
            public string yfValues { get; set; }
            public string ysValues { get; set; }
            public string yvValues { get; set; }
            public string attributePosition { get; set; }
        }

        public class Marketbasedattribute
        {
            public changeValues fiValues { get; set; }
            public changeValues gfValues { get; set; }
            public changeValues gjValues { get; set; }
            public changeValues gyValues { get; set; }
            public string header { get; set; }
            public Isenabled isEnabled { get; set; }
            public changeValues jbValues { get; set; }
            public changeValues jfValues { get; set; }
            public changeValues jsValues { get; set; }
            public changeValues trValues { get; set; }
            public changeValues ybValues { get; set; }
            public changeValues yfValues { get; set; }
            public changeValues ysValues { get; set; }
            public changeValues yvValues { get; set; }
            public string attributePosition { get; set; }
        }

        public class Milesearned
        {
            public ErnedValues fiValues { get; set; }
            public ErnedValues gfValues { get; set; }
            public ErnedValues gjValues { get; set; }
            public ErnedValues gyValues { get; set; }
            public string header { get; set; }
            public Isenabled isEnabled { get; set; }
            public ErnedValues jbValues { get; set; }
            public ErnedValues jfValues { get; set; }
            public ErnedValues jsValues { get; set; }
            public ErnedValues trValues { get; set; }
            public ErnedValues ybValues { get; set; }
            public ErnedValues yfValues { get; set; }
            public ErnedValues ysValues { get; set; }
            public ErnedValues yvValues { get; set; }
            public string attributePosition { get; set; }
        }

        public class Preferredseat
        {
            public string fiValues { get; set; }
            public string gfValues { get; set; }
            public string gjValues { get; set; }
            public string gyValues { get; set; }
            public string header { get; set; }
            public Isenabled isEnabled { get; set; }
            public string jbValues { get; set; }
            public string jfValues { get; set; }
            public string jsValues { get; set; }
            public string trValues { get; set; }
            public string ybValues { get; set; }
            public string yfValues { get; set; }
            public string ysValues { get; set; }
            public string yvValues { get; set; }
            public string attributePosition { get; set; }
        }

        public class Refund
        {
            public changeValues fiValues { get; set; }
            public changeValues gfValues { get; set; }
            public changeValues gjValues { get; set; }
            public changeValues gyValues { get; set; }
            public string header { get; set; }
            public Isenabled isEnabled { get; set; }
            public changeValues jbValues { get; set; }
            public changeValues jfValues { get; set; }
            public changeValues jsValues { get; set; }
            public changeValues trValues { get; set; }
            public changeValues ybValues { get; set; }
            public changeValues yfValues { get; set; }
            public changeValues ysValues { get; set; }
            public changeValues yvValues { get; set; }
            public string attributePosition { get; set; }
        }
        public class Refundnoshow
        {
            public changeValues fiValues { get; set; }
            public changeValues gfValues { get; set; }
            public changeValues gjValues { get; set; }
            public changeValues gyValues { get; set; }
            public string header { get; set; }
            public Isenabled isEnabled { get; set; }
            public changeValues jbValues { get; set; }
            public changeValues jfValues { get; set; }
            public changeValues jsValues { get; set; }
            public changeValues trValues { get; set; }
            public changeValues ybValues { get; set; }
            public changeValues yfValues { get; set; }
            public changeValues ysValues { get; set; }
            public changeValues yvValues { get; set; }
            public string attributePosition { get; set; }
        }

        public class Upgrade
        {
            public string fiValues { get; set; }
            public string gfValues { get; set; }
            public string gjValues { get; set; }
            public string gyValues { get; set; }
            public string header { get; set; }
            public Isenabled isEnabled { get; set; }
            public string jbValues { get; set; }
            public string jfValues { get; set; }
            public string jsValues { get; set; }
            public string trValues { get; set; }
            public string ybValues { get; set; }
            public string yfValues { get; set; }
            public string ysValues { get; set; }
            public string yvValues { get; set; }
            public string attributePosition { get; set; }
        }
    }
}