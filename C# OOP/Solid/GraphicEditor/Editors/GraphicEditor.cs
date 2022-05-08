namespace GraphicEditor.Editors
{
    using Interfaces;
    using System;

    public class GraphicEditor
    {
        public void DrawShape(IShape shape) => Console.WriteLine(shape.Draw());
    }
}
