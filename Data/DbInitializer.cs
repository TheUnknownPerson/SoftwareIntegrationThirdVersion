using SoftwareIntegrationThirdVersion.Models;
using System;
using System.Linq;

namespace SoftwareIntegrationThirdVersion.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GymContext context)
        {
            context.Database.EnsureCreated();

            if (context.Gyms.Any())
            {
                return;
            }

            var gyms = new Gym[]
            {
                new Gym{gymName="Sport Life",gymAddress="Puerto Varas"},
                new Gym{gymName="Pacific Fitness",gymAddress="Santiago"}
            };

            foreach(Gym g in gyms)
            {
                context.Gyms.Add(g);
            }
            context.SaveChanges();

            if (context.Exercises.Any())
            {
                return;
            }

            var exercises = new Exercise[]
            {
                new Exercise{gymId=1,exerciseName="Trote",exerciseDescription="Trote de calentamiento",exerciseDuration="25 minutos"},
                new Exercise{gymId=1,exerciseName="Sparring",exerciseDescription="Práctica de boxeo",exerciseDuration="30 minutos"},
                new Exercise{gymId=2,exerciseName="Yoga",exerciseDescription="Clase de yoga",exerciseDuration="1 hora"}
            };

            foreach(Exercise e in exercises)
            {
                context.Exercises.Add(e);
            }
            context.SaveChanges();
        }
    }
}