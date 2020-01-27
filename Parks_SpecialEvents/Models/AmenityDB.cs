using System;
using System.Collections.Generic;

namespace Parks_SpecialEvents.Models
{
    public class AmenityDB
    {
        public List<Amenity> amenities = new List<Amenity>();
        public IEnumerable<Amenity> Amenities { get { return amenities; } }

        public void addAmenity(Amenity a)
        {
            amenities.Add(a);
        }
    }
}
