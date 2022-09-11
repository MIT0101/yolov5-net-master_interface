using System;
using System.Collections.Generic;
using System.Drawing;
using Yolov5Net.Scorer;
using Yolov5Net.Scorer.Models;

namespace Yolov5Net.App
{
    public static class Program
    {
        public static void Detect(Image image,string objectToDetect,out Bitmap resultImage,out double scoreResult) {

            //using var image = Image.FromFile("C:\\Users\\M_IT_01\\Desktop\\Files\\photo\\photo_2022-05-27_00-51-22.jpg");

            using var scorer = new YoloScorer<YoloCocoP5Model>("Assets/Weights/yolov5n.onnx");

            List<YoloPrediction> predictions = scorer.Predict(image);

            using var graphics = Graphics.FromImage(image);
            scoreResult = 0.0;

            foreach (var prediction in predictions) // iterate predictions to draw results
            {
                double score = Math.Round(prediction.Score, 2);

                graphics.DrawRectangles(new Pen(prediction.Label.Color, 1),
                    new[] { prediction.Rectangle });

                var (x, y) = (prediction.Rectangle.X - 3, prediction.Rectangle.Y - 23);

                graphics.DrawString($"{prediction.Label.Name} ({score})",
                    new Font("Consolas", 16, GraphicsUnit.Pixel), new SolidBrush(prediction.Label.Color),
                    new PointF(x, y));
                if (objectToDetect.Equals(prediction.Label.Name)) {
                    scoreResult = score;

                }
            }


            //image.Save("C:\\Users\\M_IT_01\\Desktop\\result2.jpg");
            resultImage = new Bitmap(image);
        }

        static void Main(string[] args)
        {
            ////using var image = Image.FromFile("Assets/test.jpg");
            //using var image=Image.FromFile("C:\\Users\\M_IT_01\\Desktop\\Files\\photo\\photo_2022-05-27_00-51-22.jpg");

            //using var scorer = new YoloScorer<YoloCocoP5Model>("Assets/Weights/yolov5n.onnx");

            //List<YoloPrediction> predictions = scorer.Predict(image);

            //using var graphics = Graphics.FromImage(image);

            //foreach (var prediction in predictions) // iterate predictions to draw results
            //{
            //    double score = Math.Round(prediction.Score, 2);

            //    graphics.DrawRectangles(new Pen(prediction.Label.Color, 1),
            //        new[] { prediction.Rectangle });

            //    var (x, y) = (prediction.Rectangle.X - 3, prediction.Rectangle.Y - 23);

            //    graphics.DrawString($"{prediction.Label.Name} ({score})",
            //        new Font("Consolas", 16, GraphicsUnit.Pixel), new SolidBrush(prediction.Label.Color),
            //        new PointF(x, y));
            //}

            //image.Save("C:\\Users\\M_IT_01\\Desktop\\Files\\photo\\result.jpg");
        }
    }
}
