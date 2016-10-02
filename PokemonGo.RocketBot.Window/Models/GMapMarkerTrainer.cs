﻿using System.Drawing;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace PokemonGo.RocketBot.Window.Models
{
    public class GMapMarkerTrainer : GMapMarker
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="p">The position of the marker</param>
        public GMapMarkerTrainer(PointLatLng p, Image image)
            : base(p)
        {
            MarkerImage = image;
            Size = MarkerImage.Size;
            Offset = new Point(-Size.Width/2, -Size.Height/2);
        }

        /// <summary>
        ///     The image to display as a marker.
        /// </summary>
        public Image MarkerImage { get; set; }

        public override void OnRender(Graphics g)
        {
            g.DrawImage(MarkerImage, LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
        }
    }
}