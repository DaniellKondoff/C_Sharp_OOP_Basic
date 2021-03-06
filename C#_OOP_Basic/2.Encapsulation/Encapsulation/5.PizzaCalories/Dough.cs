﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }
        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {

                }
                this.bakingTechnique = value;
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 1 || value >200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double GetCalories()
        {
            return 2 * this.Weight * this.GetTechMod() * this.GetTypeMod();
        }

        private double GetTypeMod()
        {
            if (this.FlourType.ToLower() == "white")
            {
                return 1.5;
            }

            return 1;
        }

        private double GetTechMod()
        {
            if (this.BakingTechnique.ToLower() == "crispy")
            {
                return 0.9;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                return 1.1;
            }

            return 1;
        }
    }
}
