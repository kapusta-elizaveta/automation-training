using System;

namespace Framework.Model
{
    public class SearchQuery
    {
        public string City { get; set; }
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public string Visitors { get; set; }

        public SearchQuery(string city, string arrivalDate, 
            string departureDate, string guests)
        {
            this.City = city;
            this.ArrivalDate = arrivalDate;
            this.DepartureDate = departureDate;
            this.Visitors = guests;
        }

        protected bool Equals(SearchQuery other)
        {
            return City == other.City && ArrivalDate == other.ArrivalDate && 
                   DepartureDate == other.DepartureDate && Visitors == other.Visitors;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((SearchQuery) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (City != null ? City.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ArrivalDate != null ? ArrivalDate.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (DepartureDate != null ? DepartureDate.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Visitors != null ? Visitors.GetHashCode() : 0);
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(City)}: {City}, {nameof(ArrivalDate)}: {ArrivalDate}," +
                   $" {nameof(DepartureDate)}: {DepartureDate}, {nameof(Visitors)}: {Visitors}";
        }
    }
}
