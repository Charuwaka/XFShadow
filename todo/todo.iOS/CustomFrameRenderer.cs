using System;
using CoreGraphics;
using todo.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Frame), typeof(CustomFrameRenderer))]
namespace todo.iOS
{
    public class CustomFrameRenderer : FrameRenderer
    {
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);

            Layer.ShadowRadius = 8.0f;
            Layer.ShadowColor = UIColor.Gray.CGColor;
            Layer.ShadowOffset = new CGSize(2, 2);
            Layer.ShadowOpacity = 0.80f;
            Layer.ShadowPath = UIBezierPath.FromRect(Layer.Bounds).CGPath;
            Layer.MasksToBounds = false;


            //Layer.ShadowRadius = 8;
            //Layer.ShouldRasterize = true;
            //Layer.ShadowColor = UIColor.Gray.CGColor;
            //Layer.ShadowOffset = new CGSize(0, 1);
            //Layer.ShadowOpacity = 0.25f;
            //Layer.ShadowPath = UIBezierPath.FromRoundedRect(Layer.Bounds, Element.CornerRadius).CGPath;
            //Layer.MasksToBounds = false;
        }
    }
}
