﻿using System;
using System.Collections.Generic;
using TarsOffice.DayFeatures.Abstractions;

namespace TarsOffice.DayFeatures
{
    public class CroissantDayFeature : IDayFeature
    {
        private static DateTime FirstOccourrence = new DateTime(2021, 11, 24);
        public string Name => "Croissant";

        public bool IsSatisfiedBy(DateTime date)
        {
            var days = date.Subtract(FirstOccourrence);
            return days.Days % 14 == 0 || (days.Days + 5) % 14 == 0; // occurs every 15 days
        }

        public IEnumerable<Tag> Render(DateTime date)
        {
            return new Tag[] {
                new Tag
                {
                    Type= "img",
                    Properties =
                    {
                        { "src" , "/img/icons8-croissant-48.png" },
                        { "style", "width: 20px" }
                    }
                }
            };
        }
    }
}
