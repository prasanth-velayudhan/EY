﻿using System;
using System.ComponentModel.DataAnnotations;
using Ey.Common.Contracts.Model;

namespace Ey.Common.Model
{
    /// <summary>
    /// Ey Flight Number
    /// </summary>
    public sealed class EyFlightNumber : IFlightNumber
    {
        private int _number;

        public EyFlightNumber()
        {
            IsValid = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EyFlightNumber"/> class.
        /// </summary>
        /// <param name="number">The number.</param>
        public EyFlightNumber(string number)
        {
            IsValid = TrySetNumber(number);
        }

        public string CarrierCode
        {
            get { return Constants.EyCarrierCode; }
        }

        public string Number
        {
            get { return _number.ToString(); }
            set
            {
                IsValid = TrySetNumber(value);
            }
        }

        public bool IsValid { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            if (!IsValid)
                throw new NotSupportedException("The flight number is not valid for this carrier.");

            return CarrierCode + Number;
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public string ToString(string format)
        {
            if (!IsValid)
                throw new NotSupportedException("This flight number is not a valid for this carrier.");

            if (string.IsNullOrEmpty(format))
                throw new ArgumentNullException("format");

            return string.Format(format, CarrierCode, Number);
        }

        /// <summary>
        /// Tries the parse.
        /// </summary>
        /// <param name="flightNumberString">The flight number string.</param>
        /// <param name="flightNumber">The flight number.</param>
        /// <returns>Boolean</returns>
        public static bool TryParse(string flightNumberString, out EyFlightNumber flightNumber)
        {
            var ret = new EyFlightNumber();

            if (ret.TrySetNumber(flightNumberString))
            {
                flightNumber = ret;
                return true;
            }
            else
            {
                flightNumber = null;
                return false;    
            }
        }

        /// <summary>
        /// Tries the set number.
        /// </summary>
        /// <param name="flightNumberString">The flight number string.</param>
        /// <returns>Boolean</returns>
        private bool TrySetNumber(string flightNumberString)
        {
            int num;
            var numberString = flightNumberString.Trim();

            if (string.IsNullOrEmpty(numberString))
            {
                return false;
            }

            if (numberString.StartsWith(CarrierCode, StringComparison.InvariantCultureIgnoreCase) && numberString.Length > this.CarrierCode.Length)
            {
                numberString = numberString.Remove(0, this.CarrierCode.Length);
            }

            if (Int32.TryParse(numberString, out num))
            {
                _number = num;
                return true;
            }
            
            return false;
        }

       
    }
}