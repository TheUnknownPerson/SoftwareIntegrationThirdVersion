using System;
using System.Collections.Generic;

namespace SoftwareIntegrationThirdVersion.Models
{
    public class Exercise
    {
        public int exerciseId { get; set; }
        public int gymId { get; set; }
        public string exerciseName { get; set; }
        public string exerciseDescription { get; set; }
        public string exerciseDuration { get; set; }

        public ICollection<Exercise> Exercises { get; set; }
    }
}