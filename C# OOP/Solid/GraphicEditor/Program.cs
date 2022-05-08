namespace GraphicEditor
{
    using Editors;
    using Shapes;

    public class StartUp
    {
        public static void Main()
        {
            var circle = new Circle();
            var square = new Square();

            var editor = new GraphicEditor();
            editor.DrawShape(circle);
            editor.DrawShape(square);
        }
    }
}