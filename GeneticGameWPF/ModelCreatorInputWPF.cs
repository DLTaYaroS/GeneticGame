using System.Windows.Media;
using GeneticGameLogic.Graphic;
namespace GeneticGameWPF
{
    class ModelCreatorInputWPF: IModelCreatorInput
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int StrokeThickness { get; set; }
        public double Right { get; set; }
        public double Bottom { get; set; }    
        public Color? ColorModel { get; set; } //if Color must be random: Color==NULL 
    }
    
}
