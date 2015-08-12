using System;
using Stayn.Core.API;

namespace Stayn.Models
{
    public class CommissionModel
    {
        public ApplicationUser Commissioner { get; }
        public ArtistModel Artist { get; }
        public DateTime CommissionedOn { get; }

        public string Description { get; set; }
        public string[] Tags { get; set; }
        public CommissionType CommissionType { get; set; }
        //public Image Product { get; set; }

        public DateTime RequestedCompletion { get; set; }
        public DateTime ActualCompletion { get; set; }

        public byte Rating { get; set; }
        public string Comments { get; set; }

        public CommissionModel(ApplicationUser c, ArtistModel a)
        {
            Commissioner = c;
            Artist = a;
            CommissionedOn = DateTime.Now;
        }
    }

    public class AnonRatingModel
    {
        public byte Rating { get; }
        public string Comments { get; }

        public AnonRatingModel(CommissionModel comm)
        {
            Rating = comm.Rating;
            Comments = comm.Comments;
        }
    }
}
