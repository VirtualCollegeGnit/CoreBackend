﻿namespace core.data.Model.Address
{
    public class City
    {
        public City(string name)
        {
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual District? District { get; set; }
    }
}